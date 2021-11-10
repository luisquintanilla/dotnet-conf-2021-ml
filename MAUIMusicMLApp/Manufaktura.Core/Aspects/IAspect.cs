using System.Threading.Tasks;

namespace Manufaktura.Core.Aspects
{
    public interface IAspect
    {
        object Invoke(object target, object[] parameters, Invocation invocation, IDependencyResolver dependencyResolver);

        Task InvokeAsync(object target, object[] parameters, Invocation invocation, IDependencyResolver dependencyResolver);
    }
}