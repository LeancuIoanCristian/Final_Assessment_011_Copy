using System;
using System.IO;

namespace Final_Assessment_011_Copy
{
    //for map generation I used this youtube video as inspiration https://www.youtube.com/watch?v=-8K2Bpzz1ig&t=5399s; credits: Sharp Programming
    public class Environment
    {
        string[,] map = new string[50, 50];
        Random random = new Random();
        bool exit = false;
        int character_Horizontal_Movement;
        int character_Vertical_Movement;
        private const int lenght = 100;
        private const int width = 100;
        char[,] map_Array = new char[lenght, width];
        int rooms_Counter = 1;
        int rooms_Cleared = 0;
        int spawn_x;
        int spawn_y;
        int spawn_witdth;
        int spawn_height;
        int monster_Spawmer;
        int monsters_Born = 0;
        int monster_counter = 0;
        Player guest = new Player();
        Loot guest_loot = new Loot();
        Inventory guest_inventory = new Inventory();
        void Update()
        {
            guest.player_health_max = guest.player_base_health + guest_inventory.equipment.boots.item_Heal_Amount + guest_inventory.equipment.breastplate.item_Heal_Amount + guest_inventory.equipment.gloves.item_Heal_Amount + guest_inventory.equipment.primary.item_Heal_Amount + guest_inventory.equipment.secondary.item_Heal_Amount;
            guest.player_mana_max = guest.player_base_mana + guest_inventory.equipment.boots.item_Bonus_Mana + guest_inventory.equipment.breastplate.item_Bonus_Mana + guest_inventory.equipment.gloves.item_Bonus_Mana + guest_inventory.equipment.primary.item_Bonus_Mana + guest_inventory.equipment.secondary.item_Bonus_Mana;
            guest.player_armour = guest.player_base_defence + guest_inventory.equipment.boots.item_Bonus_Defence + guest_inventory.equipment.breastplate.item_Bonus_Defence + guest_inventory.equipment.gloves.item_Bonus_Defence + guest_inventory.equipment.primary.item_Bonus_Defence + guest_inventory.equipment.secondary.item_Bonus_Defence;
            guest.player_attack = guest_inventory.equipment.boots.item_Bonus_Attack + guest_inventory.equipment.breastplate.item_Bonus_Attack + guest_inventory.equipment.gloves.item_Bonus_Attack + guest_inventory.equipment.primary.item_Bonus_Attack + guest_inventory.equipment.secondary.item_Bonus_Attack;
            guest.player_dodge_rate = guest_inventory.equipment.boots.item_Bonus_Dodge_Rate + guest_inventory.equipment.breastplate.item_Bonus_Dodge_Rate + guest_inventory.equipment.gloves.item_Bonus_Dodge_Rate + guest_inventory.equipment.primary.item_Bonus_Dodge_Rate + guest_inventory.equipment.secondary.item_Bonus_Dodge_Rate;
            guest.player_tenacity = guest_inventory.equipment.boots.item_Tenacity + guest_inventory.equipment.breastplate.item_Tenacity + guest_inventory.equipment.gloves.item_Tenacity + guest_inventory.equipment.primary.item_Tenacity + guest_inventory.equipment.secondary.item_Tenacity;
            guest.player_health_recovery = guest_inventory.equipment.boots.item_Lifesteal + guest_inventory.equipment.breastplate.item_Lifesteal + guest_inventory.equipment.gloves.item_Lifesteal + guest_inventory.equipment.primary.item_Lifesteal + guest_inventory.equipment.secondary.item_Lifesteal;

        }
        public void Link(Player guest, Inventory guest_inventory, Loot guest_loot)
        {
            this.guest = guest;
            this.guest_inventory = guest_inventory;
            this.guest_loot = guest_loot;
        }
        public void Map()
        {
            do
            {
                if (rooms_Cleared != rooms_Counter)
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 0);
                    Console.Write("Score: {0}", guest.score);
                    Console.SetCursorPosition(42, 0);
                    Console.WriteLine("Use the keyboard arrows to move.");
                    Console.SetCursorPosition(42, 2);
                    Console.WriteLine("# -> Door; sends you to the next room");
                    Console.SetCursorPosition(42, 3);
                    Console.WriteLine("M -> monster; kill all of the in order for the door to spawn");
                    Console.SetCursorPosition(42, 4);
                    Console.WriteLine("O -> you, the player");
                    Console.SetCursorPosition(42, 5);
                    Console.WriteLine("_| -> walls");
                    Console.SetCursorPosition(0, 31);
                    Console.Write("Health: {0}/{1}", guest.player_health, guest.player_health_max);
                    Console.SetCursorPosition(29, 31);
                    Console.Write("Mana: {0}/{1}", guest.player_mana, guest.player_mana_max);
                    monster_Spawmer = random.Next(1, 5);
                
                    if (exit == false && rooms_Cleared != rooms_Counter)
                    {

                        int room_Height = random.Next(5, 10);
                        int room_Width = random.Next(5, 20);
                        int spawn_Generator_Width = random.Next(1, 30 - room_Width - 1);
                        int spawn_Generator_Height = random.Next(1, 30 - room_Height - 1);

                        character_Horizontal_Movement = spawn_Generator_Width + 1;
                        character_Vertical_Movement = spawn_Generator_Height + 1;

                        for (int y = 0; y <= room_Height; y++)
                        {
                            for (int x = 0; x <= room_Width; x++)
                            {
                                if (spawn_Generator_Width + room_Width >= 29)
                                {
                                    int horizontal_Centering = spawn_Generator_Width + room_Width - 30;
                                    spawn_Generator_Width = spawn_Generator_Width - horizontal_Centering;
                                }
                                if (spawn_Generator_Height + room_Height >= 29)
                                {
                                    int vertical_Centering = spawn_Generator_Height + room_Height - 30;
                                    spawn_Generator_Height = spawn_Generator_Height - vertical_Centering;
                                }
                                if (y == 0 || y == room_Height)
                                {
                                    map[spawn_Generator_Width + x, spawn_Generator_Height + y] = "_";
                                }
                                else if (x == 0 || x == room_Width)
                                {
                                    map[spawn_Generator_Width + x, spawn_Generator_Height + y] = "|";
                                }
                                else
                                {
                                    if(monsters_Born < monster_Spawmer)
                                    {
                                        int chance = random.Next(1, 100);
                                        if (chance <= 20)
                                        {
                                            map[spawn_Generator_Width + x, spawn_Generator_Height + y] = "M";
                                            monsters_Born++;
                                        }
                                        else
                                        {
                                                map[spawn_Generator_Width + x, spawn_Generator_Height + y] = ".";
                                        }
                                    }
                                    else
                                    {
                                        map[spawn_Generator_Width + x, spawn_Generator_Height + y] = ".";
                                    }
                               
                                }
                            }
                        }
                        spawn_x = room_Width;
                        spawn_y = room_Height;
                        spawn_witdth = spawn_Generator_Width;
                        spawn_height = spawn_Generator_Height;
                    
                    }
                
                    rooms_Cleared++;
                }
           
