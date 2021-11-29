﻿using mediator_cqrs_project.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mediator_cqrs_project.Commands
{
    public class RegisterAccountCommand : IRequest<string>
    {
        public string DocumentNumber { get; set; }

        public EnumAccountTypes AccountType { get; set; }

        public string AccountOwner { get; set; }
    }
}
