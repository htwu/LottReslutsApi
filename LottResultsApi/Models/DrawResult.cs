using System;
using System.Collections.Generic;

namespace LottResultsApi.Models
{
    public class DrawResult
    {
        public int Id { get; set; }

        public int DrawResultDescId { get; set; }
        public virtual DrawResultDesc DrawResultDesc { get; set; }

        public DateTime CurrentDrawDate { get; set; }
        public int CurrentDrawNumber { get; set; }
        public DateTime NextDrawDate { get; set; }
        public int NextDrawNumber { get; set; }

        public string WinningNumbersName { get; set; }

        public string WinningNumbers { get; set; }
        public string SupplementariesName { get; set; }
        public string Supplementaries { get; set; }

        public string Memo { get; set; }

        public virtual ICollection<DrawResultDetail> DrawResultDetails { get; set; }
    }
}