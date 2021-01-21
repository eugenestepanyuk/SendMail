using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SendMail
{
    [Serializable]

    static class MailSettings
    {
        public static string Email { get; set; }
        public static string SenderName { get; set; }
        public static string SendingMail { get; set; }
        public static string SendingLogin { get; set; }
        public static string SendingPassword { get; set; }
        public static string ReceivingMail { get; set; }
        public static string ReceivingLogin { get; set; }
        public static string ReceivingPassword { get; set; }

        //public static MailSettings(string email, string senderName)
        //{
        //    Email = email;
        //    SenderName = senderName;
        //}

        //public override string ToString()
        //{
        //    return String.Format("Email={0}; SenderName={1};", Email, SenderName);
        //}

        //// Получаем полный путь к файлу с настройками
        //protected string GetFileXML()
        //{
        //    string fullPath = System.Reflection.Assembly.GetAssembly(typeof(MailSettings)).Location;                    // Получаем полное местоположение exe файла сборки 
        //    string theDirectory = Path.GetDirectoryName(fullPath);                                                      // Получаем папку в котором он находится
        //    return theDirectory + @"\MailSettings.xml";
        //}

        ////Загрузка данных для настройки почты с файла        
        //public MailSettings LoadFile()
        //{
        //    try
        //    {
        //        MailSettings result;
        //        XmlSerializer formatter = new XmlSerializer(typeof(MailSettings));
        //        using (var fs = new FileStream(GetFileXML(), FileMode.Open))
        //        {
        //            result = (MailSettings)formatter.Deserialize(fs);
        //        }
        //        return result;
        //    }
        //    catch
        //    {
        //        throw new Exception("Помилка! З'єднання розірвано");
        //    }
        //}

        ////Сохранение данных для настройки почты в файл
        //public void SaveFile(object obj)
        //{
        //    try
        //    {
        //        XmlSerializer formatter = new XmlSerializer(obj.GetType());
        //        using (var fs = new FileStream(GetFileXML(), FileMode.Create))
        //        {
        //            formatter.Serialize(fs, obj);
        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Помилка! Файл не збережено");
        //    }
        //}
    }
}
