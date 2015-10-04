using System;
using System.Collections.Generic;
using System.Linq;

using Business.Portable.Enums;

namespace Business.Portable.Entities
{
    public class RecordState
    {
        
        private void InitState()
        {
            this.RecordStateType = Enums.RecordStateType.New;
            this.ModifiedDateTime = this.CreatedDateTime = DateTime.UtcNow;
        }

        public RecordState()
        {
            InitState();
        }

        public RecordState(string createdByUser)
        {
            this.CreatedByUserId = this.ModfiedByUserId = createdByUser;
            InitState();
        }

        public RecordState ModifyState(string userId)
        {
            RecordState self = this;

            self.ModfiedByUserId = userId;
            self.ModifiedDateTime = DateTime.UtcNow;

            return self;
        }

        
        public string CreatedByUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string ModfiedByUserId { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public RecordStateType RecordStateType { get; set; }
    }
}