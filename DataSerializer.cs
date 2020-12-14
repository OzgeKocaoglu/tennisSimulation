using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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


        #region JSON functions

        public void SerializeJSON(object data, string filepath)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filepath)) File.Delete(filepath);
            StreamWriter streamWriter = new StreamWriter(filepath);
            JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
            jsonSerializer.Serialize(jsonWriter, data);
            jsonWriter.Close();
            streamWriter.Close();
        }

        private object DeseriliazeJSON(Type dataType, string filePath)
        {
            JObject obj = null;
            try
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                if (File.Exists(filePath))
                {
                    StreamReader streamReader = new StreamReader(filePath);
                    JsonReader jsonReader = new JsonTextReader(streamReader);
                    obj = jsonSerializer.Deserialize(jsonReader) as JObject;
                    jsonReader.Close();
                    streamReader.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong with JSON: " + ex.Message.ToString());
            }
            return obj.ToObject(dataType);

        }
        #endregion
    }
}
