using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Portable.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Services.Contexts.Validatiion
{
     [Table("Department")]
    public class DepartmentEntity : Department
    {
        public DepartmentEntity()
        {
            this.Employees = new HashSet<EmployeeEntity>();
        }
        
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

       
        [MaxLength(100)]
        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = value;
            }
        }

        public override int DepartmentId
        {
            get
            {
                return base.DepartmentId;
            }
            set
            {
                base.DepartmentId = value;
            }
        }

        [Required]
        [Display(Name = "Manager")]
        public override Guid MangerEmployeeId
        {
            get
            {
                return base.MangerEmployeeId;
            }
            set
            {
                base.MangerEmployeeId = value;
            }
        }

        public virtual ICollection<EmployeeEntity> Employees { get; set; }
    }
}