namespace Domain.ValueObjects;
public partial record Address(string Country, string Line1, string Line2, string City, string State, string ZipCode)
{

    public static Address? Create(string country, string line1, string line2, string city, string state, string zipCode)
    {
        if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(line1) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(state) || string.IsNullOrEmpty(zipCode))
        {
            return null;
        }

        return new Address(country, line1, line2, city, state, zipCode);
    }

}
