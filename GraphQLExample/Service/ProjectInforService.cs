using GraphQLExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExample.Service
{
    public class ProjectInforService
    {


        public IQueryable<Project> GetBlogs()
        {

            var blog = new Project
            {
                Id = 1,
                Name = "Developer for Life",
                ProjectManager="Rankin",
                Department="ABC"
                
    
            };

         
            return new[] { blog }.AsQueryable();

        }
    }
}
