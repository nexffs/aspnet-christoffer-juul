using Infrastructure.Identity;
using Infrastructure.Persistence.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Contexts;

public class PersistenceContext(DbContextOptions options) : IdentityDbContext<AppUser>(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersistenceContext).Assembly);

        modelBuilder.Entity<FaqEntity>().HasData(
        new FaqEntity
        {
            Id = 1,
            Title = "Q1. Do I need prior gym experience to join CoreFitness?",
            Description = "No, GymPro is designed for all fitness levels. Our trainers guide beginners with proper techniques and structured workout plans to help them start safely and confidently."
        },
        new FaqEntity
        {
            Id = 2,
            Title = "Q2. What facilities are included with the membership?",
            Description = "Our membership gives you full access to state-of-the-art gym equipment, free weights, cardio machines, and functional training areas. " +
            "You can also enjoy group fitness classes, locker rooms, and relaxation areas designed to support your overall fitness experience."
        },
        new FaqEntity
        {
            Id = 3,
            Title = "Q3. Can I try the gym before taking a membership?",
            Description = "Yes, we offer trial sessions so you can explore our facilities and experience our training environment before committing. " +
            "This allows you to meet our trainers, test the equipment, and see if CoreFitness is the right fit for you."
        },
        new FaqEntity
        {
            Id = 4,
            Title = "Q4. Are there group workout programs available?",
            Description = "Absolutely! We offer a variety of group workout programs, including strength training, cardio sessions, yoga, and high-intensity interval training. " +
            "These classes are led by experienced instructors and are suitable for all fitness levels."
        },
        new FaqEntity
        {
            Id = 5,
            Title = "Q5. Is nutrition guidance included in the plans?",
            Description = "Yes, many of our programs include basic nutrition guidance to help you reach your fitness goals. " +
            "Our trainers can provide recommendations and tips to support a balanced diet alongside your workout routine."
        });
    }

    public DbSet<ContactRequestEntity> ContactRequests => Set<ContactRequestEntity>();

    public DbSet<FaqEntity> Faqs { get; set; }
}
