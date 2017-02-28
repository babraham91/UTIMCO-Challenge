using System.Collections.Generic;
using UTIMCOMenu.Models;

namespace UTIMCOMenu.BLL
{
    public class MenuBLL : IMenuBLL
    {
        public SumsModel Calculate(List<MenuJson> menus)
        {
            SumsModel sums = new SumsModel { };
            sums.sums = new List<int> { };

            foreach (MenuJson menu in menus)
            {
                int sum = 0;

                foreach (ItemModel item in menu.menu.items)
                {
                    if (item != null)
                    {
                        if (item.label != null && item.label.Trim() != "")
                        {
                            sum += item.id;
                        }
                    }
                }

                sums.sums.Add(sum);
            }

            return sums;
        }
    }
}
