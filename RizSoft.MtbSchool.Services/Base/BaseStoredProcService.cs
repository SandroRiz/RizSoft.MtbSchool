namespace RizSoft.MtbSchool.Services;

public class BaseStoredProcService :  IBaseStoredProcRepository

{
    protected IDbContextFactory<MtbSchoolContext> CtxFactory { get; }
    public BaseStoredProcService(IDbContextFactory<MtbSchoolContext> ctxFactory)
    {
        CtxFactory = ctxFactory;
    }







}