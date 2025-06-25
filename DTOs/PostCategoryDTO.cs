using PersonalAgendaAPI.Models;

namespace PersonalAgendaAPI.DTOs
{
    public class PostCategoryDTO
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string TextColor { get; set; }
        public required string BackgroundColor { get; set; }
        public required int DisplaySettingsId {  get; set; }
        public required PostCategoryDisplaySettingsDTO DisplaySettings { get; set; }

        public static PostCategoryDTO FromEntity(PostCategory postCategory)
        {
            return new PostCategoryDTO
            {
                Id = postCategory.Id,
                Title = postCategory.Title,
                TextColor = postCategory.TextColor,
                BackgroundColor = postCategory.BackgroundColor,
                DisplaySettingsId = postCategory.DisplaySettingsId,
                DisplaySettings = PostCategoryDisplaySettingsDTO.FromEntity(postCategory.DisplaySettings)
            };
        }

    }
}
