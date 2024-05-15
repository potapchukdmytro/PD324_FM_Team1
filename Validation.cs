﻿using System;
using FluentValidation;

public class LoginValidator
{
	public LoginValidator()
	{
		RuleFor(x => x.Login)
			.NotEmpty()
        RuleFor(x=>x.Password)
			.NotEmpty()
	}
}
