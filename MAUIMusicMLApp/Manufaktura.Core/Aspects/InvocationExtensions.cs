using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Manufaktura.Core.Aspects
{
    public static class InvocationExtensions
    {
        public static object InvokeWithAspects(this MethodInfo method, object target, object[] parameters, IDependencyResolver dependencyResolver)
        {
            var aspects = method.GetCustomAttributes().OfType<IAspect>().ToArray();
            var invocation = Invocation.Create(method, target, parameters, aspects, dependencyResolver);
            return invocation.Continue();
        }

        public static async Task InvokeWithAspectsAsync(this MethodInfo method, object target, object[] parameters, IDependencyResolver dependencyResolver)
        {
            var aspects = method.GetCustomAttributes().OfType<IAspect>().ToArray();
            var invocation = Invocation.Create(method, target, parameters, aspects, dependencyResolver);
            await invocation.ContinueAsync();
        }
    }
}