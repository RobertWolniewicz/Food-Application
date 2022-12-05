namespace Food_Application
{
    internal class Delete
    {
        public static async Task Deleter(ApplicatioDbContext dbContext, String DeletedIngridien)
            {
           var deletedIngridien = await dbContext.ingridiens.FirstAsync(i => i.name == DeletedIngridien);
           dbContext.ingridiens.Remove(deletedIngridien);
           dbContext.SaveChangesAsync();
            return;
            }
        
    }
}
