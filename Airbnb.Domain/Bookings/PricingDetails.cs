using Airbnb.Domain.Shared;

namespace Airbnb.Domain.Bookings;

public sealed record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice
    );
