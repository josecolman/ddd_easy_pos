using MediatR;

namespace Application.Customers.Create;

public record CreateCustomerCommand(

    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Country,
    string Line1,
    string Line2,
    string City,
    string State,
    string ZipCode,
    bool Active

) : IRequest<Unit>;