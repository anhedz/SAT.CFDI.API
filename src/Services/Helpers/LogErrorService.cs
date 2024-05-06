using System;
using System.IO;

namespace Jaeger.SAT.API.Services.Helpers {
    /// <summary>
    /// Clase para looger de errores
    /// </summary>
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

        internal static void Log(string title, string stackTrace) {
            // sino existe el directorio lo creamos
            if (!Directory.Exists(Path)) {
                Directory.CreateDirectory(Path);
            }

            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.AppendLine("-------------------------------------------------->");
            stringBuilder.AppendLine($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}: {title}");
            stringBuilder.AppendLine(stackTrace);
            using (StreamWriter streamWriter = new StreamWriter(System.IO.Path.Combine(Path, "API_Terceros_Service.log"), true))
                streamWriter.Write(stringBuilder.ToString());
        }
    }
}
