using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;


namespace Tennis_Simulation
{
    class DataSerializer
    {

        public DataModel LoadJson(string _path)
        {
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                //Console.WriteLine(json);
                DataModel dataModel = JsonConvert.DeserializeObject<DataModel>(json);
                return dataModel;
            }
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
