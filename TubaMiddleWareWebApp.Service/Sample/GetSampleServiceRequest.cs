using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;

namespace TubaMiddleWareWebApp.Service.Sample
{
    public class GetSampleServiceRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class GetSampleServiceRequestValidator : AbstractValidator<GetSampleServiceRequest>
    {
        public GetSampleServiceRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("hey it is not valid!");
        }
    }

    public class GetSampleServiceRequestHandler : IRequestHandler<GetSampleServiceRequest, bool>
    {
        public async Task<bool> Handle(GetSampleServiceRequest request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}