﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Assessment_011_Copy
{
    public class Equipment
{
    public int id_Item;
    public Inventory_items helmet;
    public Inventory_items leggings;
    public Inventory_items breastplate;
    public Inventory_items gloves;
    public Inventory_items boots;
    public Inventory_items primary;
    public Inventory_items secondary;
}

public struct Inventory_items
{
    public string item_name;
    public int item_Durability;
    public int item_number;
    public int item_max_number;
    public int item_Bonus_Attack;
    public int item_Bonus_Defence;
    public int item_Heal_Amount;
    public int item_Lifesteal;
    public int item_Bonus_Dodge_Rate;
    public int item_Tenacity;
    public int item_Bonus_Mana;
    public int item_Bonus_Mana_Recover;
}

public class Inventory
{
    public int[] Size = new int[10];
    public Equipment equipment = new Equipment();
    //int space;
    /// <summary>
    /// armour -> Equiped items
    /// Size[] -> Inventory
    /// </summary>
    /// <param name="number"></param>
    public void Inventory_Acces(int i)
    {   
            Console.WriteLine(Size[i]);
    }
    public int Equip_item(string item_name, int item_Bonus_Attack, int item_Bonus_Defence, int item_Heal_Amount, int item_Lifesteal, int item_Bonus_Dodge_Rate, int item_Tenacity, int item_Bonus_Mana, int item_Bonus_Mana_Recover, int specific, int item_Durability, int item_number, int item_max_number)
    {
        if (specific == 1)           //Helmet
        {
            equipment.helmet.item_name = item_name;
            equipment.helmet.item_Durability = item_Durability;
            equipment.helmet.item_number = item_number;
            equipment.helmet.item_max_number = item_max_number;
            equipment.helmet.item_Bonus_Attack = item_Bonus_Attack;
            equipment.helmet.item_Bonus_Defence = item_Bonus_Defence;
            equipment.helmet.item_Heal_Amount = item_Heal_Amount;
            equipment.helmet.item_Lifesteal = item_Lifesteal;
            equipment.helmet.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.helmet.item_Tenacity = item_Tenacity;
            equipment.helmet.item_Bonus_Mana = item_Bonus_Mana;
            equipment.helmet.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
        else if (specific == 2)     //Breastplate
        {
            equipment.breastplate.item_name = item_name;
            equipment.breastplate.item_Durability = item_Durability;
            equipment.breastplate.item_number = item_number;
            equipment.breastplate.item_max_number = item_max_number;
            equipment.breastplate.item_Bonus_Attack = item_Bonus_Attack;
            equipment.breastplate.item_Bonus_Defence = item_Bonus_Defence;
            equipment.breastplate.item_Heal_Amount = item_Heal_Amount;
            equipment.breastplate.item_Lifesteal = item_Lifesteal;
            equipment.breastplate.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.breastplate.item_Tenacity = item_Tenacity;
            equipment.breastplate.item_Bonus_Mana = item_Bonus_Mana;
            equipment.breastplate.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
        else if (specific == 3)      //Leggings
        {
            equipment.leggings.item_name = item_name;
            equipment.leggings.item_Durability = item_Durability;
            equipment.leggings.item_number = item_number; ;
            equipment.leggings.item_max_number = item_max_number;
            equipment.leggings.item_Bonus_Attack = item_Bonus_Attack;
            equipment.leggings.item_Bonus_Defence = item_Bonus_Defence;
            equipment.leggings.item_Heal_Amount = item_Heal_Amount;
            equipment.leggings.item_Lifesteal = item_Lifesteal;
            equipment.leggings.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.leggings.item_Tenacity = item_Tenacity;
            equipment.leggings.item_Bonus_Mana = item_Bonus_Mana;
            equipment.leggings.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
        else if (specific == 4)       //Boots
        {
            equipment.boots.item_name = item_name;
            equipment.boots.item_Durability = item_Durability;
            equipment.boots.item_number = item_number; ;
            equipment.boots.item_max_number = item_max_number;
            equipment.boots.item_Bonus_Attack = item_Bonus_Attack;
            equipment.boots.item_Bonus_Defence = item_Bonus_Defence;
            equipment.boots.item_Heal_Amount = item_Heal_Amount;
            equipment.boots.item_Lifesteal = item_Lifesteal;
            equipment.boots.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.boots.item_Tenacity = item_Tenacity;
            equipment.boots.item_Bonus_Mana = item_Bonus_Mana;
            equipment.boots.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
        else if (specific == 5)       //Gloves
        {
            equipment.gloves.item_name = item_name;
            equipment.gloves.item_Durability = item_Durability;
            equipment.gloves.item_number = item_number; ;
            equipment.gloves.item_max_number = item_max_number;
            equipment.gloves.item_Bonus_Attack = item_Bonus_Attack;
            equipment.gloves.item_Bonus_Defence = item_Bonus_Defence;
            equipment.gloves.item_Heal_Amount = item_Heal_Amount;
            equipment.gloves.item_Lifesteal = item_Lifesteal;
            equipment.gloves.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.gloves.item_Tenacity = item_Tenacity;
            equipment.gloves.item_Bonus_Mana = item_Bonus_Mana;
            equipment.gloves.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
        else if (specific == 6)       //Primary
        {
            equipment.primary.item_name = item_name;
            equipment.primary.item_Durability = item_Durability;
            equipment.primary.item_number = item_number; ;
            equipment.primary.item_max_number = item_max_number;
            equipment.primary.item_Bonus_Attack = item_Bonus_Attack;
            equipment.primary.item_Bonus_Defence = item_Bonus_Defence;
            equipment.primary.item_Heal_Amount = item_Heal_Amount;
            equipment.primary.item_Lifesteal = item_Lifesteal;
            equipment.primary.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.primary.item_Tenacity = item_Tenacity;
            equipment.primary.item_Bonus_Mana = item_Bonus_Mana;
            equipment.primary.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
        else                          //Secondary
        {
            equipment.secondary.item_name = item_name;
            equipment.secondary.item_Durability = item_Durability;
            equipment.secondary.item_number = item_number; ;
            equipment.secondary.item_max_number = item_max_number;
            equipment.secondary.item_Bonus_Attack = item_Bonus_Attack;
            equipment.secondary.item_Bonus_Defence = item_Bonus_Defence;
            equipment.secondary.item_Heal_Amount = item_Heal_Amount;
            equipment.secondary.item_Lifesteal = item_Lifesteal;
            equipment.secondary.item_Bonus_Dodge_Rate = item_Bonus_Dodge_Rate;
            equipment.secondary.item_Tenacity = item_Tenacity;
            equipment.secondary.item_Bonus_Mana = item_Bonus_Mana;
            equipment.secondary.item_Bonus_Mana_Recover = item_Bonus_Mana_Recover;
            return 1;
        }
    }

    public void Initialize_Inventory(int saving_intention, string Player_Class)
    {
        string choice;
        int ok = 0;
        switch (Player_Class)
        {
            case "Warrior":
                {
                    Console.WriteLine("Please select your weapons: \n 1.[S]word x2 \n 2.[K]nuckels \n 3.[A]xe x2\n");
                    while (ok == 0)
                    {
                        choice = Console.ReadLine();
                        if (choice.ToUpper() == "S")
                        {
                            Equip_item("Sword (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Sword (secondary)", 1, 0, 0, 0, 0, 0, 0, 0, 7, 100, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "K")
                        {
                            Equip_item("Knuckels (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Bandages (secondary)", 0, 0, 0, 5, 0, 0, 0, 0, 7, 100, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "A")
                        {
                            Equip_item("Axe (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Axe (secondary)", 1, 0, 0, 0, 0, 0, 0, 0, 7, 100, 1, 1);
                            ok = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input!");
                        }
                    }
                    break;
                }
            case "Tank":
                {
                    Console.WriteLine("Please select your weapons: \n 1.[S]word and Shield \n 2.[L]ance and Shield  \n 3.[T]omahawk and Shield\n");
                    while (ok == 0)
                    {
                        choice = Console.ReadLine();
                        if (choice.ToUpper() == "S")
                        {
                            equipment.primary.item_name = "Sword (main)";

                            Equip_item("Sword (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Shield (secondary)", 0, 5, 0, 0, 0, 0, 0, 0, 7, 200, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "L")
                        {

                            Equip_item("Lance (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 200, 1, 1);
                            Equip_item("Small Shield (secondary)", 0, 2, 0, 0, 0, 0, 0, 0, 7, 150, 1, 1);
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "T")
                        {
                            Equip_item("Tomahawk (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Shield (secondary)", 0, 5, 0, 0, 0, 0, 0, 0, 7, 200, 1, 1);
                            ok = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input!");
                        }
                    }
                    break;
                }
            case "Mage":
                {
                    Console.WriteLine("Please select your weapons: \n 1.[S]cepter \n 2.[W]and  \n 3.[G]rimoare\n");
                    while (ok == 0)
                    {
                        choice = Console.ReadLine();
                        if (choice.ToUpper() == "S")
                        {
                            Equip_item("Scepter (main)", 3, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Cristal (secondary)", 0, 0, 0, 0, 0, 0, 0, 15, 7, 100, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "W")
                        {
                            Equip_item("Wand (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Magic Book (secondary)", 0, 0, 0, 5, 0, 0, 25, 5, 7, 150, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "G")
                        {
                            Equip_item("Grimoare (main)", 2, 0, 0, 0, 0, 0, 15, 0, 6, 200, 1, 1);
                            Equip_item("Cards (secondary)", 0, 0, 0, 0, 0, 0, 0, 15, 7, 100, 1, 1);
                            ok = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input!");
                        }
                    }
                    break;
                }
            case "Unspecialized":
                {
                    Console.WriteLine("Please select your weapons: \n 1.[K]nuckels \n 2.[A]xe x2\n 3.[Sw]ord and Shield \n 4.[L]ance and Shield  \n 5.[T]omahawk and Shield\n 7.[Sc]epter \n 8.[W]and  \n 9.[G]rimoare\n");
                    while (ok == 0)
                    {
                        choice = Console.ReadLine();
                        if (choice.ToUpper() == "SW")
                        {
                            Equip_item("Sword (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Shield (secondary)", 0, 5, 0, 0, 0, 0, 0, 0, 7, 200, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "K")
                        {
                            Equip_item("Knuckels (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Bandages (secondary)", 0, 0, 0, 5, 0, 0, 0, 0, 7, 1, 20, 50);
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "A")
                        {
                            Equip_item("Axe (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Axe (secondary)", 1, 0, 0, 0, 0, 0, 0, 0, 7, 100, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "SC")
                        {
                            Equip_item("Scepter (main)", 2, 0, 0, 0, 0, 0, 15, 0, 6, 200, 1, 1);
                            Equip_item("Elixir (secondary)", 0, 0, 0, 0, 0, 0, 0, 15, 7, 1, 10, 20);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "W")
                        {
                            Equip_item("Wand (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Magic Book (secondary)", 0, 0, 0, 5, 0, 0, 25, 5, 7, 150, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "G")
                        {
                            Equip_item("Grimoare (main)", 2, 0, 0, 0, 0, 0, 15, 0, 6, 200, 1, 1);
                            Equip_item("Elixir (secondary)", 0, 0, 0, 0, 0, 0, 0, 15, 7, 1, 10, 20);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "L")
                        {
                            Equip_item("Lance (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 200, 1, 1);
                            Equip_item("Small Shield (secondary)", 0, 2, 0, 0, 0, 0, 0, 0, 7, 150, 1, 1);
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "T")
                        {
                            Equip_item("Tomahawk (main)", 1, 0, 0, 0, 0, 0, 0, 0, 6, 100, 1, 1);
                            Equip_item("Shield (secondary)", 0, 5, 0, 0, 0, 0, 0, 0, 7, 200, 1, 1);
                            ok = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input!");
                        }
                    }
                    break;
                }

        }
    }

}

public class Loot : Inventory
{
    Random rand = new Random();
    int loot, specific, type;
    public void Loot_Generator(string player_class)
    {

        loot = rand.Next(1, 300);
        specific = rand.Next(1, 7);
        type = rand.Next(1, 3);
        Console.WriteLine(loot);
        if (player_class == "Warrior" || player_class == "Unspecialized")
        {
            if (type == 1)
            {
                if (loot >= 288 && loot <= 295)          //Mithycal gear
                {

                }
                else if (loot >= 273 && loot <= 287)   //Legendary gear
                {

                }
                else if (loot >= 212 && loot <= 272)   //Epic gear
                {

                }
                else if (loot >= 121 && loot <= 211)    //Rare gear
                {

                }
                else if (loot <= 120)                   //Common gear
                {

                }
                else                                    //Consumables
                {

                }
            }
        }
        else if (player_class == "Tank" || player_class == "Unspecialized")
        {
            if (type == 2)
            {
                if (loot >= 288 && loot <= 295)          //Mithyc gear
                {

                }
                else if (loot >= 273 && loot <= 287)   //Legendary gear
                {

                }
                else if (loot >= 212 && loot <= 272)   //Epic gear
                {

                }
                else if (loot >= 121 && loot <= 211)    //Rare gear
                {

                }
                else if (loot <= 120)                   //Common gear
                {

                }
                else                                    //Consumables
                {

                }
            }
        }
        else if (player_class == "Mage" || player_class == "Unspecialized")
        {
            if (type == 3)
            {
                if (loot >= 288 && loot <= 295)          //Mithyc gear
                {

                }
                else if (loot >= 273 && loot <= 287)   //Legendary gear
                {

                }
                else if (loot >= 212 && loot <= 272)   //Epic gear
                {

                }
                else if (loot >= 121 && loot <= 211)    //Rare gear
                {

                }
                else if (loot <= 120)                   //Common gear
                {

                }
                else                                    //Consumables
                {

                }
            }
        }
    }
    public void Mithyc_Gear(int type, int specific)
    {
        if (specific == 1)           //Helmet
        {

        }
        else if (specific == 2)     //Breastplate
        {

        }
        else if (specific == 3)      //Leggings
        {

        }
        else if (specific == 4)       //Boots
        {

        }
        else if (specific == 5)       //Gloves
        {

        }
        else if (specific == 6)       //Primary
        {

        }
        else                          //Secondary
        {

        }
    }
    public void Legendary_Gear(int type, int specific)
    {
        if (specific == 1)           //Helmet
        {

        }
        else if (specific == 2)     //Breastplate
        {

        }
        else if (specific == 3)      //Leggings
        {

        }
        else if (specific == 4)       //Boots
        {

        }
        else if (specific == 5)       //Gloves
        {

        }
        else if (specific == 6)       //Primary
        {

        }
        else                          //Secondary
        {

        }
    }
    public void Epic_Gear(int type, int specific)
    {
        if (specific == 1)           //Helmet
        {

        }
        else if (specific == 2)     //Breastplate
        {

        }
        else if (specific == 3)      //Leggings
        {

        }
        else if (specific == 4)       //Boots
        {

        }
        else if (specific == 5)       //Gloves
        {

        }
        else if (specific == 6)       //Primary
        {

        }
        else                          //Secondary
        {

        }
    }
    public void Rare_Gear(int type, int specific)
    {
        if (specific == 1)           //Helmet
        {

        }
        else if (specific == 2)     //Breastplate
        {

        }
        else if (specific == 3)      //Leggings
        {

        }
        else if (specific == 4)       //Boots
        {

        }
        else if (specific == 5)       //Gloves
        {

        }
        else if (specific == 6)       //Primary
        {

        }
        else                          //Secondary
        {

        }
    }
    public void Common_Gear(int type, int specific)
    {
        if (specific == 1)           //Helmet
        {

        }
        else if (specific == 2)     //Breastplate
        {

        }
        else if (specific == 3)      //Leggings
        {

        }
        else if (specific == 4)       //Boots
        {

        }
        else if (specific == 5)       //Gloves
        {

        }
        else if (specific == 6)       //Primary
        {

        }
        else                          //Secondary
        {

        }
    }
    public void Consumables(int type, int specific)
    {
        if (specific == 1)           //Helmet
        {

        }
        else if (specific == 2)     //Breastplate
        {

        }
        else if (specific == 3)      //Leggings
        {

        }
        else if (specific == 4)       //Boots
        {

        }
        else if (specific == 5)       //Gloves
        {

        }
        else if (specific == 6)       //Primary
        {

        }
        else                          //Secondary
        {

        }
    }

    //Mithic Helemts
    public void Helmet_Of_Never_Ending_War(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Helmet Of Never Ending War. \n");
        if (type == 1)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Helmet Of Never Ending War", 500, 100, 1000, 30, 50, 100, 0, 0, 1, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a warrior in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }
    public void Helmet_Of_Ever_Lasting(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Helmet Of Ever Lasting.. \n");
        if (type == 2)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Helmet Of Ever Lasting", 350, 300, 10000, 35, 25, 90, 1000, 100, 1, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a tank in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }
    public void Hat_Of_Infinit_Potential(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the  Hat Of Infinit Potential. \n");
        if (type == 3)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Hat_Of_Infinit_Potential", 500, 100, 800, 15, 50, 100, 2000, 150, 1, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a mage in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }

    //Mithyc Breastplates
    public void Breastplate_Of_The_Mischief(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Breastplate Of The Mischief. \n");
        if (type == 1)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Breastplate Of The Mischief", 200, 300, 2000, 20, 60, 200, 0, 0, 2, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a warrior in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }
    public void Breastplate_Of_The_Giants(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Breastplate Of The Giants. \n");
        if (type == 2)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Breastplate Of The Giants", 200, 500, 5000, 30, 60, 200, 1000, 75, 2, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a tank in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }
    public void Breastplate_Of_The_Phenomenal_Evil(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Breastplate Of The Phenomenal Evil. \n");
        if (type == 3)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {

                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Breastplate Of The Phenomenal Evil", 1000, 300, 1000, 20, 60, 100, 1000, 150, 2, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a mage in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }

    //Mithyc Gloves
    public void Gloves_Of_The_Slayer(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Gloves Of The Slayer. \n");
        if (type == 1)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Gloves Of The Slayer", 1000, 300, 2000, 30, 60, 100, 0, 0, 3, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a warrior in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }
    public void Gloves_Of_The_Undefeated(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Gloves Of The Undefeated. \n");
        if (type == 2)
        {
            Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
            do
            {
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Gloves Of The Undefeated", 1000, 300, 2000, 30, 60, 100, 2000, 50, 3, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a tank in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);
        }
    }
    public void Gloves_Of_Infinit_Power(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Gloves Of Infinit Power. \n");

        if (type == 3)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Gloves Of Infinit Power", 2000, 300, 1000, 30, 60, 100, 2000, 300, 3, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a mage in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }

    //Mithyc Leggings
    public void Leggings_Of_The_Cunning(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Leggings Of The Cunning. \n");

        if (type == 1)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Leggings Of The Cunning", 800, 300, 1000, 30, 100, 120, 0, 0, 4, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a warrior in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }
    public void Leggings_Of_The_Heaven_And_Earth(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Leggings Of The Heaven And Earth. \n");

        if (type == 2)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Leggings Of The Heaven And Earth", 800, 1000, 2000, 10, 100, 120, 1000, 100, 4, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a tank in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }
    public void Leggings_Of_The_Arcane_Sage(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Leggings Of The Arcane Sage. \n");

        if (type == 3)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Leggings Of The Arcane Sage", 1000, 100, 1000, 10, 100, 120, 2000, 200, 4, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a mage in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }

    //Mithyc Boots
    public void Boots_Of_The_Berseker(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Boots Of The Berseker. \n");
        if (type == 1)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Boots Of The Berseker", 800, 300, 1000, 30, 100, 120, 0, 0, 5, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a warrior in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }
    public void Boots_Of_The_Atlas(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Boots Of The Atlas. \n");
        if (type == 2)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Boots Of The Atlas", 200, 500, 2000, 20, 100, 120, 1000, 75, 5, 9999, 1, 1);
                    equipment.boots.item_Bonus_Mana_Recover = 75;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a tank in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }
    public void Boots_Of_The_Void_Walker(int type, int space)
    {
        string choice;
        bool ok = false;
        Console.WriteLine("You found the Boots Of The Void Walker. \n");
        if (type == 1)
        {
            do
            {
                Console.WriteLine("Would you like to [e]quip it, or [k]eep it safe?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "e")
                {
                    Equip_item("Boots Of The Void Walker", 800, 300, 1000, 30, 100, 120, 1000, 100, 5, 9999, 1, 1);
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space] = equipment.id_Item;
                    ok = true;
                }
            } while (ok == false);
        }
        else
        {
            do
            {
                Console.WriteLine("You are requiered to be a mage in order to equip this.\n Would you like to [k]eep it or [s]ell it?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "k")
                {
                    ok = true;
                }
                else if (choice.ToLower() == "s")
                {
                    ok = true;
                }
            } while (ok == false);

        }
    }


}

}
