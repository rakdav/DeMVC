namespace DeMVC.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tasks
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string LoginWorker { get; set; }

        [Required]
        [StringLength(100)]
        public string title { get; set; }

        public int Hard { get; set; }
        public string Description { get; set; }
        public DateTime Srok { get; set; }
        public DateTime Data { get; set; }
        public int Period { get; set; }
        public int? idStatus { get; set; }

        public int? idComp { get; set; }

        public virtual Compexity Compexity { get; set; }

        public virtual Status Status { get; set; }

        public virtual Worker Worker { get; set; }
       
    }
}
