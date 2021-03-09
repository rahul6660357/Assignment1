using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TargetSettingTool.Models
{
    public class AppLogger
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(4000)]
        public string Message { get; set; }
        [MaxLength(400)]
        public string UserSession { get; set; }
        [MaxLength(100)]
        public string UserID { get; set; }
        [Required]
        public string PublicIP { get; set; }

        public string LocalIP { get; set; }
        [MaxLength(4000)]
        public string UserAgent { get; set; }
        public DateTime CreatedTime { get; set; }
        public int localPort { get; set; }
        public int remotePort { get; set; }

    }
}
