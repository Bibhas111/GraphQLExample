using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExample.Models
{
    public class Project
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ProjectManager { get; set; }
        public string Department { get; set; }
    }
}
