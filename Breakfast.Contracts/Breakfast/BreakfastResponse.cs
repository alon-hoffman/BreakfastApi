namespace Breakfast.Contract.BreakfastResponse
{
    public record CreateBreakfastResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime startDateTime,
        DateTime endDateTime,
        DateTime LastModifiedDateTime,
        List<string>Savory,
        List<string>Sweet
    );
}