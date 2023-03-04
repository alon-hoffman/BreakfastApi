namespace Breakfast.Contract.BreakfastRequest
{
    public record CreateBreakfastRequest(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string>Savory,
        List<string>Sweet
    );
}