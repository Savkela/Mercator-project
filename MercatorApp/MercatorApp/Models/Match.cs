using System.ComponentModel.DataAnnotations;

namespace MercatorApp.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public int GoalsTeam1 { get; set; }
        public int GoalsTeam2 { get; set; }



    }
}
