using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Customers;


public sealed class Customer : AggregateRoot
{
    public CustomerId Id { get; private set; }// = new(Guid.NewGuid());
    public string Name { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string FullName => $"{Name} {LastName}";

    public string Email { get; private set; } = string.Empty;

    public PhoneNumber PhoneNumber { get; private set; }

    public Address Address { get; private set; }

    public bool Active { get; private set; }

    private Customer() { }

    public Customer(CustomerId id, string name, string lastName, string email, PhoneNumber phoneNumber, Address address, bool active)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        Active = active;
        //Raise(new CustomerCreated(Id, name, lastName, email, phoneNumber, address));
    }

    /* public Customer(string name, PhoneNumber phoneNumber)
     {
         Name = name;
         PhoneNumber = phoneNumber;
     }



     public void ChangeName(string name)
     {
         Name = name;
         Raise(new CustomerNameChanged(Id, name));
     }

     public void ChangePhoneNumber(PhoneNumber phoneNumber)
     {
         PhoneNumber = phoneNumber;
         Raise(new CustomerPhoneNumberChanged(Id, phoneNumber));
     }*/
}