using Core.Concrates.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrates.DTOs.Game
{

    public class GameListDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string FeatureMedia { get; set; }
        public string Logo { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public IEnumerable<string> PlatformIcons { get; set; }
        public Ratings Rating { get; set; }
        public Status Status { get; set; }
    }
}
