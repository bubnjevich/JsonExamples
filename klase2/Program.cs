using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace klase2
{
    class Program
    {
        static void ReadJson(List<Automobile> res)
        {
            double sum = 0;
            int i = 0;
            foreach (Automobile automobile in res)
            {
                Console.Write(automobile.model);
                Console.WriteLine(", Starost "+ automobile.year);

                if (2022 - automobile.year <= 5)
                {
                    Console.WriteLine(automobile.model);
                }
                i++;
                sum += automobile.year;

            }

            double final = sum / i;
            Console.WriteLine("Prosecna starost: " + final);
        }

        static void EngineSerialize(List<Automobile> res)
        {

            List<Engine> engines = new List<Engine>();
            foreach (Automobile automobile in res)
            {
                if (!engines.Contains(automobile.engine))
                    engines.Add(automobile.engine);
            }
            
            using (StreamWriter file = File.CreateText("../../../engines.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, engines);
            }
            
        }
        
        
        static void Main(string[] args)
        {
            string fileName = "../../../cars.json";
            JsonSerializerSettings json = new JsonSerializerSettings
                {PreserveReferencesHandling = PreserveReferencesHandling.Objects};
            List<Automobile> res = JsonConvert.DeserializeObject<List<Automobile>>(File.ReadAllText(fileName), json);
            EngineSerialize(res);
          
        }
        
    }
}