using System;

namespace SchoolApi.Models
{
    public class School
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string HolderId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public virtual Holder Holder { get; set; }
    }
}