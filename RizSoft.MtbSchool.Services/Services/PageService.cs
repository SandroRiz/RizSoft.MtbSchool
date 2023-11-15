namespace RizSoft.MtbSchool.Services;

public class PageService : BaseService<Page,int>
{
    public PageService(IDbContextFactory<MtbSchoolContext> factory) : base(factory)
    {
    }

   public async Task<Page> GetByIdAsync(int id)
    {
        using var ctx = await CtxFactory.CreateDbContextAsync();

        return await ctx.Pages
            .Where( x => x.Id == id)
            .SingleOrDefaultAsync();

    }

   
}
