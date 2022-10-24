namespace DeMVC.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Work")]
    public partial class Work
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string loginWorker { get; set; }

        [Required]
        [StringLength(20)]
        public string loginManager { get; set; }

        public int idGraide { get; set; }

        public int junior { get; set; }

        public int middle { get; set; }

        public int senior { get; set; }

        public double coefAnalize { get; set; }

        public double coefDeployment { get; set; }

        public double coefSupport { get; set; }

        public double coefTime { get; set; }

        public int coefCompexity { get; set; }

        public int coefManey { get; set; }

        public virtual Graide Graide { get; set; }

        public virtual Manager Manager { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
