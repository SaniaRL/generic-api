using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAgendaAPI.Models
{
    public class PostCategoryDisplaySettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Index { get; set; }
    }
}
