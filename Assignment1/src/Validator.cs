using System;
using System.IO;

namespace Application1
{
    public class Validator{
       public bool validate(string dir_path)
        {
            try{
                //Retrieving  the log files from dirrectory
                string[] filepaths = Directory.GetFiles(@dir_path, "*.log", SearchOption.AllDirectories);
                DataParser dp = new DataParser();

                int i;
                for (i = 0; i < filepaths.Length; i++)
                {
                    Console.WriteLine(filepaths[i]);
                    dp.DataCollect(filepaths[i]);                  //call to DataCollect()
                }
                return true;
            }
            catch(DirectoryNotFoundException)
            {
                Program.Help();
                Console.WriteLine("Directory does not exist");
                return false;
            }

            
        }
    }
}
