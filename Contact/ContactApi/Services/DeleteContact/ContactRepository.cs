﻿////https://orkhanscience.medium.com/software-architecture-patterns-5-mins-read-e9e3c8eb47d2

namespace ContactApi.Services.DeleteContact
{
    public abstract class ContactRepository
    {
        public abstract Task Delete(Guid id);
    }
}
