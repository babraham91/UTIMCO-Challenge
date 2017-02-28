using System.Collections.Generic;
using UTIMCOMenu.Models;

namespace UTIMCOMenu.BLL
{
    public interface IMenuBLL
    {
        SumsModel Calculate(List<MenuJson> json);
    }
}
