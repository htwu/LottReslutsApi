using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LottResultsApi.Models
{
    public class DrawResultDetail
    {
        public int Id { get; set; }

        public int DrawResultId { get; set; }
        public virtual DrawResultDesc DrawResult { get; set; }

        public string ColValue0 { get; set; }
        public string ColValue1 { get; set; }
        public string ColValue2 { get; set; }
        public string ColValue3 { get; set; }
        public string ColValue4 { get; set; }
        public string ColValue5 { get; set; }
        public string ColValue6 { get; set; }
        public string ColValue7 { get; set; }
        public string ColValue8 { get; set; }
        public string ColValue9 { get; set; }

    }
}