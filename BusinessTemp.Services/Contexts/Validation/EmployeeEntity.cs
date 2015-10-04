using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Portable.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Business.Services.Contexts.Validatiion
{
    [Table("Employee")]
    public class EmployeeEntity : Employee
    {
       
        [Required]        
        public override Guid EmployeeId
        {
            get
            {
                return base.EmployeeId;
            }
            set
            {
                base.EmployeeId = value;
            }
        }

        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override string UserId
        {
            get
            {
                return base.UserId;
            }
            set
            {
                base.UserId = value;
            }
        }

        [MaxLength(100)]
        public override string LastName
        {
            get
            {
                return base.LastName;
            }
            set
            {
                base.LastName = value;
            }
        }

        [MaxLength(100)]
        public override string FirstName
        {
            get
            {
                return base.FirstName;
            }
            set
            {
                base.FirstName = value;
            }
        }

        
       

    }
}