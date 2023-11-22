using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fast_typing_App.Database.File
{
    public class FileConnecteur : ITargetText
    {
        private Uri path;
        public FileConnecteur(Uri LocationPath) => path = LocationPath;
        public async Task<T> GetObjectAsync<T>(string id)
        {
            string location = Path.Combine(path.LocalPath, string.Concat(id,".json"));
            using FileStream stream = new(location, FileMode.Open);
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }

        public async Task<bool> CreateForceObjectAsync<T>(string id,T value)
        {
            string location = Path.Combine(path.LocalPath, string.Concat(id, ".json"));
            using FileStream stream = new FileStream(location, FileMode.Create);
             return await Task.Run(async () => {
                    var result = JsonSerializer.SerializeAsync<T>(stream, value);
                    await result;
                    if (result.IsFaulted) throw result.Exception!;
                    return result.IsCompletedSuccessfully; 
                });

        }
    }
}
