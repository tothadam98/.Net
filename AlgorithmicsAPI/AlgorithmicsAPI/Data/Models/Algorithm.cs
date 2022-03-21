using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AlgorithmicsAPI.Data.Models.Enums;

namespace AlgorithmicsAPI.Data.Models
{
    public class Algorithm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public string Icon { get; set; }
        public string Url { get; set; }
        public AlgorithmType Type { get; set; }
        public DateTime CreationDate { get; set; }
        public Boolean IsPublished { get; set; }

    }
}
