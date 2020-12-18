using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application1
{
    public class Writer
    {
        string path = "";
        int count=1;
        
        public Writer(){

            
            string createText = "No,Date,Timestamp,Level,Message" + Environment.NewLine;
            PathGetter(createText);
            
            
        }
        public void writeToCSV(string level, string date, string timestamp, string message)
        {
            
            string text=count+"                   "+date+"                    "+timestamp+"                    "+level+"            "+message+"\t"+"\n";
            File.AppendAllText(path, text);
            count++;

        }

        public string PathGetter(string createText){
            Console.WriteLine("Enter Path to csv file : ");
            path=Console.ReadLine();  
            FileInfo fi = new FileInfo(path);  
  
            // Get File Name  
            string FileName = fi.Name;  
            
            string extn = fi.Extension;
            Console.WriteLine("File Extension: {0}", extn);
            if(extn==".csv"){
                File.WriteAllText(path,createText);
                return extn;
            }
            else{
                return extn;
            }  
            

        }
    }
}