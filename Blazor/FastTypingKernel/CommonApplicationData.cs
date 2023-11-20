namespace FastTypingKernel
{
    public record CommonApplicationData
    {
        public List<CommonText> texts { get; init; }
    }

    public record CommonText
    {
        public string id_text { get; init; }
        public string title { get; init; }
    }
}