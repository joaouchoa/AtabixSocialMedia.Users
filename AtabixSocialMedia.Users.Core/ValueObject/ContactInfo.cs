using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Core.ValueObject
{
    public record ContactInfo(
        string Email,
        string WebSite,
        string PhoneNumber);
}
