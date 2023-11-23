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
        private const string indexData = "ALL_COMMON_APPLICATION_DATA";

        public Facade() { }

        public async Task<bool> Initialise()
        {
            var status = data.Add(new()
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
                    new(){ text= "Sein"},
                    new() { text = "Basic"}
                }
            });

            var status2 = data.Add(new()
            {
                id_text = "haben_demo_1",
                title = "Haben exercice",
                difficulties = new()
                {
                    new(){ title =  "Haben exercice", level=0, text=@"haben konjugaison"},
                    new(){ title = "Haben exercice", level=1, text=@"Haben konjugaison
Ich habe einen neuen Schüler in der Klasse einen interessanten Brief für den Lehrer geschrieben
J'ai écrit une lettre intéressante pour le professeur à un nouvel élève dans la classe

Ich habe meiner Schwester einen schönen Blumenstrauß zum Geburtstag gekauft
J'ai acheté un beau bouquet de fleurs à ma sœur pour son anniversaire

Ich habe meinem Freund einen Rat für die Prüfung gegeben
J'ai donné un conseil à mon ami pour l'examen"}
                },
                categories = new()
                {
                    new(){ text = "Verbs", id="VERBS"}
                },
                tags = new()
                {
                    new(){ text = "Haben"},
                    new(){ text = "Ich"}
                }
            });

            var status3 = data.Add(new()
            {
                id_text = "haben_demo_present",
                title = "Haben full present declinaison",
                difficulties = new()
                {
                    //new(){title = "Haben full present declinaison",level=0,text=""},
                    new(){title="Haben full present declinaison",level=0,text=@"
Ich habe einen neuen Job gefunden
J'ai trouvé un nouveau travail
Du hast einen interessanten Film gesehen
Tu as regardé un film intéressant
Er hat ein neues Buch gekauft
Il a acheté un nouveau livre
Wir haben eine Party am Samstag
Nous avons une fête samedi
Ihr habt eure Hausaufgaben gemacht
Vous avez fait vos devoirs
Sie haben eine wichtige Entscheidung getroffen
Ils/Elles ont pris une décision importante // Vous avez pris une décision importante" }
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

            var status4 = data.Add(new()
            {
                id_text = "common_german_sentence_1",
                title = "Common german sentence I",
                difficulties = new()
                {
                    new(){title="Common german sentence I",level=0,text=@"test"},
                    new(){title="Common german sentence I",level=1,text=@"
Ich spreche ein wenig Deutsch / Je parle un peu Allemand
Können Sie mir helfen ? / Pouvez vous m'aider ?
Kannst du mir helfen ? / Pouvez vous m'aider ?
Wie lange bleibst du? / Combien de temps restez vous ?
Ich habe mich verlaufen / J'ai perdu mon chemin en marchand
Ich habe mich verfahren / J'ai perdu mon chemin en conduisant"},
                },
                categories = new()
                {
                    new(){text="Common sentence", id="COMMON"}
                },
                tags = new()
                {
                    new(){ text = "Common sentence"}
                }
            });


            return status4 && status3 && status2 && status;

        

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

        public async Task<bool> AddTargetTextData(TargetText input)
        {
            bool alreadyExist = data.all_texts.Contains(input);
            if (alreadyExist) return false;
            data.Add(input);
            return true;;
        }
    }
}