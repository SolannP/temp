namespace FastTypingKernel
{
    public class TargetTextData
    {
        public List<TargetText> all_texts { get; init; } = new();
        public HashSet<Tag> all_tags { get; init; } = new();
        public HashSet<Category> all_categories { get; init; } = new();
        public (bool succes,string? error) AddText(TargetText text)
        {
            if (all_texts.Any(element => element.id_text == text.id_text)) return (succes: false, error:  "already existing file");
            all_texts.Add(text);
            all_tags.UnionWith(text.tags);
            all_categories.UnionWith(text.categories);
            return (succes:true,error:null);
        }
    }

    public record TargetText
    {
        public string id_text { get; init; }
        public string title { get; init; }
        public List<Difficulty> difficulties { get; init; }
        public HashSet<Tag> tags { get; init; } = new();
        public HashSet<Category> categories { get; init; } = new();
    }

    public record Tag
    {
        public string text { get; init; }
    }

    public record Category
    {
        public string id { get; init; } 
        public string text { get; init; }
    }

    public record Difficulty
    {
        public string title { get; init; }
        public int level { get; init; }
        public string text { get; init; }
    }
}