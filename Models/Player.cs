using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlayersProj.Models
{[Table("Player")]
    public class Player
    {    [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public string  PPic { get; set; }
        [NotMapped]
        public IFormFile PicFile { get; set; }
    }
}
