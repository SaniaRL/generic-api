using PersonalAgendaAPI.Models;

namespace PersonalAgendaAPI.DTOs
{
    public class PostCategoryVM
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string TextColor { get; set; }
        public required string BackgroundColor { get; set; }
        public int DisplaySettingsId { get; set; }
        public int? Index { get; set; }

        public static PostCategoryVM FromEntity(PostCategory postCategory, PostCategoryDisplaySettings displaySettings)
        {
            return new PostCategoryVM
            {
                Id = postCategory.Id,
                Title = postCategory.Title,
                TextColor = postCategory.TextColor,
                BackgroundColor = postCategory.BackgroundColor,
                DisplaySettingsId = displaySettings.Id,
                Index = displaySettings.Index
            };
        }

    }
}
