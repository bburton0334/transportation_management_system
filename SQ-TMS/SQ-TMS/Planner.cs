using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    class Planner
    {
        public int Planner_ID { get; set; }
        public string Planner_firstName { get; set; }
        public string Planner_lastName { get; set; }
        public string Planner_summaryReport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPlannerId"></param>
        /// <param name="newPlannerFirstName"></param>
        /// <param name="newPlannerLastName"></param>
        /// <param name="newPlannerSummaryReport"></param>
        public Planner (int newPlannerId, string newPlannerFirstName, string newPlannerLastName, string newPlannerSummaryReport)
        {
            Planner_ID = newPlannerId;
            Planner_firstName = newPlannerFirstName;
            Planner_lastName = newPlannerLastName;
            Planner_summaryReport = newPlannerSummaryReport;
        }
    }
}
