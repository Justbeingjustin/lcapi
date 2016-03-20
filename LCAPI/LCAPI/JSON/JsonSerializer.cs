namespace LCAPI.JSON
{
    public class JsonSerializer : ISerializer
    {
        public string Serialize<T>(T value)
        {
            return SimpleJson.SerializeObject(value);
        }
    }
}
