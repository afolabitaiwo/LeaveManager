//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business.Portable.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class Employee : BaseEntity
    {
            
        public virtual Guid EmployeeId { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string UserId { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeTypeId { get; set; }
           
    }
}
