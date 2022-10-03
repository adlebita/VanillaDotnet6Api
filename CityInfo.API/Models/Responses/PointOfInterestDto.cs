namespace CityInfo.API.Models.Responses;

public sealed record PointOfInterestDto(Guid Id, string Name)
{
    public string? Description { get; set; }
}