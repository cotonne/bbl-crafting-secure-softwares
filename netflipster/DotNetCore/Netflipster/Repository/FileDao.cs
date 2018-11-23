using System;
using System.IO;

namespace Netflipster.Repository
{
    public class FileDao
    {
        public static String Read(String id)
        {
            try
            {
                var fileLines = File.ReadAllLines("movies/" + id);
                var fileContent = string.Concat(fileLines);
                return fileContent;
            }
            catch (IOException e)
            {
                return "No description available";
            }
        }
    }
}
