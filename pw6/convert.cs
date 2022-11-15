using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pw6
{
    public class convert
    {
        string huy = Console.ReadLine();
        public static List<Class1> class1s = new List<Class1>();
        
        public static  string json;
        public static void InJson()
        {
            
            json = JsonConvert.SerializeObject(class1s);
            File.WriteAllText("C:\\Users\\79663\\Desktop\\Result.json", json);
        }
        public static List<Class1> FromJson()
        {
            var putit = File.ReadAllText("C:\\Users\\79663\\Desktop\\Result.json");
            
                List<Class1> lis = JsonConvert.DeserializeObject<List<Class1>>(putit);
                return lis;   
        }

        public static void InXML()
        {
            var x = new XmlSerializer(typeof(List<Class1>));
            using (var fl = new FileStream(@"C:\Users\79663\Desktop\Result.xml", FileMode.OpenOrCreate))
            {
                x.Serialize(fl, class1s);
            }
        }
        public static List<Class1> FromXML()
        {
            var x = new XmlSerializer(typeof(List<Class1>));
            using (var fl = new FileStream(@"C:\Users\79663\Desktop\Result.xml", FileMode.OpenOrCreate))
            {
                
            return (List<Class1>)x.Deserialize(fl);
            }
        }
        public static void InTXT(List<Class1> cllist)
        {
            foreach (var item in cllist)
            {
                if (cllist.IndexOf(item)==0)
                {
                File.WriteAllText("C:\\Users\\79663\\Desktop\\Result.txt",
                    $"{item.option}\n{item.dlina}\n{item.dlina2}");
                }
                else
                {
                    File.AppendAllText("C:\\Users\\79663\\Desktop\\Result.txt",
                   $"\n{item.option}\n{item.dlina}\n{item.dlina2}");
                }
            }
        }
        public static List<Class1> FromTXT()
        {
            List<Class1> cllist2 = new List<Class1>();
            if (File.Exists(@"C:\Users\79663\Desktop\Result.txt"))
            {
                string[] str = File.ReadAllLines(@"C:\Users\79663\Desktop\Result.txt");
                cllist2.Add(new Class1(str[0], int.Parse(str[1]), int.Parse(str[2])));
                cllist2.Add(new Class1(str[3], int.Parse(str[4]), int.Parse(str[5])));
                cllist2.Add(new Class1(str[6], int.Parse(str[7]), int.Parse(str[8])));
                
            }
                return cllist2;
        }
        
    }
}
