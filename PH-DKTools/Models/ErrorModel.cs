using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PH_DKTools.Models
{
    public class ErrorModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }
        public DateTime TimeOccured { get; set; }

        public ErrorModel(int Id, string Title, string Severity, string Message, DateTime TimeOccured)
        {
            this.Id = Id;
            this.Title = Title;
            this.Severity = Severity;
            this.Message = Message;
            this.TimeOccured = TimeOccured;
        }
    }
}