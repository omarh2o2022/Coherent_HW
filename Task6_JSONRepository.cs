using System.IO;
using Newtonsoft.Json;

namespace Task6
{
    public class JSONRepository<T> : IRepository<T>
    {
        public void Save(string filePath, T data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, jsonData);
        }

        public T Load(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
    }
}
