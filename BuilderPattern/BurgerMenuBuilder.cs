using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.BuilderPattern
{
    public class BurgerMenuBuilder : MenuBuilder
    {
        private Menu _menu = new Menu();
        public override void BuildBurgerOrSalad()
        {
            _menu.Add("salad");
        }

        public override void BuildDessert()
        {
            _menu.Add("dessert");
        }

        public override void BuildDrink()
        {
            _menu.Add("drink");
        }

        public override void BuildFries()
        {
            _menu.Add("fries");
        }

        public override void BuildToy()
        {
            _menu.Add("toy");
        }

        public override Menu GetResult()
        {
           return _menu;
        }
    }
}