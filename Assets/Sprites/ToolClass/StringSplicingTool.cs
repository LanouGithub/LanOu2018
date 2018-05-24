/// <summary>
/// 字符串拼接工具
/// </summary>
public struct StringSplicingTool
{
    public static string StringSplicing(string stringA, string stringB)
    {
        return string.Format("{0}{1}", stringA, stringB);
    }
    public static string StringSplicing(string stringA, string stringB, string stringC)
    {
        return string.Format("{0}{1}{2}", stringA, stringB, stringC);
    }
    public static string StringSplicing(string stringA, string stringB, string stringC, string stringD)
    {
        return string.Format("{0}{1}{2}", stringA, stringB, stringC, stringD);
    }
    public static string StringSplicing(string stringA, string stringB, string stringC, string stringD, string stringE)
    {
        return string.Format("{0}{1}{2}", stringA, stringB, stringC, stringD, stringE);
    }
    public static string StringSplicing(string stringA, string stringB, string stringC, string stringD, string stringE, string stringF)
    {
        return string.Format("{0}{1}{2}", stringA, stringB, stringC, stringD, stringE, stringF);
    }
}
