using System;
using FinancingManager.Models;
using FluentValidation;

public class LoginValidator : AbstractValidator<LoginModel>
{
	public LoginValidator()
	{
		RuleFor(x => x.Login)
			.NotEmpty();
		RuleFor(x => x.Password)
			.NotEmpty();
	}
}
