using System.Collections.Generic;
using System.Collections.Immutable;

namespace FastTypingKernel
{
    public class TargetTextData
    {
        public HashSet<TargetText> data { get; set; } = new();
        public bool Add(TargetText value) => data.Add(value);
        public ImmutableHashSet<TargetText> all_texts { get => data.ToImmutableHashSet(); }
        public ImmutableHashSet<Tag> all_tags  => all_texts.SelectMany(el => el.tags).Distinct().ToImmutableHashSet();
        public ImmutableHashSet<Category> all_categories => all_texts.SelectMany(el => el.categories).Distinct().ToImmutableHashSet();
    }

    public class TargetText : IEquatable<TargetText>
    {
        public string id_text { get; init; }
        public string title { get; init; }
        public List<Difficulty> difficulties { get; init; }
        public HashSet<Tag> tags { get; init; } = new();
        public HashSet<Category> categories { get; init; } = new();

        public override bool Equals(object? obj) => Equals(obj as TargetText);
        public bool Equals(TargetText? other) => this.id_text.Equals(other?.id_text, StringComparison.OrdinalIgnoreCase);
        public override int GetHashCode() => HashCode.Combine(id_text);

    }

    public class Tag : IEquatable<Tag>
    {
        public string text { get; init; }

        public override bool Equals(object? obj) => Equals(obj as Tag);
        public bool Equals(Tag? other) => text.Equals(other?.text,StringComparison.OrdinalIgnoreCase);
        public override int GetHashCode() => HashCode.Combine(text);
    }

    public class Category : IEquatable<Category> 
    {
        public string id { get; init; } 
        public string text { get; init; }

        public override bool Equals(object? obj) => Equals(obj as Category);
        public bool Equals(Category? other) => this.id.Equals(other?.id, StringComparison.OrdinalIgnoreCase);
        public override int GetHashCode() =>  HashCode.Combine(id);
    }

    public class Difficulty
    {
        public string title { get; init; }
        public int level { get; init; }
        public string text { get; init; }
    }
}