using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LottResultsApi.Models;

namespace LottResultsApi.DAL
{
    public class LottResultInitializer:DropCreateDatabaseIfModelChanges<LottResultContext>
    {
        protected override void Seed(LottResultContext context)
        {
            var lottResultDescs = new List<LottResultDesc>
            {
                new LottResultDesc
                {
                    ShowType = "row",
                    IsCombinations = true,
                    AvailableCol = 6,
                    ColName0 = "",
                    ColName1 = "Division Prize",
                    ColName2 = "Division Prize Pool",
                    ColName3 = "Winners",
                    ColName4 = "Win",
                    ColName5 = "+ Supp",
                },
                new LottResultDesc
                {
                    ShowType = "row",
                    IsCombinations = true,
                    AvailableCol = 6,
                    ColName0 = "",
                    ColName1 = "Division Prize",
                    ColName2 = "Division Prize Pool",
                    ColName3 = "Winners",
                    ColName4 = "Win",
                    ColName5 = "+ Pb",
                },
            };
            lottResultDescs.ForEach(s => context.LottResultDescs.Add(s));
            context.SaveChanges();

            var lottResults = new List<LottResult>
            {
                 new LottResult
                {
                    Name = "Saturday Gold Lotto",
                    LottResultDescId = lottResultDescs[0].Id,
                    CurrentDrawDate = new DateTime(2016,9,10),
                    CurrentDrawNumber = 3667,
                    NextDrawDate = new DateTime(2016,9,17),
                    NextDrawNumber = 3669,
                    WinningNumbersName ="Winning Numbers", 
                    WinningNumbers = "31,25,9,28,17,10",
                    SupplementariesName = "Supplementaries",
                    Supplementaries = "25,42",
                    Memo = "",
                },
                new LottResult
                {
                    Name = "Powerball",
                    LottResultDescId = lottResultDescs[1].Id,
                    CurrentDrawDate = new DateTime(2016,9,18),
                    CurrentDrawNumber = 1060,
                    NextDrawDate = new DateTime(2016,9,15),
                    NextDrawNumber = 1061,
                    WinningNumbersName ="Winning Numbers", 
                    WinningNumbers = "31,25,9,28,17,10",
                    SupplementariesName = "Powerball",
                    Supplementaries = "2",
                    Memo = "nothing",
                }
            };
            lottResults.ForEach(s => context.LottResults.Add(s));
            context.SaveChanges();

            var lottResultDetails = new List<LottResultDetail>()
            {
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 1",
                    ColValue1 = "$200,493.60",
                    ColValue2 = "$4,210,365.60",
                    ColValue3 = "21 winners",
                    ColValue4 = "6",
                    ColValue5 = "",
                },
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 2",
                    ColValue1 = "$300,493.60",
                    ColValue2 = "$3,210,365.60",
                    ColValue3 = "23 winners",
                    ColValue4 = "5",
                    ColValue5 = "+1 or 2",
                },
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 3",
                    ColValue1 = "$400,493.60",
                    ColValue2 = "$1,210,365.60",
                    ColValue3 = "22 winners",
                    ColValue4 = "5",
                    ColValue5 = "",
                },
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 4",
                    ColValue1 = "$200,493.60",
                    ColValue2 = "$4,210,365.60",
                    ColValue3 = "21 winners",
                    ColValue4 = "6",
                    ColValue5 = "",
                },
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 4",
                    ColValue1 = "$200,493.60",
                    ColValue2 = "$4,210,365.60",
                    ColValue3 = "21 winners",
                    ColValue4 = "6",
                    ColValue5 = "",
                },
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 5",
                    ColValue1 = "$200,493.60",
                    ColValue2 = "$4,210,365.60",
                    ColValue3 = "21 winners",
                    ColValue4 = "6",
                    ColValue5 = "",
                },
                new LottResultDetail
                {
                    LottResultId = lottResults[0].Id,
                    ColValue0 = "Division 6",
                    ColValue1 = "$200,493.60",
                    ColValue2 = "$4,210,365.60",
                    ColValue3 = "21 winners",
                    ColValue4 = "6",
                    ColValue5 = "",
                },
            };
            lottResultDetails.ForEach(lrd => context.LottResultDetails.Add(lrd));
            context.SaveChanges();
        }
    }
}