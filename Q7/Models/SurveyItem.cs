using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q7.Models {
    public class SurveyItem {
        public SurveyItem(int id, string user, int score, string verbatim) {
            Id = id;
            User = user;
            Score = score;
            Verbatim = verbatim;
        }
        public int Id { get; private set; }
        public string User { get; private set; }
        public int Score { get; private set; }
        public string Verbatim { get; private set; }
    }
}