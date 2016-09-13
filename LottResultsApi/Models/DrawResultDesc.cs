using System;
using System.Collections.Generic;

namespace LottResultsApi.Models
{
    public class DrawResultDesc
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AvailableCol { get; set; }
        public string ShowType { get; set; }

        public string ColName0 { get; set; }
        public string ColName1 { get; set; }
        public string ColName2 { get; set; }
        public string ColName3 { get; set; }
        public string ColName4 { get; set; }
        public string ColName5 { get; set; }
        public string ColName6 { get; set; }
        public string ColName7 { get; set; }
        public string ColName8 { get; set; }
        public string ColName9 { get; set; }

        public ICollection<DrawResult> DrawResults { get; set; }
    }
}