using MediatR;

namespace EShop.Framework.CQRS;

public interface ICommand<out TResponse> : IRequest<TResponse>
{

}
public interface ICommand : IRequest<Unit>
{

}