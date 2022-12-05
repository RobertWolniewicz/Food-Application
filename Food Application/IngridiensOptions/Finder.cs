namespace Food_Application
{
    public class Finder
    {
        public static async Task<List<Ingridien>> Find(ApplicatioDbContext dbContext, string searchPhrase)
        {
           var result = await dbContext.ingridiens.Where(i => i.name.ToLower().Contains(searchPhrase.ToLower())).ToListAsync();
            return result;
        }
    }
}
