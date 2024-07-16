using FluentValidation;
using InfucareRxForm.Shared.Dtos.Request;

namespace InfucareRxForm.WebAPI.Validators;

public class PatientCreateRequestDtoValidator : AbstractValidator<PatientCreateRequestDto>
{
    public PatientCreateRequestDtoValidator()
    {
        RuleFor(x => x.Email)
            .NotNull();

    }
}