namespace Nut.Core
{
    public class FileStore
    {
        private readonly string _fileStorePath;

        public FileStore(string fileStorePath)
        {
            if (string.IsNullOrWhiteSpace(fileStorePath))
            {
                throw new ArgumentException($"'{nameof(fileStorePath)}' cannot be null or whitespace.", nameof(fileStorePath));
            }

            _fileStorePath = fileStorePath;
        }

        public T ReadStore<T>()
            where T : class, new()
        {
            if (!File.Exists(_fileStorePath))
            {
                using var _ = File.Create(_fileStorePath);
            }

            var content = File.ReadAllText(_fileStorePath);

            return string.IsNullOrWhiteSpace(content)
                ? new T()
                : Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content)!;
        }

        public void WriteStore<T>(T entity)
            where T : class
        {
            var content = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
            File.WriteAllText(_fileStorePath, content);
        }
    }
}
