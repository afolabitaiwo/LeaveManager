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
    
    public partial class Department : BaseEntity
    {

    
        public virtual int DepartmentId { get; set; }
        public virtual string Name { get; set; }
        public virtual Guid MangerEmployeeId { get; set; }
    
        
    }
}
