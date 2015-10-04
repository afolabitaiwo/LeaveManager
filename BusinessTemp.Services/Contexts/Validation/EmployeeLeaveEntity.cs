using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Portable.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Services.Contexts.Validatiion
{
     [Table("EmployeeLeave")]
    public class EmployeeLeaveEntity : EmployeeLeave
    {
        public EmployeeLeaveEntity()
        {
            this.LeaveTypes = new HashSet<LeaveTypeEntity>();
        }

        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int EmployeeLeaveId
        {
            get
            {
                return base.EmployeeLeaveId;
            }
            set
            {
                base.EmployeeLeaveId = value;
            }
        }

        [MaxLength(250)]
        public override string Reason { get; set; }


        public virtual ICollection<LeaveTypeEntity> LeaveTypes { get; set; }

    }
}