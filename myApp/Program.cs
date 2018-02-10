using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace myApp
{
    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class Environment
    {
        //public string Server { get; set; }
        public string URL { get; set; }
        public int Timeout { get; set; }
        public Credentials FC { get; set; }
        public Credentials TC { get; set; }        
    }
    class Program
    {
        private static string[] lines = {"once", "upon", "a", "time"};
        static void Main(string[] args)
        {

            string json =
            @"{
                'Case12': {
                    'URL':'www.wtf.com',
                    'Timeout':'30000',
                    'FC': {'Username':'ittci','Password':'password99'},
                    'TC': {'Username':'itmdfc','Password':'password99'}
                },
                'Case15': {
                    'URL':'www.wtf.com',
                    'Timeout':'50000',
                    'FC': {'Username':'repplk','Password':'sw25EpaS'},
                    'TC': {'Username':'itmdfc','Password':'tinker'}
                }
            }";
            Dictionary<string, Environment> env = JsonConvert.DeserializeObject<Dictionary<string, Environment>>(json);
            string[] srv = {"Case12","Case15"};

            foreach (string s in srv)
            {
                Console.WriteLine("\n" + s + "\nURL:\t\t" + env[s].URL + "\nTimeout:\t" + env[s].Timeout);
                Console.WriteLine("FC: \t\tusername: " + env[s].TC.Username + "\n\t\tpassword: " +env[s].TC.Password );
                Console.WriteLine("TC: \t\tusername: " + env[s].FC.Username + "\n\t\tpassword: " +env[s].FC.Password );
            }

            string jsonout =  JsonConvert.SerializeObject(env, Formatting.Indented);
            Console.WriteLine(jsonout);
        }
    }
}
