using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Jaeger.SAT.API.Services.Helpers {
    public class XmlSerializerService {

        public static string SerializeObject<T>(T obj) {
            UTF8Encoding utf8WithoutBom = new UTF8Encoding(false);
            string empty = null;
            try {
                string str = null;
                MemoryStream memoryStream = new MemoryStream();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, utf8WithoutBom) {
                    Formatting = Formatting.Indented,
                    Indentation = 4
                };
                xmlSerializer.Serialize(xmlTextWriter, obj);
                memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
                str = utf8WithoutBom.GetString(memoryStream.ToArray());
                empty = str;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                empty = string.Empty;
            }
            return empty;
        }

        public static T DeserializeObject<T>(string xml) {
            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                MemoryStream memoryStream = new MemoryStream(StringToUtf8ByteArray(xml));
                return (T)xmlSerializer.Deserialize(memoryStream);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return default;
            }

        }

        public static T XmlDeserializarStringXml<T>(string sXml) {
            T t;
            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                byte[] bytes = Encoding.UTF8.GetBytes(sXml);
                XmlTextReader xmlTextReader = new XmlTextReader(new MemoryStream(bytes));
                T t1 = (T)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
                t = t1;
            } catch (Exception ex) {
                Console.WriteLine(string.Concat("HelperXmlSerializer: XmlDeserializarStringXml: ", ex.Message));
                t = default;
            }
            return t;
        }

        public static byte[] StringToUtf8ByteArray(string pXmlString) {
            return new UTF8Encoding(false).GetBytes(pXmlString);
        }
    }
}
