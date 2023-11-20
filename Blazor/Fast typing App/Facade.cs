using Fast_typing_App.Database;
using Fast_typing_App.Database.File;
using Fast_typing_Kernel;
using FastTypingKernel;

namespace Fast_typing_App
{
    public class Facade
    {
        public ITargetText dataConnecteur;

        public Facade(Uri path) => dataConnecteur = new FileConnecteur(path);

        public async Task<CommonApplicationData> GetCommonApplicationDataAsync()
        {
            return await dataConnecteur.GetObjectAsync<CommonApplicationData>("ALL_COMMON_APPLICATION_DATA");
        }

        public async Task<TargetTextData> GetTargetTextDataAsync(string id)
        {
            return await dataConnecteur.GetObjectAsync<TargetTextData>(id);
        }
    }
}