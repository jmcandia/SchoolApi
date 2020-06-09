using System;
using System.Collections.Generic;

namespace SchoolApi.Models
{
    public class Holder
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}