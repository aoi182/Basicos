using System.Configuration;

namespace ReadWriteConfigFile
{
    static class Program
    {
        static void Main(string[] args)
        {
            string test1 = MyConfigSettings.ReadSetting("serial");

            // write a new value for the Test1 setting
            MyConfigSettings.WriteSetting("serial", "This is my new value");

            // remove the Test1 setting from the config file
            //MyConfigSettings.RemoveSetting("serial");
        }

        private static string ReadKey(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            
            return value;
        }

        private static void WriteValue(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}