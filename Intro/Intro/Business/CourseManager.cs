using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{

    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        CourseDal courseDal = new CourseDal();

        return courseDal.GetAll(); ;
    }


}
