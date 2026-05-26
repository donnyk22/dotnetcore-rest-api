namespace dotnetcore_web_api.Models.Enums;

public enum UserGender
{
    M,
    F,
}

public static class UserGenderExtensions
{
    public static string GetVal(this UserGender gender) => gender switch
    {
        UserGender.M => "Male",
        UserGender.F => "Female",
        _ => string.Empty,
    };

    public static string GetVal(char gender) => gender switch
    {
        'M' => UserGender.M.GetVal(),
        'F' => UserGender.F.GetVal(),
        _ => string.Empty,
    };
}
