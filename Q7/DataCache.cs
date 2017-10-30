using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Q7.Models;
using System.Net;
using Newtonsoft.Json;

namespace Q7 {
    public class DataCache {
        private static readonly string cDataUrl = @"https://resonatetest.azurewebsites.net/data";
        public static SurveyItem[] Surveys { get; private set; }
        static DataCache() {
            using (WebClient wc = new WebClient()) {
                Surveys = JsonConvert.DeserializeObject<SurveyItem[]>(wc.DownloadString(cDataUrl));
            }
        }
    }
}