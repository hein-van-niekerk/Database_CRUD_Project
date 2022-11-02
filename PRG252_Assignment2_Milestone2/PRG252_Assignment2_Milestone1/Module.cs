using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG252_Assignment2_Milestone1
{
    internal class Module
    {
        public Module () { }

        string moduleCode;
        string moduleName;
        string moduleDescription;
        string moduleResources;

        public Module(string moduleCode, string moduleName, string moduleDescription, string moduleResources)
        {
            this.ModuleCode = moduleCode;
            this.ModuleName = moduleName;
            this.ModuleDescription = moduleDescription;
            this.ModuleResources = moduleResources;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string ModuleResources { get => moduleResources; set => moduleResources = value; }
    }
}
