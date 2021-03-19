using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AxcendPOC.Models
{
    public class Common
    {
        public int? Status { get; set; }
        public bool? IsActive { get; set; }
        public bool? Enable { get; set; }
        [Display(Name = "Created Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedOn { get; set; }
        public string Comments { get; set; }
    }
}