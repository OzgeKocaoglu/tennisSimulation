using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Tennis_Simulation
{
    class DataSerializer
    {
        public DataModel DeseriliazeJSON()
        {
            DataModel dataModel;
            try
            {
                if (File.Exists(GlobalVariables.INPUT_PATH))
                {
                    using (StreamReader r = new StreamReader(GlobalVariables.INPUT_PATH))
                    {
                        string json = r.ReadToEnd();
                        dataModel = JsonConvert.DeserializeObject<DataModel>(json);
                        return dataModel;
                    }
                }
                else
                {
                    Console.WriteLine("We could not found the input file.\n To solve this:\n 1 - Go to GlobalVariables.cs file\n 2 - Copy your json file path inside of INPUT_PATH string.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong with JSON: " + ex.Message.ToString());
            }

            return null;
        }
        public void SeriliazeJSON(List<Order> orders)
        {
            using (StreamWriter file = File.CreateText(GlobalVariables.OUTPUT_PATH))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, orders);
            }
        }
    }
}
