using System;

namespace Final_Assessment_011_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int saving_intention = 0;
            string response = " ";
            Console.WriteLine(" Hello Adventurer!\n Have you played this game before? \n 1.[Y]es \n 2.[N]o \n (Please enter the response) \n");
            Player guest = new Player();
            Inventory guest_inventory = new Inventory();
            Loot guest_loot = new Loot();
            while (saving_intention == 0)
            {
                response = Console.ReadLine();
                if (response.ToUpper() == "Y")
                {
                    saving_intention = 1;
                }
                else if (response.ToUpper() == "N")
                {
                    saving_intention = 2;
                    
                    guest.Player_Initialization(saving_intention);
                    guest_inventory.Initialize_Inventory(saving_intention, guest.player_class);
                }
                else
                {
                    Console.WriteLine("\n Please enter a valid answer.");
                }
            }
            
            //int number = 0;
            //guest_inventory.Inventory_Acces(number); // - Developer check
            
            //inventory check
            /*for (number = 0; number < 8; number++)
            {
                Console.WriteLine(guest_inventory.Size[number].Item_name);
            }*/
        }
    }
}

public class Player
{
    public string player_name;
    public string player_class; //Warrior, Mage, Tank, Unspecialized
    public int player_level;
    public int player_experience;
    public int player_level_up_requierment;
    public int player_general_debuff = 0;
    public int player_dodge_rate = 10;
    public int player_mana_recover;
    public int player_mana;
    public int player_tenacity;
    public int player_armour;
    public int player_attack;
    public int player_health;
    public int player_health_recovery;
    public void Player_Initialization(int saving_intention)
    {
        if(saving_intention == 1)
        {

        }
        else
        {
            string choice, ok;
            Console.WriteLine("Please tell us your name: \n");
            player_name = Console.ReadLine();
            Console.WriteLine("Hello " + player_name + ". \n Wellcome in Blitzpit. \n");
            int step = 0;
            while(step == 0)
            {
                Console.WriteLine(" Please choose one class: \n 1.[W]arrior \n 2.[T]ank \n 3.[M]age \n 4.[U]nspecialized \n");
                choice = Console.ReadLine();
                if (choice.ToUpper() == "W" || choice.ToUpper() == "U" || choice.ToUpper() == "T" || choice.ToUpper() == "M")
                {
                    switch (choice.ToUpper())
                    {
                        case ("W"):
                            {
                                Console.WriteLine("Warriors have medium armor, attack, health and no mana. \n Att: 10 \n Armor: 5 \n Health: 100 \n Mana: - \n\n Are you sure you want to be a Warrior? \n 1.[Y]es \n 2.[N]o \n");
                                step = 3;
                                while(step == 3)
                                { 
                                    ok = Console.ReadLine();
                                    if (ok.ToUpper() == "Y")
                                    {
                                        player_class = "Warrior";
                                        choice = null;
                                        ok = null;
                                        player_health = 100;
                                        player_general_debuff = 0;
                                        player_health_recovery = 5;
                                        player_dodge_rate = 10;
                                        player_attack = 10;
                                        player_armour = 5;
                                        player_level = 1;
                                        player_tenacity = 100;
                                        player_mana_recover = 0;
                                        player_mana = 0;
                                        step = 1;
                                    }
                                    else if( ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        step = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid input:");
                                    }
                                    
                                }
                                break;
                            }
                        case "T":
                            {
                                Console.WriteLine("Tanks have high armor and health, but they lack attack and mana. \n Att: 5 \n Armor: 15 \n Health: 150 \n Mana: 50 \n\n Are you sure you want to be a Tank? \n 1.[Y]es \n 2.[N]o \n");
                                step = 3;
                                while (step == 3)
                                {
                                    ok = Console.ReadLine();
                                    if (ok.ToUpper() == "Y")
                                    {
                                        player_class = "Tank";
                                        choice = null;
                                        ok = null;
                                        player_health = 150;
                                        player_general_debuff = 0;
                                        player_health_recovery = 5;
                                        player_dodge_rate = 5;
                                        player_attack = 5;
                                        player_armour = 15;
                                        player_level = 1;
                                        player_tenacity = 90;
                                        player_mana_recover = 5;
                                        player_mana = 50;
                                        step = 1;
                                    }
                                    else if (ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        step = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid input:");
                                    }
                                }
                                break;
                            }
                        case "M":
                            {
                                Console.WriteLine("Mages have high attack and mana, but they lack health and armor. \n Att: 15 \n Armor: 0 \n Health: 75 \n Mana: 150 \n\n Are you sure you want to be a Mage? \n 1.[Y]es \n 2.[N]o \n");
                                step = 3;
                                while (step == 3)
                                {
                                    ok = Console.ReadLine();
                                    if (ok.ToUpper() == "Y")
                                    {
                                        player_class = "Mage";
                                        choice = null;
                                        ok = null;
                                        player_health = 75;
                                        player_general_debuff = 0;
                                        player_health_recovery = 5;
                                        player_dodge_rate = 10;
                                        player_attack = 15;
                                        player_armour = 0;
                                        player_level = 1;
                                        player_tenacity = 100;
                                        player_mana_recover = 10;
                                        player_mana = 150;
                                        step = 1;
                                    }
                                    else if (ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        step = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid input:");
                                    }
                                }
                                break;
                            }
                        case "U":
                            {
                                Console.WriteLine("Unspecialized heroes have medium stats and can equip any wepon/armor, \ncan create/fuse equipment, but they get half the experience and materials as the other heroes do. \n Att: 10 \n Armor: 5 \n Health: 100 \n Mana: 50 \n\n Are you sure you want to be an Unspecialized hero? \n 1.[Y]es \n 2.[N]o \n");
                                step = 3;
                                while (step == 3)
                                {
                                    ok = Console.ReadLine();
                                    if (ok.ToUpper() == "Y")
                                    {
                                        player_class = "Unspecialized";
                                        choice = null;
                                        ok = null;
                                        player_health = 100;
                                        player_health_recovery = 5;
                                        player_dodge_rate = 10;
                                        player_attack = 10;
                                        player_armour = 5;
                                        player_level = 1;
                                        player_tenacity = 100;
                                        player_mana_recover = 5;
                                        player_mana = 50;
                                        player_general_debuff = 1;
                                        step = 1;
                                    }
                                    else if (ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        step = 0;
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
                else
                {
                    Console.WriteLine("Please enter a valid input:");
                }
            }

        }
    }

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

public struct Armour
{
    Inventory_items helmet;
    Inventory_items leggings;
    Inventory_items breastplate;
    Inventory_items gloves;
    Inventory_items boots;
}

public class Inventory
{
    public Inventory_items[] Size = new Inventory_items[10];
    /// <summary>
    /// 0 -> primary weapon
    /// 1 -> secondary weapon/support item
    /// 2 -> armour
    /// 3 - 10 -> anything
    /// </summary>
    /// <param name="number"></param>
    public void Inventory_Acces(int number)
    {
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(Size[i].item_name + "\n" + Size[i].item_number + "\n");
        }
       
    }
    public void Initialize_Inventory(int saving_intention, string Player_Class)
    {
        string choice;
        int ok = 0;
        switch(Player_Class)
        {
            case "Warrior":
                {
                    Console.WriteLine("Please select your weapons: \n 1.[S]word x2 \n 2.[K]nuckels \n 3.[A]xe x2\n");
                    while(ok == 0)
                    {
                        choice = Console.ReadLine();
                        if(choice.ToUpper() == "S")
                        {
                            Size[0].item_name = "Sword (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Sword (secondary)";
                            Size[1].item_Durability = 100;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 1;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if(choice.ToUpper() == "K")
                        {
                            Size[0].item_name = "Knuckels";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Bandages";
                            Size[1].item_Durability = 1;
                            Size[1].item_max_number = 50;
                            Size[1].item_number = 20;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 5;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "A")
                        {
                            Size[0].item_name = "Axe (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Axe (secondary)";
                            Size[1].item_Durability = 100;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 1;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
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
                            Size[0].item_name = "Sword (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Shiled (secondary)";
                            Size[1].item_Durability = 200;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 5;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "L")
                        {
                            Size[0].item_name = "Lance";
                            Size[0].item_Durability = 200;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Small Shield";
                            Size[1].item_Durability = 150;
                            Size[1].item_max_number = 1;
                            Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 2;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "T")
                        {
                            Size[0].item_name = "Tomahawk (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Shield (secondary)";
                            Size[1].item_Durability = 200;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 5;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
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
                            Size[0].item_name = "Scepter (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 3;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Elixir";
                            Size[1].item_Durability = 1;
                            Size[1].item_max_number = 20;
                            Size[1].item_number = 10;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 15;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "W")
                        {
                            Size[0].item_name = "Wand";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Magic Book";
                            Size[1].item_Durability = 150;
                            Size[1].item_max_number = 1;
                            Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 1;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 25;
                            Size[1].item_Bonus_Mana_Recover = 5;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "G")
                        {
                            Size[0].item_name = "Grimoare (main)";
                            Size[0].item_Durability = 200;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 2;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 15;
                            Size[0].item_Bonus_Mana_Recover = 5;
                            //****************************************//
                            Size[1].item_name = "Elixir";
                            Size[1].item_Durability = 1;
                            Size[1].item_max_number = 20;
                            Size[1].item_number = 10;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 15;
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
                            Size[0].item_name = "Sword (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Shield (secondary)";
                            Size[1].item_Durability = 200;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 5;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "K")
                        {
                            Size[0].item_name = "Knuckels";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Bandages";
                            Size[1].item_Durability = 1;
                            Size[1].item_max_number = 50;
                            Size[1].item_number = 20;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 5;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "A")
                        {
                            Size[0].item_name = "Axe (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Axe (secondary)";
                            Size[1].item_Durability = 100;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 1;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "SC")
                        {
                            Size[0].item_name = "Scepter (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 3;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Elixir";
                            Size[1].item_Durability = 1;
                            Size[1].item_max_number = 20;
                            Size[1].item_number = 10;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 15;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "W")
                        {
                            Size[0].item_name = "Wand";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Magic Book";
                            Size[1].item_Durability = 150;
                            Size[1].item_max_number = 1;
                            Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 1;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 25;
                            Size[1].item_Bonus_Mana_Recover = 5;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "G")
                        {
                            Size[0].item_name = "Grimoare (main)";
                            Size[0].item_Durability = 200;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 2;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 15;
                            Size[0].item_Bonus_Mana_Recover = 5;
                            //****************************************//
                            Size[1].item_name = "Elixir";
                            Size[1].item_Durability = 1;
                            Size[1].item_max_number = 20;
                            Size[1].item_number = 10;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 15;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "L")
                        {
                            Size[0].item_name = "Lance";
                            Size[0].item_Durability = 200;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Small Shield";
                            Size[1].item_Durability = 150;
                            Size[1].item_max_number = 1;
                            Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 2;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "T")
                        {
                            Size[0].item_name = "Tomahawk (main)";
                            Size[0].item_Durability = 100;
                            Size[0].item_max_number = Size[0].item_number = 1;
                            Size[0].item_Bonus_Attack = 1;
                            Size[0].item_Bonus_Defence = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Heal_Amount = 0;
                            Size[0].item_Lifesteal = 0;
                            Size[0].item_Bonus_Dodge_Rate = 0;
                            Size[0].item_Tenacity = 0;
                            Size[0].item_Bonus_Mana = 0;
                            Size[0].item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            Size[1].item_name = "Shield (secondary)";
                            Size[1].item_Durability = 200;
                            Size[1].item_max_number = Size[1].item_number = 1;
                            Size[1].item_Bonus_Attack = 0;
                            Size[1].item_Bonus_Defence = 5;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Heal_Amount = 0;
                            Size[1].item_Lifesteal = 0;
                            Size[1].item_Bonus_Dodge_Rate = 0;
                            Size[1].item_Tenacity = 0;
                            Size[1].item_Bonus_Mana = 0;
                            Size[1].item_Bonus_Mana_Recover = 0;
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

public class Loot
{
    public Inventory_items[] Size = new Inventory_items[10];
    //this.Size[] = Inventory.Size[];
    Random rand = new Random();
    int loot, specific, type;
    public void Loot_Generator(string player_class)
    {
        
        loot = rand.Next(1, 295);
        specific = rand.Next(1, 7);
        type = rand.Next(1, 3);
        Console.WriteLine(loot);
        if(player_class == "Warrior" || player_class == "Unspecialized")
        {
            if(type == 1)
            {
                if(loot >= 288 && loot <=295)          //Mithyc gear
                {

                }
                else if(loot >= 273 && loot <= 287 )   //Legendary gear
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
        if(specific == 1)           //Helmet
        {

        }
        else if( specific == 2)     //Breastplate
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
    public void Helmet_Of_Never_Ending_War()
    {
        //Inventory.Size[3].armour.item_name;
        //item_Durability;
        //item_number;
        //item_max_number;
       // item_Bonus_Attack;
        //item_Bonus_Defence;
        //item_Heal_Amount;
       // item_Lifesteal;
      //  item_Bonus_Dodge_Rate;
      //  item_Tenacity;
      //  item_Bonus_Mana;
       // item_Bonus_Mana_Recover;
    }
}