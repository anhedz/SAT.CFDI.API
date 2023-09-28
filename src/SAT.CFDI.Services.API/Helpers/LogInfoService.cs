using System;
using System.IO;

namespace Jaeger.SAT.CFDI.Services.Helpers {
    internal class LogInfoService {
        static readonly string path = @"C:\Jaeger\Jaeger.Log";

        internal static void Write(string Texto, string stackTrace) {
            Directory.CreateDirectory(path);
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.AppendLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " : " + Texto);
            stringBuilder.AppendLine(stackTrace);
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, "API_Terceros_Service_info.log"), true))
                streamWriter.Write(stringBuilder.ToString());
        }
    }
}
