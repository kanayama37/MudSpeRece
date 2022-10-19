using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudSpeRece.Shared
{
    public class Reception
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public DateTime? RecDate { get; set; }
        [Required(ErrorMessage = "受付者を入力してください")]
        // [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string RegName { get; set; } = null!;
        public string RecName { get; set; } = null!;
        public string CusName { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Containa { get; set; } = null!;
        public int WorkDivisionId { get; set; }
        public int Checkbox { get; set; }
        public int Checkbox1 { get; set; }
        public int Checkbox2 { get; set; }
        public int Checkbox3 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // public WorkDivision? WorkDivision { get; set; }
    }
}
