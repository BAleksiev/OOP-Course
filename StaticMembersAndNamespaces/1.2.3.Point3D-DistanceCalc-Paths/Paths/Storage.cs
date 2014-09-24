using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Point3D
{
    static class Storage
    {
        public static void SavePath(string file, Path3D path, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(file, append))
            {
                writer.WriteLine(path);
            }
        }

        public static string LoadPath(string file)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    result += line + "\n";
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}
