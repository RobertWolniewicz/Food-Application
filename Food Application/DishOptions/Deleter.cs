namespace Food_Application.DishOptions
{
    internal class Deleter
    {
        public static async Task Delet(ApplicatioDbContext dbContext, String DishToDelet)
        {
            var deletedDish = await dbContext.Dishs.FirstAsync(D => D.name == DishToDelet);
            dbContext.Dishs.Remove(deletedDish);
            dbContext.SaveChangesAsync();
            return;
        }
    }
}
