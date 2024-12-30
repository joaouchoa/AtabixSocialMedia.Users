using AtabixSocialMedia.Users.Application.Models;
using AtabixSocialMedia.Users.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Application.Commands.SingUpUser
{
    public record SignUpUserCommand(
        string FullName,
        string DisplayName,
        DateTime BirthDate,
        string Email) : IRequest<BaseResult<Guid>>
    {
        public User ToEntity() => new User(FullName, DisplayName, BirthDate, Email);
    }

}
