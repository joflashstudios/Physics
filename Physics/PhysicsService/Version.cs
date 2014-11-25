using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;

namespace PhysicsService
{
    public class Version
    {
        public string VersionText { get; set; }
        public double VersionNumber
        {
            get
            {
                return double.Parse("0." + VersionText.Replace(".", ""));
            }
        }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string URL { get; set; }

        public static Version[] GetVersions()
        {
            string xml = File.ReadAllText("versions.xml");
            return DeserializeVersions(xml);
        }

        public static Version GetLatest()
        {            
            return GetVersions().OrderBy(n => n.VersionNumber).First();
        }

        public static void SaveVersions(Version[] versions)
        {
            string xml = SerializeVersions(versions);
            File.WriteAllText("versions.xml", xml);
        }

        private static Version[] DeserializeVersions(string xml)
        {
            using (StringReader stream = new StringReader(xml))
            {
                return (Version[])Serializer.Deserialize(stream);
            }
        }

        private static string SerializeVersions(Version[] versions)
        {
            using (StringWriter stream = new StringWriter())
            {
                Serializer.Serialize(stream, versions);
                return stream.ToString();
            }
        }

        private static XmlSerializer Serializer = new XmlSerializer(typeof(Version[]));
    }
}