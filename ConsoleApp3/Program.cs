
using System.Threading;
using System;
using System.IO;
using System.Text.Json;

namespace ConsoleApp3
{
    
    class Program
    {
       class ForJSON
        {
            public int i { get; set; } 
            public int j { get; set; }

            public string str { get; set; }
            public void Lol()
            {
                i = 0;
            }
        }

        static void Main(string[] args)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            ForJSON forJSON = new ForJSON();
            string need = JsonSerializer.Serialize(forJSON, options);
            using(StreamWriter writer = new StreamWriter("test.json", false))
            {
                writer.Write(need);
            }

        }

    }
    

    
   

}