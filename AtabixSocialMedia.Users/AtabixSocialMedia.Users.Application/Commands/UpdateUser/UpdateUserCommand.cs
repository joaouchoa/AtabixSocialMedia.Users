using AtabixSocialMedia.Users.Application.Models;
using AtabixSocialMedia.Users.Core.ValueObject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Application.Commands.UpdateUser
{
    public record UpdateUserCommand(Guid Id, string DisplayName, string Header, string Description, LocationInfoModel Location, ContactInfoModel Contact) : IRequest<BaseResult> 
    {

    }
}
