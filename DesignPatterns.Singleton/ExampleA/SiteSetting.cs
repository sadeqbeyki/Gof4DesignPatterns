namespace DesignPatterns.Singleton.ExampleA;

public class SiteSetting
{
    public string SiteName { get; set; }
    public string FooterText { get; set; }

    // جلوگیری از ساخت نمونه
    private SiteSetting()
    {
    }
    private static readonly SiteSetting _instance = new SiteSetting();
    public static SiteSetting Instance
    {
        get
        {
            return _instance;
        }
    }
}
