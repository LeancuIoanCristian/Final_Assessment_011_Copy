using System;
using System.Threading;

namespace Final_Assessment_011_Copy
{
    public class Game
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(220, 40);
            int saving_intention = 0;
            string response = " ";
            Console.WriteLine(" Hello Adventurer!\n Have you played this game before? \n 1.[Y]es \n 2.[N]o \n (Please enter the response) \n");
            Player guest = new Player();
            Inventory guest_inventory = new Inventory();
            Loot guest_loot = new Loot();
            Environment environment = new Environment();

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
            environment.Link(guest, guest_inventory, guest_loot);
            environment.Map();
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
    public int player_mana_max;
    public int player_tenacity;
    public int player_armour;
    public int player_attack;
    public int player_health;
    public int player_health_max;
    public int player_base_health;
    public int player_base_mana;
    public int player_base_defence;
    public int player_health_recovery = 1;
    public int score = 0;
    int delay = 3000;
    public void Player_Initialization(int saving_intention)
    {
        if (saving_intention == 1)
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
            while (step == 0)
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
                                while (step == 3)
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
                    player_level = 0;
                    player_experience = 0;
                    player_level_up_requierment = 0;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input:");
                }
            }
            player_health_max = player_health;
            player_base_health = player_health;
            player_mana_max = player_mana;
            player_base_mana = player_mana;
            player_base_defence = player_armour;


        }
    }
    public void LevelUP(int player_experience)
    {
        player_level = player_level++;
        player_level_up_requierment = player_level_up_requierment * 2;
        player_experience = 0;
        player_base_health = player_base_health + 50;
        player_base_mana = player_base_mana * 2;
        player_base_defence = player_base_defence + 5;
    }
}