                if (monster_counter == monster_Spawmer)
                {
                    int room_roll = random.Next(1, 3);
                    if (room_roll == 1)
                    {
                        if (spawn_witdth <= 28)
                        {
                            int character_Spawn = random.Next(1, spawn_y - 1);
                            map[spawn_witdth + 1, spawn_height + 1] = "#";
                        }
                        if (spawn_witdth > 28)
                        {
                            int character_Spawn = random.Next(1, spawn_y - 1);
                            map[spawn_witdth, spawn_height + 1] = "#";
                        }
                    }
                    else if (room_roll == 2)
                    {
                        if (spawn_height > 28)
                        {
                            int character_Spawn = random.Next(1, spawn_x - 1);
                            map[spawn_witdth, spawn_height + 1] = "#";
                        }
                        if (spawn_height > 28)
                        {
                            int character_Spawn = random.Next(1, spawn_x - 1);
                            map[spawn_witdth, spawn_height + 1] = "#";
                        }
                    }             
                }
               
                for (int height_Signs = 0; height_Signs <= 28; height_Signs++)
                {
                    for (int width_Signs = 0; width_Signs <= 28; width_Signs++)
                    {
                        Console.SetCursorPosition(height_Signs, width_Signs);
                        Console.Write(map[height_Signs, width_Signs]);
                    }
                }

