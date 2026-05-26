namespace dotnetcore_web_api.Models.Enums;

// NOTE: name "Action" collides with System.Action delegate. When both `System` and
// this namespace are in scope, reference this type as `Models.Enums.Action` or
// alias it: `using ActionEnum = dotnetcore_web_api.Models.Enums.Action;`
public enum Action
{
    POST,
    GET,
    PUT,
    PATCH,
    DELETE,
}

public static class ActionExtensions
{
    public static string GetValue(this Action action) => action switch
    {
        Action.POST => "create",
        Action.GET => "get",
        Action.PUT => "change",
        Action.PATCH => "change",
        Action.DELETE => "delete",
        _ => string.Empty,
    };
}
