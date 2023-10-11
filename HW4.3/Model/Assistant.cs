using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._3.Model
{
    internal class Assistant:Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if(employee.IsSuccessfull)
            {
                employee = GetPromotion(employee);
            }
        }
    }
}
