
namespace Zouave.Services.Events
{
    public interface IConsumer<T>
    {
        void HandleEvent(T eventMessage);
    }
}
