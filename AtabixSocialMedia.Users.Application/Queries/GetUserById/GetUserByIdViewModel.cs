namespace AtabixSocialMedia.Users.Application.Queries.GetUserById
{
    public record GetUserByIdViewModel(
        string DisplayName,
        DateTime BirthDate, 
        string? Header, 
        string? Description, 
        string? Country, 
        string? Website);
}