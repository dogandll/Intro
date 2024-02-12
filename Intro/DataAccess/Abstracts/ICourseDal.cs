using Intro.Entities;

namespace Intro.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> Getall();
        void Add(Course course);
    }
}
