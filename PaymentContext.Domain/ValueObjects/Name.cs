using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsMinValue(3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .IsMinValue(3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
