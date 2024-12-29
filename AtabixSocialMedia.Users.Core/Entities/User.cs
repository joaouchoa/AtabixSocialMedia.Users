using AtabixSocialMedia.Users.Core.Enums;
using AtabixSocialMedia.Users.Core.Events;
using AtabixSocialMedia.Users.Core.ValueObject;

namespace AtabixSocialMedia.Users.Core.Entities
{
    public class User : AggregateRoot
    {
        public string FullName { get; private set; }
        public string DisplayName { get; private set; }
        public string? Header { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string? Description { get; private set; }
        public string Email { get; private set; }
        public EUserStatus Status { get; private set; }
        public LocationInfo? Location { get; private set; }
        public ContactInfo? Contact { get; private set; }

        public User(string fullName, string displayName, DateTime birthDate, string email) : base()
        {
            FullName = fullName;
            DisplayName = displayName;
            BirthDate = birthDate;
            Email = email;

            Status = EUserStatus.Active;
            Events.Add(new UserCreatedEvent(email, displayName));
        }

        public void Update(string displayName, string header, string description, LocationInfo location, ContactInfo contact)
        {
            DisplayName = displayName;
            Header = header;
            Description = description;
            Location = location;
            Contact = contact;
        }
    }
}
