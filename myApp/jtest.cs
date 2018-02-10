using System.IO;

namespace myApp
{
    public class jtest
    {
        public jtest()
        {
            string line;
            using (StreamReader sr=new StreamReader("/home/paul/Documents/NordVPN/za9.nordvpn.com.udp1194.ovpn"))
            {
                line = sr.ReadLine();
            }
            System.Console.WriteLine(line);
        }
    }
}