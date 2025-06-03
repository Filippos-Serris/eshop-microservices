using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
    // interface for not returning any response
    public interface ICommand : ICommand<Unit> { }

    // interface fro returning response
    public interface ICommand<out TResponse> : IRequest<TResponse> { }
}
