using System;
using DotaItems.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotaItems.Data.Models;

namespace DotaItems.Data.Interfaces.Mocks
{
    public class MockItems : IAllItems
    {
        private readonly IItemsCategory _categoryItems = new MockCategory();
        public IEnumerable<Items> Items
        {
            
            get
            {
                return new List<Items>
                {
                    new Items
                    {
                        name = "Arcane Ring",
                        shortDesc ="Restores 75 mana to all nearby allies.",
                        longDesc =@"Restores 75 mana to all nearby allies.
                                    Radius: 1200
                                    Mana Restored: 75",
                        img ="https://dota2.gamepedia.com/File:Arcane_Ring_icon.png",
                        price =300,
                        isFavourite =true,
                        availabele = true,
                        Category =_categoryItems.AllCategories.First()
                    },
                    new Items
                    {
                        name = "Iron Talon",
                        shortDesc ="Targets a non-player enemy unit to remove 40% of its current HP.",
                        longDesc =@"Targets a non-player enemy unit to remove 40% of its current HP.
                                    If cast on a tree or ward, instantly destroys it.
                                    Cast Range (Tree/Unit): 350
                                    Cast Range (Other): 450
                                    Current Health as Damage: 40%",
                        img ="https://dota2.gamepedia.com/File:Iron_Talon_icon.png",
                        price =300,
                        isFavourite =true,
                        availabele = true,
                        Category =_categoryItems.AllCategories.First()
                    },
                    new Items
                    {
                        name = "Poor Man's Shield",
                        shortDesc ="Gives a 100% chance to block 20 damage from incoming attacks on melee heroes, and 10 damage on ranged.",
                        longDesc =@"Gives a 100% chance to block 20 damage from incoming attacks on melee heroes, and 10 damage on ranged.
                                    Has a 50% chance to block damage from creeps.
                                    Hero Proc Chance: 100%
                                    Non-Hero Proc Chance: 50%
                                    Blocked Damage (Melee): 20
                                    Blocked Damage (Ranged): 10",
                        img ="https://dota2.gamepedia.com/File:Poor_Man%27s_Shield_icon.png",
                        price =300,
                        isFavourite =true,
                        availabele = true,
                        Category =_categoryItems.AllCategories.First()
                    },
                    new Items
                    {
                        name = "Ring of Aquila",
                        shortDesc ="Grants 1.25 mana regeneration and 2 armor to nearby allies.",
                        longDesc =@"Grants 1.25 mana regeneration and 2 armor to nearby allies.
                                    Deactivate to stop affecting non-hero units.
                                    Radius: 1200
                                    Mana Regeneration Bonus: 1.25
                                    Armor Bonus: 2
                                    Aura Linger Duration: 0.5",
                        img ="https://dota2.gamepedia.com/File:Ring_of_Aquila_(Active)_icon.png",
                        price =300,
                        isFavourite =true,
                        availabele = true,
                        Category =_categoryItems.AllCategories.Last()
                    }
                    //new Items
                    //{
                    //    name = "Trusty Shovel",
                    //    shortDesc ="Can find a Bounty Rune, a Flask, a 2 charged TP Scroll bundle, or an enemy Kobold.",
                    //    longDesc =@"Channel for 1 second.
                    //                Can find a Bounty Rune, a Flask, a 2 charged TP Scroll bundle, or an enemy Kobold.
                    //                Channel Time: 1
                    //                Bounty Rune Drop Chance: 16%
                    //                Healing Salve Drop Chance: 28%
                    //                Town Portal Scroll Drop Chance: 28%
                    //                Kobold Drop Chance: 28%",
                    //    img ="https://dota2.gamepedia.com/File:Trusty_Shovel_icon.png",
                    //    price =300,
                    //    isFavourite =true,
                    //    availabele = true,
                    //    Category =_categoryItems.AllCategories.Last()
                    //}
                };
            }
        }
        public IEnumerable<Items> GetFavItems { get; set; }

        public Items getObjectItems(int itemsID)
        {
            throw new NotImplementedException();
        }
    }
}
