namespace Breakfast.Contract.BreakfastResponse
{
    public record UpsertBreakfastRequest(
        Guid Id,
        string Name,
        string Description,
        DateTime startDateTime,
        DateTime endDateTime,
        List<string>Savory,
        List<string>Sweet
    );
}