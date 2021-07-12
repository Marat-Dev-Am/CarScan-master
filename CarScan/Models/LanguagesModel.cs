using CarScan.Docs;

namespace CarScan.Models
{
    public class LanguagesModel
    {
        public static string CurrentLanguage = Constants.DefaultLanguage;

        public static void ChangeLanguages(string language)
        {
            if (string.IsNullOrEmpty(language) || language.ToUpper() == CurrentLanguage.ToUpper())
            {
                return;
            }
            CurrentLanguage = language;
            MessagesModel.ReflasheMessages();
        }
    }
}
