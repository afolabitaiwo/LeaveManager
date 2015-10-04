using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Portable.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Services.Contexts.Validatiion
{
     [Table("LeaveType")]
    public class LeaveTypeEntity : LeaveType
    {

        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int LeaveTypeId
        {
            get
            {
                return base.LeaveTypeId;
            }
            set
            {
                base.LeaveTypeId = value;
            }
        }

        
        public virtual EmployeeLeaveEntity EmployeeLeave { get; set; }
    }
}