namespace Hotels.Application.User;

public record CurrentUser(string Id, string Email, string Role)
{
    public bool  IsInRole(string role) => role==Role;
}