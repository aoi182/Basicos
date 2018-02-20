﻿using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ReadWriteConfigFile
{
    static class MyConfigSettings
    {
        private static readonly object Locker = new object();
        public static string ReadSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        
        public static void WriteSetting(string key, string value)
        {
            lock (Locker)
            {
                // load config document for current assembly
                XmlDocument doc = LoadConfigDocument();

                // retrieve appSettings node
                XmlNode node = doc.SelectSingleNode("//appSettings");

                if (node == null)
                    throw new InvalidOperationException("appSettings section not found in config file.");

                // select the 'add' element that contains the key
                XmlElement elem = (XmlElement)node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    // add value for key
                    elem.SetAttribute("value", value);
                }
                else
                {
                    // key was not found so create the 'add' element 
                    // and set it's key/value attributes 
                    elem = doc.CreateElement("add");
                    elem.SetAttribute("key", key);
                    elem.SetAttribute("value", value);
                    node.AppendChild(elem);
                }
                doc.Save(GetConfigFilePath());
            }
        }

        public static void RemoveSetting(string key)
        {
            // load config document for current assembly
            XmlDocument doc = LoadConfigDocument();

            // retrieve appSettings node
            XmlNode node = doc.SelectSingleNode("//appSettings");

            try
            {
                if (node == null)
                    throw new InvalidOperationException("appSettings section not found in config file.");
                else
                {
                    // remove 'add' element with coresponding key
                    node.RemoveChild(node.SelectSingleNode(string.Format("//add[@key='{0}']", key)));
                    doc.Save(GetConfigFilePath());
                }
            }
            catch (NullReferenceException e)
            {
                throw new Exception(string.Format("The key {0} does not exist.", key), e);
            }
        }

        private static XmlDocument LoadConfigDocument()
        {
            try
            {
                var doc = new XmlDocument();
                doc.Load(GetConfigFilePath());
                return doc;
            }
            catch (FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        private static string GetConfigFilePath()
        {
            return Assembly.GetExecutingAssembly().Location + ".config";
        }
    }
}
