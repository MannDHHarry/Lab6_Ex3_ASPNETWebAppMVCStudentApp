//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ex3_ASPNETWebAppMVCStudentApp.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<decimal> Grade { get; set; }
    
        public virtual Courses Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
