using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatchAPI.Models
{
    public class MatchOdds: BaseEntity
    {
        [ForeignKey("FK_MatchId")]
        public int MatchId { get; set; }
        public string Specifier { get; set; }
        public decimal Odd { get; set; }

    }
}
