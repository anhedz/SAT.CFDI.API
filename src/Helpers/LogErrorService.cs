using System;
using System.IO;

namespace Jaeger.SAT.CFDI.Services.Helpers {
    internal class LogErrorService {
        static readonly string Path = @"C:\Jaeger\Jaeger.Log";

        internal static void Write(string Texto, string stackTrace) {
            Directory.CreateDirectory(Path);
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.AppendLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " : " + Texto);
            stringBuilder.AppendLine(stackTrace);
            using (StreamWriter streamWriter = new StreamWriter(System.IO.Path.Combine(Path, "API_Terceros_Service.log"), true))
                streamWriter.Write(stringBuilder.ToString());
        }
    }
}
