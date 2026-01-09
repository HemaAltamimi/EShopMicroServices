using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Framework.CQRS
{
    public interface ICommndHandler<in TCommand> : ICommndHandler<TCommand,Unit>
    where TCommand : ICommand<Unit>
    {

    }

    public interface ICommndHandler<in TCommand,TResponse>: IRequestHandler<TCommand,TResponse> 
        where TCommand : ICommand<TResponse> 
        where TResponse : notnull
    {

    }
}
