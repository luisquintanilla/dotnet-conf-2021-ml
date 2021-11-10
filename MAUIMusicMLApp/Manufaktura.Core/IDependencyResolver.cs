namespace Manufaktura.Core
{
    public interface IDependencyResolver
    {
        T Get<T>();
    }
}