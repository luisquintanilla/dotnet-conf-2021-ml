using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Manufaktura.Core.Aspects
{
    public class BusyIndicatorAspectAttribute : Attribute, IAspect
    {
        private readonly string[] propertyPath;

        public BusyIndicatorAspectAttribute(params string[] propertyPath)
        {
            this.propertyPath = propertyPath;
        }

        public bool DoNotExecuteIfBusy { get; set; }

        public object Invoke(object target, object[] parameters, Invocation invocation, IDependencyResolver dependencyResolver)
        {
            throw new NotImplementedException("This aspect is not intended to run synchronously");
        }

        public async Task InvokeAsync(object target, object[] parameters, Invocation invocation, IDependencyResolver dependencyResolver)
        {
            var indicatorProperty = GetPropertyFromPath(target, propertyPath);
            if (DoNotExecuteIfBusy)
            {
                var inProgress = (bool)indicatorProperty.Item1.GetValue(indicatorProperty.Item2);
                if (inProgress) return;
            }

            try
            {
                indicatorProperty.Item1.SetValue(indicatorProperty.Item2, true);
                await invocation.ContinueAsync();
            }
            finally
            {
                indicatorProperty.Item1.SetValue(indicatorProperty.Item2, false);
            }
        }

        private static Tuple<PropertyInfo, object> GetPropertyFromPath(object target, string[] propertyPath)
        {
            var firstProperty = target.GetType().GetRuntimeProperty(propertyPath[0]);
            if (propertyPath.Length == 1) return new Tuple<PropertyInfo, object>(firstProperty, target);

            var newTarget = firstProperty.GetValue(target);
            return GetPropertyFromPath(newTarget, propertyPath.Skip(1).ToArray());
        }
    }
}