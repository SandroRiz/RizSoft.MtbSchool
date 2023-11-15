namespace RizSoft.MtbSchool.Services;

public class CourseService : BaseService<Course,int>
{
    public CourseService(IDbContextFactory<MtbSchoolContext> factory) : base(factory)
    {
    }

    
   
}
