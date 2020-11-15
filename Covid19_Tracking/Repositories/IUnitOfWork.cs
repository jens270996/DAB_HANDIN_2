using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19_Tracking.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //ICourseRepository Courses { get; }
        //IAuthorRepository Authors { get; }
        int Complete();
    }
}
