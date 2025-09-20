namespace Hotels.Application.Common;

public record Error(string Code, string Description)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error DatabaseSaveError =
        new("Database.SaveError", "An error occurred while saving to the database.");

}