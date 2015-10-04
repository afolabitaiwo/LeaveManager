using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Portable.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Business.Services.Contexts.Validatiion
{
     [Table("EmployeeType")]
    public class EmployeeTypeEntity : EmployeeType
    {
        [StringLength(100,MinimumLength = 5)]
        public override string Name { get; set; }

        public EmployeeTypeEntity()
        {
            this.Employees = new HashSet<EmployeeEntity>();
        }


        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int EmployeeTypeId
        {
            get
            {
                return base.EmployeeTypeId;
            }
            set
            {
                base.EmployeeTypeId = value;
            }
        }

        public virtual ICollection<EmployeeEntity> Employees { get; set; }
    }
}