using AtabixSocialMedia.Users.Core.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Application.Commands.UpdateUser
{
    public record LocationInfoModel(
        string City,
        string State,
        string Country
    )
    {
        public LocationInfo ToValueObject() => new LocationInfo(City, State, Country);
    }
}
