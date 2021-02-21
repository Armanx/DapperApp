using System;

namespace DomeinCore
{
    public class Genre : IDomainObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}