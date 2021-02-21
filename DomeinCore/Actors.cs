using System;

namespace DomeinCore
{
    public class Actor : IDomainObject
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}