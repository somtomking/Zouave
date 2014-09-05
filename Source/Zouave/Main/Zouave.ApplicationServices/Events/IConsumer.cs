
namespace Zouave.ApplicationServices.Events
{
    public interface IConsumer<T>
    {
        void HandleEvent(T eventMessage);
    }
}
