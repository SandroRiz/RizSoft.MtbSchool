/*namespace RizSoft.MtbSchool.Services;

public class EntityService : BaseService<Entity,int>
{
    public EntityService(IDbContextFactory<MtbSchoolContext> factory) : base(factory)
    {
    }

    public override async Task<List<Entity>> ListAsync()
    {
        using var ctx = await CtxFactory.CreateDbContextAsync();
        return await ctx.Entitys
            .Where(x => x.)
            .OrderByDescending( x => x.)
            .ToListAsync();
    }

   
}
*/