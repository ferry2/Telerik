using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP2
{
    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            try
            {
                using (StreamWriter writePath = new StreamWriter(@"../../SavePath.txt"))
                {
                    foreach (var item in path.Points)
                    {
                        writePath.WriteLine(item);//(String.Format("X coordinate: {0} \nY coordinate: {1} \nZ coordinate: {2}", item.X, item.Y, item.Z));
                        writePath.Flush();
                    }
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found: {0}", ex.Message);
            }
            catch(PathTooLongException ex)
            {
                Console.WriteLine("Path too long: {0}", ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File not found: {0}", ex.Message);        
            }
            finally
            {
                Console.WriteLine("Path saved successfully!");
            }
        }

        public static void LoadPath()
        {
            using (StreamReader readPath = new StreamReader(@"../../SavePath.txt"))
            {
                int point = 0;
                string line = readPath.ReadLine();

                while(line != null)
                {
                    point++;
                    Console.WriteLine("Point {0}: {1}", point, line);
                    line = readPath.ReadLine();
                }
            }
        }
    }
}
