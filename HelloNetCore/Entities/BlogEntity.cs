using System;
using System.Collections.Generic;

namespace HelloNetCore.Entities
{
    public class BlogEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual List<PostEntity> Posts { get; set; }
    }
}
