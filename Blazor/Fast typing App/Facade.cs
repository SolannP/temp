using Fast_typing_App.Database;
using Fast_typing_App.Database.File;
using FastTypingKernel;
using System.ComponentModel;
using System.Net;

namespace Fast_typing_App
{
    public class Facade
    {
        public TargetTextData data = new();
        public ITargetText dataConnecteur;
        private const string indexData = "ALL_COMMON_APPLICATION_DATA";

        public Facade(Uri path) => dataConnecteur = new FileConnecteur(path);

        public async Task<bool> Initialise()
        {
            var status = data.AddText(new()
            {
                id_text = "sein_demo_1",
                title = "Sein exercice",
                difficulties = new()
                {
                    new(){ title = "Sein exercice", level=0, text=@"sein konjugaison
ich bin
du bist
er oder sie oder es ist
wir sind
ihr seid
sie und sie sind"},
                    new(){ title = "Sein exercice", level=1, text=@"Sein konjugaison
Ich bin
Du bist
Er oder sie oder es ist
Wir sind
Ihr seid
Sie und sie sind"}
                },
                categories = new()
                {
                    new(){ text = "Verbs", id = "VERBS" }
                },
                tags = new()
                {
                    new(){ text= "Sein"}
                }
            });

            var status2 = data.AddText(new()
            {
                id_text = "haben_demo_1",
                title = "Haben exercice",
                difficulties = new()
                {
                    new(){ title =  "Haben exercice", level=0, text=@"haben konjugaison"},
                    new(){ title = "Haben exercice", level=1, text=@"Haben konjugaison"}
                },
                categories = new()
                {
                    new(){ text = "Verbs", id="VERBS"}
                },
                tags = new()
                {
                    new(){ text = "Haben"}
                }
            });

            return status2.succes && status.succes;

        

            /*
            const string idDemo1 = "file_demo_1";
            const string idDemo2 = "file_demo_2";
            //const stirng idDemo2
            const string titleDemo1 = "verbe sein";
            const string titleDemo2 = "verbe haben";

            var target1 = new TargetTextData()
            
            var target2 = new Fast_typing_Kernel.TargetTextData

            bool succes = await AddTargetTextData(target1);
            succes = succes && await AddTargetTextData(target2);

            return succes;
            */
        }

        public async Task<TargetTextData> GetCommonApplicationDataAsync()
        {
            return this.data;//await dataConnecteur.GetObjectAsync<TargetTextData>(indexData);
        }

        public async Task<TargetText> GetTargetTextAsync(string id)
        {
            return data.all_texts.First(element => element.id_text == id);
        }

        public async Task<bool> AddTargetTextData(TargetText data)
        {
            bool alreadyExist = await dataConnecteur.GetObjectAsync<TargetTextData>(data.id_text) != null ;
            if (alreadyExist) return false;
            bool succefullCreation = await dataConnecteur.CreateForceObjectAsync<TargetText>(data.id_text, data);
            if (succefullCreation)
            {
                var commonData = await GetCommonApplicationDataAsync();
                commonData.all_categories.UnionWith(data.categories);
                commonData.all_tags.UnionWith(data.tags);
                var result = await dataConnecteur.CreateForceObjectAsync<FastTypingKernel.TargetTextData>(indexData, commonData);
                return result;
            }
            else return false;
        }
    }
}