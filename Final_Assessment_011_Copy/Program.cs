using System;
using System.Threading;


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
    int delay = 3000;
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
           Thread.Sleep(delay);
            Console.Clear();
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
                                        Console.Clear();
                                    }
                                    else if( ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        Console.Clear();
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
                                        Console.Clear();
                                        step = 1;
                                    }
                                    else if (ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        Console.Clear();
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
                                        Console.Clear();
                                        step = 1;
                                    }
                                    else if (ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        Console.Clear();
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
                                        Console.Clear();
                                        step = 1;
                                    }
                                    else if (ok.ToUpper() == "N")
                                    {
                                        choice = null;
                                        ok = null;
                                        Console.Clear();
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

public struct Equipment 
{
    public Inventory_items helmet;
    public Inventory_items leggings;
    public Inventory_items breastplate;
    public Inventory_items gloves;
    public Inventory_items boots;
    public Inventory_items primary;
    public Inventory_items secondary;
}

public class Inventory
{
    public Inventory_items[] Size = new Inventory_items[65];
    public Equipment equipment = new Equipment();
    //int space;
    /// <summary>
    /// armour -> Equiped items
    /// Size[] -> Inventory
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
                            equipment.primary.item_name = "Sword (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Sword (secondary)";
                            equipment.secondary.item_Durability = 100;
                            equipment.secondary.item_max_number = equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 1;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if(choice.ToUpper() == "K")
                        {
                            equipment.primary.item_name = "Knuckels";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Bandages";
                            equipment.secondary.item_Durability = 1;
                            equipment.secondary.item_max_number = 50;
                            equipment.secondary.item_number = 20;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 5;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "A")
                        {
                            equipment.primary.item_name = "Axe (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Axe (secondary)";
                            equipment.secondary.item_Durability = 100;
                            equipment.secondary.item_max_number = Size[1].item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 1;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
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
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Shiled (secondary)";
                            equipment.secondary.item_Durability = 200;
                            equipment.secondary.item_max_number = equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 5;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "L")
                        {
                            equipment.primary.item_name = "Lance";
                            equipment.primary.item_Durability = 200;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Small Shield";
                            equipment.secondary.item_Durability = 150;
                            equipment.secondary.item_max_number = 1;
                            equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 2;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "T")
                        {
                            equipment.primary.item_name = "Tomahawk (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Shield (secondary)";
                            equipment.secondary.item_Durability = 200;
                            equipment.secondary.item_max_number = equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 5;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
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
                            equipment.primary.item_name = "Scepter (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 3;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Elixir";
                            equipment.secondary.item_Durability = 1;
                            equipment.secondary.item_max_number = 20;
                            equipment.secondary.item_number = 10;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 15;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "W")
                        {
                            equipment.primary.item_name = "Wand";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Magic Book";
                            equipment.secondary.item_Durability = 150;
                            equipment.secondary.item_max_number = 1;
                            equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 1;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 25;
                            equipment.secondary.item_Bonus_Mana_Recover = 5;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "G")
                        {
                            equipment.primary.item_name = "Grimoare (main)";
                            equipment.primary.item_Durability = 200;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 2;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 15;
                            equipment.primary.item_Bonus_Mana_Recover = 5;
                            //****************************************//
                            equipment.secondary.item_name = "Elixir";
                            equipment.secondary.item_Durability = 1;
                            equipment.secondary.item_max_number = 20;
                            equipment.secondary.item_number = 10;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 15;
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
                            equipment.primary.item_name = "Sword (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Shield (secondary)";
                            equipment.secondary.item_Durability = 200;
                            equipment.secondary.item_max_number = equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 5;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "K")
                        {
                            equipment.primary.item_name = "Knuckels";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Bandages";
                            equipment.secondary.item_Durability = 1;
                            equipment.secondary.item_max_number = 50;
                            equipment.secondary.item_number = 20;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 5;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "A")
                        {
                            equipment.primary.item_name = "Axe (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Axe (secondary)";
                            equipment.secondary.item_Durability = 100;
                            equipment.secondary.item_max_number = equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 1;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "SC")
                        {
                            equipment.primary.item_name = "Scepter (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 3;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Elixir";
                            equipment.secondary.item_Durability = 1;
                            equipment.secondary.item_max_number = 20;
                            equipment.secondary.item_number = 10;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 15;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "W")
                        {
                            equipment.primary.item_name = "Wand";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Magic Book";
                            equipment.secondary.item_Durability = 150;
                            equipment.secondary.item_max_number = 1;
                            equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 1;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 25;
                            equipment.secondary.item_Bonus_Mana_Recover = 5;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "G")
                        {
                            equipment.primary.item_name = "Grimoare (main)";
                            equipment.primary.item_Durability = 200;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 2;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 15;
                            equipment.primary.item_Bonus_Mana_Recover = 5;
                            //****************************************//
                            equipment.secondary.item_name = "Elixir";
                            equipment.secondary.item_Durability = 1;
                            equipment.secondary.item_max_number = 20;
                            equipment.secondary.item_number = 10;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 15;
                            ok = 1;
                        }
                        else if (choice.ToUpper() == "L")
                        {
                            equipment.primary.item_name = "Lance";
                            equipment.primary.item_Durability = 200;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Small Shield";
                            equipment.secondary.item_Durability = 150;
                            equipment.secondary.item_max_number = 1;
                            equipment.secondary.item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 2;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
                            ok = 1;

                        }
                        else if (choice.ToUpper() == "T")
                        {
                            equipment.primary.item_name = "Tomahawk (main)";
                            equipment.primary.item_Durability = 100;
                            equipment.primary.item_max_number = equipment.primary.item_number = 1;
                            equipment.primary.item_Bonus_Attack = 1;
                            equipment.primary.item_Bonus_Defence = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Heal_Amount = 0;
                            equipment.primary.item_Lifesteal = 0;
                            equipment.primary.item_Bonus_Dodge_Rate = 0;
                            equipment.primary.item_Tenacity = 0;
                            equipment.primary.item_Bonus_Mana = 0;
                            equipment.primary.item_Bonus_Mana_Recover = 0;
                            //****************************************//
                            equipment.secondary.item_name = "Shield (secondary)";
                            equipment.secondary.item_Durability = 200;
                            equipment.secondary.item_max_number = Size[1].item_number = 1;
                            equipment.secondary.item_Bonus_Attack = 0;
                            equipment.secondary.item_Bonus_Defence = 5;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Heal_Amount = 0;
                            equipment.secondary.item_Lifesteal = 0;
                            equipment.secondary.item_Bonus_Dodge_Rate = 0;
                            equipment.secondary.item_Tenacity = 0;
                            equipment.secondary.item_Bonus_Mana = 0;
                            equipment.secondary.item_Bonus_Mana_Recover = 0;
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
        if(player_class == "Warrior" || player_class == "Unspecialized")
        {
            if(type == 1)
            {
                if(loot >= 288 && loot <=295)          //Mithycal gear
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
                    equipment.helmet.item_name = "Helmet Of Never Ending War";
                    equipment.helmet.item_Durability = 9999;
                    equipment.helmet.item_number = 1;
                    equipment.helmet.item_max_number = 1;
                    equipment.helmet.item_Bonus_Attack = 500;
                    equipment.helmet.item_Bonus_Defence = 100;
                    equipment.helmet.item_Heal_Amount = 1000;
                    equipment.helmet.item_Lifesteal = 30;
                    equipment.helmet.item_Bonus_Dodge_Rate = 50;
                    equipment.helmet.item_Tenacity = 100;
                    equipment.helmet.item_Bonus_Mana = 0;
                    equipment.helmet.item_Bonus_Mana_Recover = 0;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Helmet Of Never Ending War";
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
                    equipment.helmet.item_name = "Helmet Of Ever Lasting";
                    equipment.helmet.item_Durability = 9999;
                    equipment.helmet.item_number = 1;
                    equipment.helmet.item_max_number = 1;
                    equipment.helmet.item_Bonus_Attack = 350;
                    equipment.helmet.item_Bonus_Defence = 300;
                    equipment.helmet.item_Heal_Amount = 10000;
                    equipment.helmet.item_Lifesteal = 35;
                    equipment.helmet.item_Bonus_Dodge_Rate = 25;
                    equipment.helmet.item_Tenacity = 90;
                    equipment.helmet.item_Bonus_Mana = 1000;
                    equipment.helmet.item_Bonus_Mana_Recover = 100;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Helmet Of Ever Lastingr";
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
                    equipment.helmet.item_name = " Hat_Of_Infinit_Potential";
                    equipment.helmet.item_Durability = 9999;
                    equipment.helmet.item_number = 1;
                    equipment.helmet.item_max_number = 1;
                    equipment.helmet.item_Bonus_Attack = 500;
                    equipment.helmet.item_Bonus_Defence = 100;
                    equipment.helmet.item_Heal_Amount = 800;
                    equipment.helmet.item_Lifesteal = 15;
                    equipment.helmet.item_Bonus_Dodge_Rate = 50;
                    equipment.helmet.item_Tenacity = 100;
                    equipment.helmet.item_Bonus_Mana = 2000;
                    equipment.helmet.item_Bonus_Mana_Recover = 150;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = " Hat_Of_Infinit_Potential";
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
                    equipment.breastplate.item_name = "Breastplate Of The Mischief";
                    equipment.breastplate.item_Durability = 9999;
                    equipment.breastplate.item_number = 1;
                    equipment.breastplate.item_max_number = 1;
                    equipment.breastplate.item_Bonus_Attack = 200;
                    equipment.breastplate.item_Bonus_Defence = 300;
                    equipment.breastplate.item_Heal_Amount = 2000;
                    equipment.breastplate.item_Lifesteal = 20;
                    equipment.breastplate.item_Bonus_Dodge_Rate = 60;
                    equipment.breastplate.item_Tenacity = 200;
                    equipment.breastplate.item_Bonus_Mana = 0;
                    equipment.breastplate.item_Bonus_Mana_Recover = 0;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Breastplate Of The Mischief";
                    ok = true;
                }
            } while(ok == false);
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
                    equipment.breastplate.item_name = "Breastplate Of The Giants";
                    equipment.breastplate.item_Durability = 9999;
                    equipment.breastplate.item_number = 1;
                    equipment.breastplate.item_max_number = 1;
                    equipment.breastplate.item_Bonus_Attack = 200;
                    equipment.breastplate.item_Bonus_Defence = 500;
                    equipment.breastplate.item_Heal_Amount = 5000;
                    equipment.breastplate.item_Lifesteal = 30;
                    equipment.breastplate.item_Bonus_Dodge_Rate = 60;
                    equipment.breastplate.item_Tenacity = 200;
                    equipment.breastplate.item_Bonus_Mana = 1000;
                    equipment.breastplate.item_Bonus_Mana_Recover = 75;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Breastplate Of The Giants";
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
                    equipment.breastplate.item_name = "Breastplate Of The Phenomenal Evil";
                    equipment.breastplate.item_Durability = 9999;
                    equipment.breastplate.item_number = 1;
                    equipment.breastplate.item_max_number = 1;
                    equipment.breastplate.item_Bonus_Attack = 1000;
                    equipment.breastplate.item_Bonus_Defence = 300;
                    equipment.breastplate.item_Heal_Amount = 2000;
                    equipment.breastplate.item_Lifesteal = 20;
                    equipment.breastplate.item_Bonus_Dodge_Rate = 60;
                    equipment.breastplate.item_Tenacity = 100;
                    equipment.breastplate.item_Bonus_Mana = 3000;
                    equipment.breastplate.item_Bonus_Mana_Recover = 150;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Breastplate Of The Phenomenal Evil";
                    ok = true;
                }
            }while(ok == false);
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
                    equipment.gloves.item_name = "Gloves Of The Slayer";
                    equipment.gloves.item_Durability = 9999;
                    equipment.gloves.item_number = 1;
                    equipment.gloves.item_max_number = 1;
                    equipment.gloves.item_Bonus_Attack = 1000;
                    equipment.gloves.item_Bonus_Defence = 300;
                    equipment.gloves.item_Heal_Amount = 2000;
                    equipment.gloves.item_Lifesteal = 30;
                    equipment.gloves.item_Bonus_Dodge_Rate = 60;
                    equipment.gloves.item_Tenacity = 100;
                    equipment.gloves.item_Bonus_Mana = 0;
                    equipment.gloves.item_Bonus_Mana_Recover = 0;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Gloves Of The Slayer";
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
                    equipment.gloves.item_name = "Gloves Of The Undefeated";
                    equipment.gloves.item_Durability = 9999;
                    equipment.gloves.item_number = 1;
                    equipment.gloves.item_max_number = 1;
                    equipment.gloves.item_Bonus_Attack = 1000;
                    equipment.gloves.item_Bonus_Defence = 300;
                    equipment.gloves.item_Heal_Amount = 2000;
                    equipment.gloves.item_Lifesteal = 30;
                    equipment.gloves.item_Bonus_Dodge_Rate = 60;
                    equipment.gloves.item_Tenacity = 100;
                    equipment.gloves.item_Bonus_Mana = 2000;
                    equipment.gloves.item_Bonus_Mana_Recover = 50;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Gloves Of The Undefeated";
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
            } while (ok == false) ;
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
                    equipment.gloves.item_name = "Gloves Of Infinit Power";
                    equipment.gloves.item_Durability = 9999;
                    equipment.gloves.item_number = 1;
                    equipment.gloves.item_max_number = 1;
                    equipment.gloves.item_Bonus_Attack = 2000;
                    equipment.gloves.item_Bonus_Defence = 300;
                    equipment.gloves.item_Heal_Amount = 1000;
                    equipment.gloves.item_Lifesteal = 30;
                    equipment.gloves.item_Bonus_Dodge_Rate = 60;
                    equipment.gloves.item_Tenacity = 100;
                    equipment.gloves.item_Bonus_Mana = 1000;
                    equipment.gloves.item_Bonus_Mana_Recover = 300;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Gloves Of Infinit Power";
                    ok = true;
                }
            }while (ok == false) ;
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
                    equipment.leggings.item_name = "Leggings Of The Cunning";
                    equipment.leggings.item_Durability = 9999;
                    equipment.leggings.item_number = 1;
                    equipment.leggings.item_max_number = 1;
                    equipment.leggings.item_Bonus_Attack = 800;
                    equipment.leggings.item_Bonus_Defence = 300;
                    equipment.leggings.item_Heal_Amount = 1000;
                    equipment.leggings.item_Lifesteal = 30;
                    equipment.leggings.item_Bonus_Dodge_Rate = 100;
                    equipment.leggings.item_Tenacity = 120;
                    equipment.leggings.item_Bonus_Mana = 0;
                    equipment.leggings.item_Bonus_Mana_Recover = 0;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Leggings Of The Cunning";
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
                    equipment.leggings.item_name = "Leggings Of The Heaven And Earth";
                    equipment.leggings.item_Durability = 9999;
                    equipment.leggings.item_number = 1;
                    equipment.leggings.item_max_number = 1;
                    equipment.leggings.item_Bonus_Attack = 800;
                    equipment.leggings.item_Bonus_Defence = 1000;
                    equipment.leggings.item_Heal_Amount = 2000;
                    equipment.leggings.item_Lifesteal = 10;
                    equipment.leggings.item_Bonus_Dodge_Rate = 100;
                    equipment.leggings.item_Tenacity = 120;
                    equipment.leggings.item_Bonus_Mana = 1000;
                    equipment.leggings.item_Bonus_Mana_Recover = 100;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Leggings Of The Heaven And Earth";
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
                    equipment.leggings.item_name = "Leggings Of The Arcane Sage";
                    equipment.leggings.item_Durability = 9999;
                    equipment.leggings.item_number = 1;
                    equipment.leggings.item_max_number = 1;
                    equipment.leggings.item_Bonus_Attack = 1000;
                    equipment.leggings.item_Bonus_Defence = 100;
                    equipment.leggings.item_Heal_Amount = 1000;
                    equipment.leggings.item_Lifesteal = 10;
                    equipment.leggings.item_Bonus_Dodge_Rate = 100;
                    equipment.leggings.item_Tenacity = 120;
                    equipment.leggings.item_Bonus_Mana = 2000;
                    equipment.leggings.item_Bonus_Mana_Recover = 200;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Leggings Of The Arcane Sage";
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
                    equipment.boots.item_name = "Boots Of The Berseker";
                    equipment.boots.item_Durability = 9999;
                    equipment.boots.item_number = 1;
                    equipment.boots.item_max_number = 1;
                    equipment.boots.item_Bonus_Attack = 800;
                    equipment.boots.item_Bonus_Defence = 300;
                    equipment.boots.item_Heal_Amount = 1000;
                    equipment.boots.item_Lifesteal = 30;
                    equipment.boots.item_Bonus_Dodge_Rate = 100;
                    equipment.boots.item_Tenacity = 120;
                    equipment.boots.item_Bonus_Mana = 0;
                    equipment.boots.item_Bonus_Mana_Recover = 0;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Boots Of The Berseker";
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
                    equipment.boots.item_name = "Boots Of The Atlas";
                    equipment.boots.item_Durability = 9999;
                    equipment.boots.item_number = 1;
                    equipment.boots.item_max_number = 1;
                    equipment.boots.item_Bonus_Attack = 200;
                    equipment.boots.item_Bonus_Defence = 500;
                    equipment.boots.item_Heal_Amount = 800;
                    equipment.boots.item_Lifesteal = 20;
                    equipment.boots.item_Bonus_Dodge_Rate = 100;
                    equipment.boots.item_Tenacity = 120;
                    equipment.boots.item_Bonus_Mana = 1000;
                    equipment.boots.item_Bonus_Mana_Recover = 75;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Boots Of The Atlas";
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
                    equipment.boots.item_name = "Boots Of The Void Walker";
                    equipment.boots.item_Durability = 9999;
                    equipment.boots.item_number = 1;
                    equipment.boots.item_max_number = 1;
                    equipment.boots.item_Bonus_Attack = 800;
                    equipment.boots.item_Bonus_Defence = 300;
                    equipment.boots.item_Heal_Amount = 1000;
                    equipment.boots.item_Lifesteal = 30;
                    equipment.boots.item_Bonus_Dodge_Rate = 100;
                    equipment.boots.item_Tenacity = 120;
                    equipment.boots.item_Bonus_Mana = 1000;
                    equipment.boots.item_Bonus_Mana_Recover = 100;
                    ok = true;
                }
                else if (choice.ToLower() == "k")
                {
                    Size[space].item_name = "Boots Of The Void Walker";
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
