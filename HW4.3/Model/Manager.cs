﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._3.Model
{
    internal class Manager
    {
        protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee;
        }
    }
}
