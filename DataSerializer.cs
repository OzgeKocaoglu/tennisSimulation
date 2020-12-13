using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace tennisSimulation
{
    class Tournament
    {
        public int id { get; set; }
        public string surface { get; set; }
        public string type { get; set; }
    }

    class Model
    {
        public List<Tournament> tournaments { get; set; }
        public List<Player> players { get; set; }
    }
    class DataSerializer
    {
        public void LoadJson(string _path)
        {
          
           

            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                //Console.WriteLine(json);
                Model dataModel = JsonConvert.DeserializeObject<Model>(json);
                for(int i = 0; i <dataModel.players.Count; i++)
                {
                    Console.WriteLine("PlayerID: " + dataModel.players[i].id + "\nPlayer Hand: " + dataModel.players[i].hand + "\nPlayer Experience: " + dataModel.players[i].experience + "\nPlayer Skills clay: " + dataModel.players[i].skills.clay);
                    Console.WriteLine("---------------------------");
                }
               

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
