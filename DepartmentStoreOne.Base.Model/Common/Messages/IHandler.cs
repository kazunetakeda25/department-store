using System.Threading.Tasks;

namespace Department.Base.Model.Common.Messages
{
    public interface IHandler<in T> where T : IMessage
    {
        Task Handle(T message);
    }
}