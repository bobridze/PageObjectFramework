using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Interfaces
{
    public interface ISideBar : IBasePage
    {
        void SelectCategory(string category);
    }
}
