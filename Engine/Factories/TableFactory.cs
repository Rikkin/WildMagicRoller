using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using System.IO;
using System.Xml;

namespace Engine.Factories
{
    public static class TableFactory
    {
        private const string OFFICIALTABLE_FILENAME = ".\\Tables\\OfficialTable.xml";
        private const string CUSTOMTABLE_FILENAME = ".\\Tables\\CustomTable.xml";

        private static readonly List<WildMagic> _wildMagicTable = new List<WildMagic>();
        private static readonly List<WildMagic> _customWildMagicTable = new List<WildMagic>();

        static TableFactory()
        {
            if (File.Exists(OFFICIALTABLE_FILENAME) && File.Exists(CUSTOMTABLE_FILENAME))
            {
                XmlDocument OfficialData = new XmlDocument();
                OfficialData.LoadXml(File.ReadAllText(OFFICIALTABLE_FILENAME));
                LoadOfficialNodes(OfficialData.SelectNodes("/WildMagics/Result"));

                XmlDocument CustomData = new XmlDocument();
                CustomData.LoadXml(File.ReadAllText(CUSTOMTABLE_FILENAME));
                LoadCustomNodes(CustomData.SelectNodes("/WildMagics/Result"));

            }
            else
            {
                throw new FileNotFoundException($"Missing data files: {OFFICIALTABLE_FILENAME} and/or {CUSTOMTABLE_FILENAME}");
            }
        }

        private static void LoadOfficialNodes(XmlNodeList nodes)
        {

            if (nodes == null) { return; }

            foreach (XmlNode node in nodes)
            {
                WildMagic wildMagic = new WildMagic(GetXmlAttributeAsInt(node, "WildMagicID"), GetXmlAttributeAsString(node, "WildMagicEffect"));
                _wildMagicTable.Add(wildMagic);
            }
        }
        private static void LoadCustomNodes(XmlNodeList nodes)
        {

            if (nodes == null) { return; }

            foreach (XmlNode node in nodes)
            {
                WildMagic wildMagic = new WildMagic(GetXmlAttributeAsInt(node, "WildMagicID"), GetXmlAttributeAsString(node, "WildMagicEffect"));
                _customWildMagicTable.Add(wildMagic);
            }
        }

        public static WildMagic GetResult(int id)
        {
            return _wildMagicTable.FirstOrDefault(i => i.WildMagicID == id);
        }

        public static WildMagic GetCustomResult(int id)
        {
            return _customWildMagicTable.FirstOrDefault(i => i.WildMagicID == id);
        }

        private static int GetXmlAttributeAsInt(XmlNode node, string attributeName)
        {
            return Convert.ToInt32(GetXmlAttribute(node, attributeName));
        }

        private static string GetXmlAttributeAsString(XmlNode node, string attributeName)
        {
            return GetXmlAttribute(node, attributeName);
        }

        private static string GetXmlAttribute(XmlNode node, string attributeName)
        {
            XmlAttribute attribute = node.Attributes?[attributeName];

            if (attribute == null)
            {
                throw new ArgumentException($"The attribute '{attributeName}' does not exist");
            }

            return attribute.Value;
        }
    }
}
