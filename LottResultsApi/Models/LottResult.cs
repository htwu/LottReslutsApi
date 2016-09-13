using System;
using System.Collections.Generic;

namespace LottResultsApi.Models
{
    public class LottResult
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LottResultDescId { get; set; }
        public virtual LottResultDesc LottResultDesc { get; set; }

        public DateTime CurrentDrawDate { get; set; }
        public int CurrentDrawNumber { get; set; }
        public DateTime NextDrawDate { get; set; }
        public int NextDrawNumber { get; set; }

        public string WinningNumbersName { get; set; }

        public string WinningNumbers { get; set; }
        public string SupplementariesName { get; set; }
        public string Supplementaries { get; set; }

        public string Memo { get; set; }

        public virtual ICollection<LottResultDetail> LottResultDetails { get; set; }
    }
}
