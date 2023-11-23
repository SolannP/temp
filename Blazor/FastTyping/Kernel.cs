using FastTypingKernel;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Fast_typing_Test
{
    public class Kernel
    {
        public ITestOutputHelper console;
        public Kernel(ITestOutputHelper helper) => console = helper;

        [Fact]
        public void Basic_Usage()
        {
            TargetTextData data = new();
            TargetText firstText;
            var data1 = new TargetText()
            {
                id_text = "A",
                title = "Test A",
                categories = new() {
                    new() { id = "000", text = "LATIN ALPHABET" }
                },
                tags = new() {
                    new() { text = "Letter" },
                    new() { text = "Latin" },
                    new() { text = "A" }
                }
            };
            var data2 = new TargetText()
            {
                id_text = "B",
                title = "Test B",
                categories = new() {
                    new() { id = "000", text = "LATIN ALPHABET" },
                    new() { id = "001", text = "2nd alphabe letter" },
                },
                tags = new() {
                    new() { text = "Letter" },
                    new() { text = "Latin" },
                    new() { text = "B" }
                }
            };

            data.Add(data1);

            firstText = data.all_texts.First();
            Assert.Equal(3, firstText.tags.Count);

            data.Add(data2);

            firstText = data.all_texts.First();
            Assert.Equal(3, firstText.tags.Count);

            firstText = data.all_texts.First();
            Assert.Equal(3, firstText.tags.Count);

            Assert.Equal(2,data.all_texts.Count);
            Assert.Equal(2,data.all_categories.Count);
            Assert.Equal(4,data.all_tags.Count);

            var result = data.Add(data1);
            Assert.False(result);

            firstText = data.all_texts.First();
            Assert.Equal(3, firstText.tags.Count);

            
            data.Add(data2);

            Assert.Equal(2, data.all_texts.Count);
            Assert.Equal(2, data.all_categories.Count);
            Assert.Equal(4, data.all_tags.Count);

            firstText = data.all_texts.First();
            Assert.Equal(3, firstText.tags.Count);




        }
    }
}
