using PersonalAgendaAPI.Models;

namespace PersonalAgendaAPI.DTOs
{
    public class PostCategoryDisplaySettingsDTO
    {
        public int Id { get; set; }
        public int Index { get; set; }

        public static PostCategoryDisplaySettingsDTO FromEntity(PostCategoryDisplaySettings displaySettings)
        {
            return new PostCategoryDisplaySettingsDTO
            {
                Id = displaySettings.Id,
                Index = displaySettings.Index
            };
        } 
    }
}
