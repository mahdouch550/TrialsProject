using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialsProject.Models
{
    public class Visite
    {
        [Key]
        public int ID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string NoteMarchandiseur { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public int OwnerId { get; set; }
        public string CustomInfo { get; set; }
        public byte[] CustomAttachment { get; set; }
        public string CustomAttachmentFileName { get; set; }
        public int? NbArticleParSite { get; set; }
        public int? NbArticleTotal { get; set; }
        public int PlanId { get; set; }
        public int IdUser { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateModificationEtat { get; set; }
        public int IdUserModificationEtat { get; set; }
        public virtual Site Site { get; set; }
        public DateTime? DateVisite { get; set; }
        public double? LatitudeLastVisite { get; set; }
        public double? LongitudeLastVisite { get; set; }
        public bool SendReport { get; set; }
    }
}