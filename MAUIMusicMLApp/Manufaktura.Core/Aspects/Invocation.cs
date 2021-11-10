using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Manufaktura.Core.Aspects
{
    public class Invocation
    {
        private readonly Invocation innerInvocation;
        private readonly IAspect aspect;
        private readonly object target;
        private readonly object[] parameters;
        private readonly IDependencyResolver dependencyResolver;

        public Invocation(object target, object[] parameters, IAspect aspect, Invocation innerInvocation, IDependencyResolver dependencyResolver)
        {
            this.target = target;
            this.innerInvocation = innerInvocation;
            this.aspect = aspect;
            this.parameters = parameters;
            this.dependencyResolver = dependencyResolver;
        }

        public object Continue() => aspect.Invoke(target, parameters, innerInvocation, dependencyResolver);

        public async Task ContinueAsync() => await aspect.InvokeAsync(target, parameters, innerInvocation, dependencyResolver);

        public static Invocation Create(MethodInfo method, object target, object[] parameters, IEnumerable<IAspect> aspects, IDependencyResolver dependencyResolver)
        {
            var aspectStack = new Stack<IAspect>(aspects);
            aspectStack.Push(new InvokeMethodAspect(method));
            Invocation innerInvocation = null;
            while (aspectStack.Count > 0)
            {
                var currentInvocation = new Invocation(target, parameters, aspectStack.Pop(), innerInvocation, dependencyResolver);
                innerInvocation = currentInvocation;
            }
            return innerInvocation;
        }
    }
}