                ConsoleKeyInfo pressedKey;
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        {
                            Console.SetCursorPosition(0, 33);
                            Console.WriteLine("(!)Are you sure you want to leave?\n[Y]es/[N]o\n");
                            int agreement = 1;
                            string answer;
                            do
                            {
                                answer = Console.ReadLine();
                                if (answer.ToUpper() == "Y")
                                {
                                    exit = true;
                                    agreement = 1;
                                }
                                else if (answer.ToUpper() == "N")
                                {
                                    agreement = 2;
                                }
                                else
                                {
                                    Console.WriteLine("Please emter a valid answer\n");
                                }
                            } while (agreement == 0);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        {

                            if (character_Vertical_Movement > 0)
                            {
                                if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "_" || map[character_Horizontal_Movement, character_Vertical_Movement - 1] == null)
                                { }
                                else if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "M")
                                {
                                    Console.SetCursorPosition(42, 10);
                                    Console.WriteLine("You have encountered a monster. You have to defeat it so you can go further.");
                                    int monster_health;
                                    int monster_attack;
                                    int monster_defence;
                                    if (rooms_Cleared % 10 == 0)
                                    {
                                        monster_health = 100 + 50 * (rooms_Cleared / 10);
                                        monster_attack = 2 + 5 * (rooms_Cleared / 10);
                                        monster_defence = 0 + 2 * (rooms_Cleared / 10);
                                    }
                                    else
                                    {
                                        int temp = rooms_Cleared;
                                        if(temp % 10 <= 5)
                                        {
                                            monster_health = 100 + 50 * (temp - (rooms_Cleared % 10));
                                            monster_attack = 2 + 5 * (temp - (rooms_Cleared % 10));
                                            monster_defence = 0 + 2 * (temp - (rooms_Cleared % 10));
                                        }
                                        else
                                        {
                                            monster_health = 100 + 50 * (temp +(10 - (rooms_Cleared % 10)));
                                            monster_attack = 2 + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_defence = 0 + 2 * (temp + (10 - (rooms_Cleared % 10)));
                                        }
                                    }
                                    while(monster_health > 0 && guest.player_health > 0)
                                    {
                                        string action;
                                        Console.SetCursorPosition(42, 12);
                                        Console.WriteLine("Chose an action:");
                                        if (guest.player_class == "Unspecialized" || guest.player_class == "Tank" || guest.player_class == "Mage")
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     [M]agic Attack");
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     ");
                                        }
                                        Console.SetCursorPosition(42, 14);
                                        Console.WriteLine("[D]efend              [H]eal");
                                        action = Console.ReadLine();
                                        if (action.ToUpper() == "P")
                                        {
                                            monster_health = monster_health - (guest.player_attack - monster_defence);
                                            Console.SetCursorPosition(42, 16);
                                            Console.WriteLine("You have dameged the monster for: " + (guest.player_attack - monster_defence));
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if(guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }
                                        
                                        }
                                        else if (action.ToUpper() == "M")
                                        {
                                            if (guest.player_mana >= 75)
                                            {
                                                monster_health = monster_health - ((guest.player_attack - monster_defence) * 2);
                                                guest.player_mana = guest.player_mana - 75;
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have consumed 75 mana and dameged the monster for: " + ((guest.player_attack - monster_defence) * 2));
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You failed to make a magic attack. You didn't have enough mana");
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "D")
                                        {
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                                else
                                                {
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - (guest.player_armour * 2)));
                                                }
                                            }
                                        }
                                        else if (action.ToUpper() == "H")
                                        {
                                            int dodge = random.Next(1, 500);
                                            if (dodge > guest.player_dodge_rate)
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have healed for: " + (50 + guest.player_health_recovery));
                                                guest.player_health = guest.player_health + (50 + guest.player_health_recovery);
                                                if (guest.player_health > guest.player_health_max)
                                                {
                                                    guest.player_health = guest.player_health_max;
                                                }
                                                guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                Console.SetCursorPosition(42, 17);
                                                Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                        }
                                    }
                                    if(guest.player_health > 0)
                                    {
                                        monster_counter++;
                                        character_Vertical_Movement--;
                                        map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                        map[character_Horizontal_Movement, character_Vertical_Movement + 1] = ".";
                                    }
                                    else
                                    {
                                        exit = true;
                                        Console.Clear();
                                        Console.WriteLine("Game Over!");
                                    }
                                    guest_loot.Loot_Generator(guest.player_class);
                                    Update();
                                }
                            
                                else
                                {
                                    character_Vertical_Movement--;
                                    map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                    map[character_Horizontal_Movement, character_Vertical_Movement + 1] = ".";
                                }
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (character_Vertical_Movement < 28)
                            {
                                if (map[character_Horizontal_Movement, character_Vertical_Movement + 1] == "_" || map[character_Horizontal_Movement, character_Vertical_Movement + 1] == null)
                                { }
                                if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "_" || map[character_Horizontal_Movement, character_Vertical_Movement - 1] == null)
                                { }
                                else if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "M")
                                {
                                    Console.SetCursorPosition(42, 10);
                                    Console.WriteLine("You have encountered a monster. You have to defeat it so you can go further.");
                                    int monster_health;
                                    int monster_attack;
                                    int monster_defence;
                                    if (rooms_Cleared % 10 == 0)
                                    {
                                        monster_health = 100 + 50 * (rooms_Cleared / 10);
                                        monster_attack = 2 + 5 * (rooms_Cleared / 10);
                                        monster_defence = 0 + 2 * (rooms_Cleared / 10);
                                    }
                                    else
                                    {
                                        int temp = rooms_Cleared;
                                        if (temp % 10 <= 5)
                                        {
                                            monster_health = 100 + 50 * (temp - (rooms_Cleared % 10));
                                            monster_attack = 2 + 5 * (temp - (rooms_Cleared % 10));
                                            monster_defence = 0 + 2 * (temp - (rooms_Cleared % 10));
                                        }
                                        else
                                        {
                                            monster_health = 100 + 50 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_attack = 2 + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_defence = 0 + 2 * (temp + (10 - (rooms_Cleared % 10)));
                                        }
                                    }
                                    while (monster_health > 0 && guest.player_health > 0)
                                    {
                                        string action;
                                        Console.SetCursorPosition(42, 12);
                                        Console.WriteLine("Chose an action:");
                                        if (guest.player_class == "Unspecialized" || guest.player_class == "Tank" || guest.player_class == "Mage")
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     [M]agic Attack");
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     ");
                                        }
                                        Console.SetCursorPosition(42, 14);
                                        Console.WriteLine("[D]efend              [H]eal");
                                        action = Console.ReadLine();
                                        if (action.ToUpper() == "P")
                                        {
                                            monster_health = monster_health - (guest.player_attack - monster_defence);
                                            Console.SetCursorPosition(42, 16);
                                            Console.WriteLine("You have dameged the monster for: " + (guest.player_attack - monster_defence));
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "M")
                                        {
                                            if (guest.player_mana >= 75)
                                            {
                                                monster_health = monster_health - ((guest.player_attack - monster_defence) * 2);
                                                guest.player_mana = guest.player_mana - 75;
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have consumed 75 mana and dameged the monster for: " + ((guest.player_attack - monster_defence) * 2));
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You failed to make a magic attack. You didn't have enough mana");
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "D")
                                        {
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                                else
                                                {
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - (guest.player_armour * 2)));
                                                }
                                            }
                                        }
                                        else if (action.ToUpper() == "H")
                                        {
                                            int dodge = random.Next(1, 500);
                                            if (dodge > guest.player_dodge_rate)
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have healed for: " + (50 + guest.player_health_recovery));
                                                guest.player_health = guest.player_health + (50 + guest.player_health_recovery);
                                                if (guest.player_health > guest.player_health_max)
                                                {
                                                    guest.player_health = guest.player_health_max;
                                                }
                                                guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                Console.SetCursorPosition(42, 17);
                                                Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                        }
                                    }
                                    if (guest.player_health > 0)
                                    {
                                        monster_counter++;
                                        character_Vertical_Movement++;
                                        map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                        map[character_Horizontal_Movement, character_Vertical_Movement - 1] = ".";
                                    }
                                    else
                                    {
                                        exit = true;
                                        Console.Clear();
                                        Console.WriteLine("Game Over!");
                                    }
                                    Update();
                                }
                                else
                                {
                                    character_Vertical_Movement++;
                                    map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                    map[character_Horizontal_Movement, character_Vertical_Movement - 1] = ".";
                                }
                            }
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        {
                            if (character_Horizontal_Movement > 1)
                            {
                                if (map[character_Horizontal_Movement - 1, character_Vertical_Movement] == "|" || map[character_Horizontal_Movement - 1, character_Vertical_Movement] == null)
                                { }
                                if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "_" || map[character_Horizontal_Movement, character_Vertical_Movement - 1] == null)
                                { }
                                else if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "M")
                                {
                                    Console.SetCursorPosition(42, 10);
                                    Console.WriteLine("You have encountered a monster. You have to defeat it so you can go further.");
                                    int monster_health;
                                    int monster_attack;
                                    int monster_defence;
                                    if (rooms_Cleared % 10 == 0)
                                    {
                                        monster_health = 100 + 50 * (rooms_Cleared / 10);
                                        monster_attack = 2 + 5 * (rooms_Cleared / 10);
                                        monster_defence = 0 + 2 * (rooms_Cleared / 10);
                                    }
                                    else
                                    {
                                        int temp = rooms_Cleared;
                                        if (temp % 10 <= 5)
                                        {
                                            monster_health = 100 + 50 * (temp - (rooms_Cleared % 10));
                                            monster_attack = 2 + 5 * (temp - (rooms_Cleared % 10));
                                            monster_defence = 0 + 2 * (temp - (rooms_Cleared % 10));
                                        }
                                        else
                                        {
                                            monster_health = 100 + 50 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_attack = 2 + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_defence = 0 + 2 * (temp + (10 - (rooms_Cleared % 10)));
                                        }
                                    }
                                    while (monster_health > 0 && guest.player_health > 0)
                                    {
                                        string action;
                                        Console.SetCursorPosition(42, 12);
                                        Console.WriteLine("Chose an action:");
                                        if (guest.player_class == "Unspecialized" || guest.player_class == "Tank" || guest.player_class == "Mage")
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     [M]agic Attack");
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     ");
                                        }
                                        Console.SetCursorPosition(42, 14);
                                        Console.WriteLine("[D]efend              [H]eal");
                                        action = Console.ReadLine();
                                        if (action.ToUpper() == "P")
                                        {
                                            monster_health = monster_health - (guest.player_attack - monster_defence);
                                            Console.SetCursorPosition(42, 16);
                                            Console.WriteLine("You have dameged the monster for: " + (guest.player_attack - monster_defence));
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "M")
                                        {
                                            if (guest.player_mana >= 75)
                                            {
                                                monster_health = monster_health - ((guest.player_attack - monster_defence) * 2);
                                                guest.player_mana = guest.player_mana - 75;
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have consumed 75 mana and dameged the monster for: " + ((guest.player_attack - monster_defence) * 2));
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You failed to make a magic attack. You didn't have enough mana");
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "D")
                                        {
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                                else
                                                {
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - (guest.player_armour * 2)));
                                                }
                                            }
                                        }
                                        else if (action.ToUpper() == "H")
                                        {
                                            int dodge = random.Next(1, 500);
                                            if (dodge > guest.player_dodge_rate)
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have healed for: " + (50 + guest.player_health_recovery));
                                                guest.player_health = guest.player_health + (50 + guest.player_health_recovery);
                                                if (guest.player_health > guest.player_health_max)
                                                {
                                                    guest.player_health = guest.player_health_max;
                                                }
                                                guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                Console.SetCursorPosition(42, 17);
                                                Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                        }
                                    }
                                    if (guest.player_health > 0)
                                    {
                                        monster_counter++;
                                        character_Vertical_Movement--;
                                        map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                        map[character_Horizontal_Movement+ 1, character_Vertical_Movement] = ".";
                                    }
                                    else
                                    {
                                        exit = true;
                                        Console.Clear();
                                        Console.WriteLine("Game Over!");
                                    }
                                    Update();
                                }
                                else
                                {
                                    character_Horizontal_Movement--;
                                    map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                    map[character_Horizontal_Movement + 1, character_Vertical_Movement] = ".";
                                }
                            }
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        {
                            if (character_Horizontal_Movement < 28)
                            {
                                if (map[character_Horizontal_Movement + 1, character_Vertical_Movement] == "|" || map[character_Horizontal_Movement + 1, character_Vertical_Movement] == null)
                                { }
                                if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "_" || map[character_Horizontal_Movement, character_Vertical_Movement - 1] == null)
                                { }
                                else if (map[character_Horizontal_Movement, character_Vertical_Movement - 1] == "M")
                                {
                                    Console.SetCursorPosition(42, 10);
                                    Console.WriteLine("You have encountered a monster. You have to defeat it so you can go further.");
                                    int monster_health;
                                    int monster_attack;
                                    int monster_defence;
                                    if (rooms_Cleared % 10 == 0)
                                    {
                                        monster_health = 100 + 50 * (rooms_Cleared / 10);
                                        monster_attack = 2 + 5 * (rooms_Cleared / 10);
                                        monster_defence = 0 + 2 * (rooms_Cleared / 10);
                                    }
                                    else
                                    {
                                        int temp = rooms_Cleared;
                                        if (temp % 10 <= 5)
                                        {
                                            monster_health = 100 + 50 * (temp - (rooms_Cleared % 10));
                                            monster_attack = 2 + 5 * (temp - (rooms_Cleared % 10));
                                            monster_defence = 0 + 2 * (temp - (rooms_Cleared % 10));
                                        }
                                        else
                                        {
                                            monster_health = 100 + 50 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_attack = 2 + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                            monster_defence = 0 + 2 * (temp + (10 - (rooms_Cleared % 10)));
                                        }
                                    }
                                    while (monster_health > 0 && guest.player_health > 0)
                                    {
                                        string action;
                                        Console.SetCursorPosition(42, 12);
                                        Console.WriteLine("Chose an action:");
                                        if (guest.player_class == "Unspecialized" || guest.player_class == "Tank" || guest.player_class == "Mage")
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     [M]agic Attack");
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(42, 13);
                                            Console.WriteLine("[P]hysical Attack     ");
                                        }
                                        Console.SetCursorPosition(42, 14);
                                        Console.WriteLine("[D]efend              [H]eal");
                                        action = Console.ReadLine();
                                        if (action.ToUpper() == "P")
                                        {
                                            monster_health = monster_health - (guest.player_attack - monster_defence);
                                            Console.SetCursorPosition(42, 16);
                                            Console.WriteLine("You have dameged the monster for: " + (guest.player_attack - monster_defence));
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "M")
                                        {
                                            if (guest.player_mana >= 75)
                                            {
                                                monster_health = monster_health - ((guest.player_attack - monster_defence) * 2);
                                                guest.player_mana = guest.player_mana - 75;
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have consumed 75 mana and dameged the monster for: " + ((guest.player_attack - monster_defence) * 2));
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You failed to make a magic attack. You didn't have enough mana");
                                                if (monster_health > 0)
                                                {
                                                    int dodge = random.Next(1, 500);
                                                    if (dodge > guest.player_dodge_rate)
                                                    {
                                                        guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                    }
                                                    else
                                                    {
                                                        Console.SetCursorPosition(42, 16);
                                                        Console.WriteLine("You have dodged");
                                                    }
                                                }
                                            }
                                            int temp = rooms_Cleared;
                                            if (temp % 10 <= 5)
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp - (rooms_Cleared % 10));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            else
                                            {
                                                guest.player_experience = guest.player_experience + 5 * (temp + (10 - (rooms_Cleared % 10)));
                                                if (guest.player_experience == guest.player_level_up_requierment)
                                                {
                                                    Console.SetCursorPosition(42, 17);
                                                    Console.WriteLine("you have leveled up");
                                                    guest.LevelUP(guest.player_experience);
                                                }
                                            }
                                            for (int x = 12; x < 17; x++)
                                            {
                                                Console.SetCursorPosition(42, x);
                                                Console.WriteLine();
                                            }

                                        }
                                        else if (action.ToUpper() == "D")
                                        {
                                            if (monster_health > 0)
                                            {
                                                int dodge = random.Next(1, 500);
                                                if (dodge > guest.player_dodge_rate)
                                                {
                                                    guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                                }
                                                else
                                                {
                                                    Console.SetCursorPosition(42, 16);
                                                    Console.WriteLine("You have been dameged for: " + (monster_attack - (guest.player_armour * 2)));
                                                }
                                            }
                                        }
                                        else if (action.ToUpper() == "H")
                                        {
                                            int dodge = random.Next(1, 500);
                                            if (dodge > guest.player_dodge_rate)
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have healed for: " + (50 + guest.player_health_recovery));
                                                guest.player_health = guest.player_health + (50 + guest.player_health_recovery);
                                                if (guest.player_health > guest.player_health_max)
                                                {
                                                    guest.player_health = guest.player_health_max;
                                                }
                                                guest.player_health = guest.player_health - (monster_attack - guest.player_armour);
                                                Console.SetCursorPosition(42, 17);
                                                Console.WriteLine("You have been dameged for: " + (monster_attack - guest.player_armour));
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(42, 16);
                                                Console.WriteLine("You have dodged");
                                            }
                                        }
                                    }
                                    if (guest.player_health > 0)
                                    {
                                        monster_counter++;
                                        character_Vertical_Movement++;
                                        map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                        map[character_Horizontal_Movement - 1, character_Vertical_Movement ] = ".";
                                    }
                                    else
                                    {
                                        exit = true;
                                        Console.Clear();
                                        Console.WriteLine("Game Over!");
                                    }
                                    Update();
                                }
                                else
                                {
                                    character_Horizontal_Movement++;
                                    map[character_Horizontal_Movement, character_Vertical_Movement] = "O";
                                    map[character_Horizontal_Movement - 1, character_Vertical_Movement] = ".";
                                }
                            }
                        }
                        break;
                }
                
                
             


                            
                
            } while (exit == false);

        }
    }
}