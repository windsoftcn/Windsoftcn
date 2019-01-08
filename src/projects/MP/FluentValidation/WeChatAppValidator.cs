using FluentValidation;
using MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.FluentValidation
{
    public class WeChatAppValidator : AbstractValidator<WeChatApp>
    {
        public WeChatAppValidator()
        {
            RuleFor(x => x.AppId).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.AppAlias).Length(6);
        }
    }
}
