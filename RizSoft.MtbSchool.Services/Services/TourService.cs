namespace RizSoft.MtbSchool.Services;

public class TourService : BaseService<Tour,int>
{
    public TourService(IDbContextFactory<MtbSchoolContext> factory) : base(factory)
    {
    }

    public async Task<List<Tour>> TopListAsync(int top)
    {
        using var ctx = await CtxFactory.CreateDbContextAsync();
       
      
        return await ctx.Tours
          
            .OrderByDescending( x => x.TourDate)
            .Take(top)
            .ToListAsync();
    }

   
}
