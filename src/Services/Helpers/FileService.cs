using System;
using System.IO;

namespace Jaeger.SAT.API.Services.Helpers {
    internal static class FileService {
        /// <summary>
        /// archivo en uso
        /// </summary>
        /// <returns>verdadero si el archivo esta siendo utilizado por otro proceso</returns>
        public static bool IsFileinUse(string file) {
            return IsFileinUse(new FileInfo(file));
        }

        /// <summary>
        /// metodo estatico para comprobar si el archivo esta siendo utilizado por otro proceso
        /// </summary>
        /// <param name="file"></param>
        /// <returns>verdadero si el archivo esta siendo utilizado por otro proceso</returns>
        public static bool IsFileinUse(FileInfo file) {
            if (!file.Exists) {
                return false; 
            }

            FileStream fileStream = null;
            try {
                try {
                    fileStream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                } catch (IOException ex) {
                    Console.WriteLine(ex.Message);
                    return true;
                }
            } finally {
                fileStream?.Close();
            }
            return false;
        }
    }
}
