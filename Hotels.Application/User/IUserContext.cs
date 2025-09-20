namespace Hotels.Application.User;

public interface IUserContext
{
    CurrentUser? GetCurrentUser();
}