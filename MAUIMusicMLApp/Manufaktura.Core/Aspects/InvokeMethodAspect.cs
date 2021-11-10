using System.Reflection;
using System.Threading.Tasks;

namespace Manufaktura.Core.Aspects
{
    public class InvokeMethodAspect : IAspect
    {
        private readonly MethodInfo method;

        public InvokeMethodAspect(MethodInfo method)
        {
            this.method = method;
        }

        public object Invoke(object target, object[] parameters, Invocation invocation, IDependencyResolver dependencyResolver)
        {
            return method.Invoke(target, parameters);
        }

        public async Task InvokeAsync(object target, object[] parameters, Invocation invocation, IDependencyResolver dependencyResolver)
        {
            if (method.ReturnType == typeof(Task) || method.ReturnType.GetTypeInfo().IsSubclassOf(typeof(Task)))
            {
                await (Task)method.Invoke(target, parameters);
            }
            else if (method.ReturnType == typeof(void))
            {
                method.Invoke(target, parameters);
                await Task.FromResult(true);
            }
            else
            {
                var result = method.Invoke(target, parameters);
                await Task.FromResult(result);
            }
        }
    }
}