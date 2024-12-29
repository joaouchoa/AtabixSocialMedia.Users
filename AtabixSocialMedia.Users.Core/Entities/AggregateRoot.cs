using AtabixSocialMedia.Users.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Core.Entities
{
    public abstract class AggregateRoot : BaseEntity
    {
        public List<IEvent> Events { get; set; }
        public AggregateRoot()
        {
            Events = new List<IEvent>();
        }
    }
}
