using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Planner
    ///
    /// \brief The purpose of this class is to realistically model the attributes of a circle
    /// \details <b>Details</b>
    ///
    /// Circle class which contains private attribute radius which holds the radius of the circle.
    /// This class contains a default consructor and another constructor which takes a radius as a
    /// parameter. This class contains accessors and mutators for the private attributes, along with
    /// virtual function which do calculations for the circles area, perimeter, and diameter.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    class Planner
    {
        public int Planner_ID { get; set; }
        public string Planner_firstName { get; set; }
        public string Planner_lastName { get; set; }
        public string Planner_summaryReport { get; set; }

        //===============================================================================================================
        /// \brief To instantiate a new Planner object - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Constructor that creates a new Planner object given the proper parameters.
        /// \param newPlannerID - <b>int</b> - representation of the radius of the circle
        /// \param newPlannerFirstName - <b>string</b> - representation of the radius of the circle
        /// \param newPlannerLastName - <b>string</b> - representation of the radius of the circle
        /// \param newPlannerSummaryReport - <b>string</b> - representation of the radius of the circle
        ///
        /// \return As this is a <i>constructor</i> for the Planner class, nothing is returned
        ///
        /// \see ~Planner()
        //===============================================================================================================
        public Planner (int newPlannerId, string newPlannerFirstName, string newPlannerLastName, string newPlannerSummaryReport)
        {
            Planner_ID = newPlannerId;
            Planner_firstName = newPlannerFirstName;
            Planner_lastName = newPlannerLastName;
            Planner_summaryReport = newPlannerSummaryReport;
        }
    }
}
