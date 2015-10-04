using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Portable.Entities;
using Business.Portable.Enums;

namespace Business.Services.Contexts.Validatiion
{
    [Table("Log")]
    public class LogEntity:Log
    {
        [Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Required]
        public override int LogId
        {
            get
            {
                return base.LogId;
            }
            set
            {
                base.LogId = value;
            }
        }
        [Required]
        [MaxLength(100)]
        public override string CreatedByUserId
        {
            get
            {
                return base.CreatedByUserId;
            }
            set
            {
                base.CreatedByUserId = value;
            }
        }

        [MaxLength(150)]
        public override string Message
        {
            get
            {
                return base.Message;
            }
            set
            {
                base.Message = value;
            }
        }


        [Required]
        [MaxLength(300)]
        public override string Source
        {
            get
            {
                return base.Source;
            }
            set
            {
                base.Source = value;
            }
        }
        [Required]
        public override DateTime CreatedDateTime
        {
            get
            {
                return base.CreatedDateTime;
            }
            set
            {
                base.CreatedDateTime = value;
            }
        }
        [Required]
        public override LogType LogType
        {
            get
            {
                return base.LogType;
            }
            set
            {
                base.LogType = value;
            }
        }
    }
}
