using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static string _path= @"C:\Users\Eagha\Desktop\Files\";
        static void Main(string[] args)
        {
            User user1 = new User
            {
                Name = "Ibrahim",
                Surname = "Abbasov",
                Age = 40
            };

            #region BinaryFormatter
            //SerializeDat(user1);

            //User desUser = DeserializeDat();

            //Console.WriteLine(desUser.Name + " " + desUser.Surname);
            #endregion

            #region JsonFormatter
            //SerializeJson(user1);

            //User user = DeserializeJson();

            //Console.WriteLine(user.Name+" "+user.Surname);
            #endregion

            #region Xml
            //SerializeXml(user1);

            //User user = DeserializeXml();

            //Console.WriteLine(user.Name+" "+user.Surname);


            //FileStream fileStream = new FileStream(_path + "currency.xml", FileMode.Open);

            WebClient webClient = new WebClient();
            string date = DateTime.UtcNow.AddHours(4).ToString("dd.MM.yyyy");
            var stream = webClient.OpenRead("https://www.cbar.az/currencies/"+date+".xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));

            ValCurs valCurs = (ValCurs)xmlSerializer.Deserialize(stream);

            foreach (var valType in valCurs.ValType)
            {   
                foreach (var val in valType.Valute)
                {
                    Console.WriteLine(val.Name + " - "+val.Value);
                }
            }

            #endregion
        }


        static void SerializeDat(User user)
        {
            using (FileStream fileStream = new FileStream(_path + "user1.dat", FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, user);
            }
        }

        static User DeserializeDat()
        {
            object data;
            using(FileStream fileStream = new FileStream(_path + "user1.dat", FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                data = binaryFormatter.Deserialize(fileStream);
            }
            return (User)data;
        }

        static void SerializeJson(User user)
        {
            var objectStr = JsonConvert.SerializeObject(user);
            using(FileStream fileStream = new FileStream(_path + "user2.json", FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(objectStr);
                }
            }
        }

        static User DeserializeJson()
        {
            string userObjStr;
            using(FileStream fileStream = new FileStream(_path + "user2.json", FileMode.Open))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                userObjStr = streamReader.ReadToEnd();
            }

            var user = JsonConvert.DeserializeObject<User>(userObjStr);
            return user;
        }

        static void SerializeXml(User user)
        {
            using(FileStream stream = new FileStream(_path + "user3.xml", FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
                xmlSerializer.Serialize(stream, user);
            }
        }

        static User DeserializeXml()
        {
            object userObj;
            using (FileStream stream = new FileStream(_path + "user3.xml", FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
                userObj = xmlSerializer.Deserialize(stream);
            }

            return (User)userObj;
        }


    }
}
