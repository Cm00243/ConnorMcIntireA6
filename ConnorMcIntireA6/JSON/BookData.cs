using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConnorMcIntireA6.JSON
{
    public class BookData
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Author")]
        public string Author { get; set; }
        [JsonPropertyName("Page Length")]
        public int Length { get; set; }
        [JsonPropertyName("Genre")]
        public string Genre { get; set; }
        [JsonPropertyName("Year Published")]
        public int Year { get; set; }

        [JsonPropertyName("MSRP")]
        public double Msrp { get; set; }
    }
}
