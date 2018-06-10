using System;

namespace HelloNetCore.Entities
{
    public class PostEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Guid BlogId { get; set; }
        public virtual BlogEntity Blog { get; set; }
    }
}
