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
    /// \brief The purpose of this class is to create a planner Object
    /// \details <b>Details</b>
    ///
    /// Planner which contains public attribute Planner_ID which holds Planner ID .
    /// This class contains a default consructor, along with a UpdatePlannerID function 
    /// This class contains accessors and mutators for the private attributes, 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public class Planner
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

        //===============================================================================================================
        /// \brief updatePlannerID function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Method that takes existingPlanner and NewPlanner IDs to validate and check if a previous version of them exist.
        /// \param existingPlanner - <b>Planner</b> - representation of the new planner's ID
        /// \param newPlannerID - <b>newPlannerID</b> - representation new planner's First Name
        /// \return As this is a <i>method</i> for the Planner class, bool is returned
        ///
        /// \see ~Planner()
        //===============================================================================================================
        public bool UpdatePlannerID(Planner existingPlanner, int newPlannerID)
        {
            bool isIDValid = false;
            const int MIN = 0;

            if (existingPlanner != null)
            {
                if (newPlannerID > MIN)
                {
                    existingPlanner.Planner_ID = newPlannerID;
                    isIDValid = true;
                }
            }

            return isIDValid;
        }
    }
}
