//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capstone.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveyResult
    {
        public int ID { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public string AspNetUsers_ID { get; set; }
        public string PhysicanWait { get; set; }
        public string PhysicianTime { get; set; }
        public bool TopicsDiscussed { get; set; }
        public bool FollowupScheduled { get; set; }
        public bool Recommend { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
    }
}
