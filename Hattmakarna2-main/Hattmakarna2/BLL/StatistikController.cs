using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace BLL
{
    public class StatistikController<T>
    {
        public static void SkrivUtStatistik(List<T> list, string filnamn)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter xmlWriter = XmlWriter.Create(@".\" + filnamn + ".xml", settings))
            {
                xmlSerializer.Serialize(xmlWriter, list);
            }
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@".\" + filnamn + ".xml")
            {
                UseShellExecute = true,
            };
            p.Start();

        }
    }
}
