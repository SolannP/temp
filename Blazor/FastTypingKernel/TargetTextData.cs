using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_typing_Kernel
{
    public record TargetTextData
    {
        public string id_text { get; init; }
        public string title { get; init; }
        public List<Difficulty> difficulties { get; init; }
    }
    public record Difficulty
    {
        public string title { get; init; }
        public int level { get; init; }
        public string text { get; init; }
    }
}
