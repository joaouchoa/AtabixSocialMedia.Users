using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Core.Events
{
    public class UserCreatedEvent : IEvent
    {
        public string Email { get; set; }
        private string DisplayName { get; set; }

        public UserCreatedEvent(string email, string displayName)
        {
            Email = email;
            DisplayName = displayName;
        }
    }
}
