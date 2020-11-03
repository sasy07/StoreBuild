namespace StoreBuild.Application.Convertors
{
    public class FixedText
    {
        public static string FixMobile(string mobile)
        {
            return mobile.Trim().ToLower();
        }
    }
}