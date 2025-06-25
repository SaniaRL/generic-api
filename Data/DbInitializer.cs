using PersonalAgendaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PersonalAgendaAPI.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            var displaySetting1 = new PostCategoryDisplaySettings { Id = 1, Index = 1 };
            var displaySetting2 = new PostCategoryDisplaySettings { Id = 2, Index = 2 };

            modelBuilder.Entity<PostCategoryDisplaySettings>().HasData(
                displaySetting1,
                displaySetting2
            );

            modelBuilder.Entity<PostCategory>().HasData(
                new PostCategory { Id = 1, Title = "Post", TextColor = "#FFFFFF", BackgroundColor = "#585858", DisplaySettingsId = displaySetting1.Id },
                new PostCategory { Id = 2, Title = "Work", TextColor = "#FFFFFF", BackgroundColor = "#2D416F", DisplaySettingsId = displaySetting2.Id }
            );
        }
    }
}
