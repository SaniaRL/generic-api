using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAgendaAPI.Models
{
    public class PostCategory
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string TextColor { get; set; }
        public required string BackgroundColor { get; set; }
        public int DisplaySettingsId { get; set; }
        public PostCategoryDisplaySettings DisplaySettings { get; set; } = null!;
    }
}
