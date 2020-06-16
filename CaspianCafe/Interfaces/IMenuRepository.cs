using CaspianCafe.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaspianCafe.Interfaces
{
    interface IMenuRepository
    {
        IList<MenuItem> GetMenuItems();
    }
}
