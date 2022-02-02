using GraphQLExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExample.Service
{
    public class ProjectInforServices
    {


        public IQueryable<ProjectDetail> GetBlogs()
        {

            var blogs = new ProjectDetail
            {
                Id = 1,
                Name = "Developer for Lrererererererereife",
                ProjectManager="Rankin",
                Cost="ABC"
                
    
            };

         
            return new[] { blogs }.AsQueryable();

        }
    }
}
