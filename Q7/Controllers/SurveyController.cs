using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Q7.Models;


namespace Q7.Controllers
{
    public class SurveyController : ApiController
    {
        private static int cPageSize = 10;
        private SurveyItem[] _GetPage(int from) {
            return DataCache.Surveys.Skip(from).Take(cPageSize).ToArray();
        }
        // GET api/survey?from=x
        public SurveyItem[] Get(int from) {
            return _GetPage(from);
        }
        // GET api/survey
        public SurveyItem[] Get() {
            return Get(0);
        }
    }
}
