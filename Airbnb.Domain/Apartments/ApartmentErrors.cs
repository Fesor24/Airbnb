using Airbnb.Domain.Abstractions;

namespace Airbnb.Domain.Apartments;

public static class ApartmentErrors
{
    public static Error NotFound = new("Apartment.NotFound", "Apartment not found");
}
