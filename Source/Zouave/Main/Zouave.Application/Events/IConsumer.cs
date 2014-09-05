
namespace Zouave.Application.Events
{
    public interface IConsumer<T>
    {
        void HandleEvent(T eventMessage);
    }
}
