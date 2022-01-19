namespace VirtualChat.Services.Services;

/// <summary>
/// Generator string id
/// </summary>
internal static class GeneratorStringId
{
    #region Public Methods
    public static string GetNewStringId()
    {
        string strId = Guid.NewGuid().ToString();
        return strId;
    }
    #endregion
}