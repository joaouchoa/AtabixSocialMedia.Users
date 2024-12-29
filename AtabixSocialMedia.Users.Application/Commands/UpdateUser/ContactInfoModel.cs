using AtabixSocialMedia.Users.Core.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Application.Commands.UpdateUser
{
    public record ContactInfoModel(
        string Email,
        string WebSite,
        string PhoneNumber
    )
    { 
        public ContactInfo ToValueObject() => new ContactInfo(Email, WebSite, PhoneNumber);
    }
}
