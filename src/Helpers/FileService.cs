using System;
using System.IO;

namespace Jaeger.SAT.CFDI.Services.Helpers {
    internal static class FileService {
        public static bool IsFileinUse(string file) {
            return IsFileinUse(new FileInfo(file));
        }

        public static bool IsFileinUse(FileInfo file) {
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
