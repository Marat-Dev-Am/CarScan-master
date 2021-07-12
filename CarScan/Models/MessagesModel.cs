using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarScan.Models;

namespace CarScan.Models
{
    public class MessagesModel
    {
        #region Words
        public static string Submit = LanguagesModel.CurrentLanguage == "ARM" ? "Ներկայացնել" : "Представлять";
        public static string Cancel = LanguagesModel.CurrentLanguage == "ARM" ? "Չեղարկել" : "Отмена";
        public static string Next = LanguagesModel.CurrentLanguage == "ARM" ? "Առաջ" : "Вперед";
        public static string Prev = LanguagesModel.CurrentLanguage == "ARM" ? "Հետ" : "Назад";
        public static string Close = LanguagesModel.CurrentLanguage == "ARM" ? "փակել" : "Закрывать";
        public static string Print = LanguagesModel.CurrentLanguage == "ARM" ? "Տպել" : "Распечатать";
        #endregion
        #region Messages

        #endregion

        #region Methods
        public static void ReflasheMessages()
        {
            Submit = LanguagesModel.CurrentLanguage == "ARM" ? "Ներկայացնել" : "Представлять";
            Cancel = LanguagesModel.CurrentLanguage == "ARM" ? "Չեղարկել" : "Отмена";
            Next = LanguagesModel.CurrentLanguage == "ARM" ? "Առաջ" : "Вперед";
            Prev = LanguagesModel.CurrentLanguage == "ARM" ? "Հետ" : "Назад";
            Close = LanguagesModel.CurrentLanguage == "ARM" ? "փակել" : "Закрывать";
            Print = LanguagesModel.CurrentLanguage == "ARM" ? "Տպել" : "Распечатать";
        }
        #endregion

    }
}
