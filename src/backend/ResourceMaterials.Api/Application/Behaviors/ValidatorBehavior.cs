using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace ResourceMaterials.Api.Application.Behaviors
{
    public class ValidatorBehavior<TReq, TRes> : IPipelineBehavior<TReq, TRes>
    {
        private readonly IValidator<TReq>[] _validators;

        public ValidatorBehavior(IValidator<TReq>[] validators)
        {
            _validators = validators;
        }

        public async Task<TRes> Handle(TReq request, CancellationToken cancellationToken, RequestHandlerDelegate<TRes> next)
        {
            List<ValidationFailure> failures = _validators.Select(a => a.Validate(request))
                .SelectMany(res => res.Errors).Where(err => err != null).ToList();
            if (failures.Any())
            {
                throw new Exception($"Queries Validation Errors for type {typeof(TReq).Name}", new ValidationException("Validation exception", failures));
            }

            TRes response = await next();
            return response;
        }
    }
}