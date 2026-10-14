using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace citUps
{
    internal class ParkingSystemManager
    {
        public char Slot { get; private set; }
        public bool Free { get; private set; }
      
        public ParkingSystemManager(char slot_name,bool free)
        {
            Slot = slot_name;
            Free = free;
            
        }
        static List<ParkingSystemManager> slots = new List<ParkingSystemManager>();
        public class User

        {
            public string Name { get; private set; }
            public char Slot { get; private set; }
            
            public int Hours { get; private set; }
            public User(string name , char slot_name,int hours)
            {
                Name = name;
                Slot = slot_name;
                
                Hours = hours;
            }
        }
        static List<User> users = new List<User>();

        public void CreateSlots()
        {
            try
            {
                Console.WriteLine("Enter the slot name: ");
                char slot_name = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("occupied ? true or false ?");
                bool occupied = bool.Parse(Console.ReadLine());
                ParkingSystemManager new_slot = new ParkingSystemManager(slot_name, occupied);
                slots.Add(new_slot);
                Console.WriteLine("Successfully added slots");
                return;
            }catch(Exception e)
            {
                Console.Write(e.Message);
            }
            return;
            
        }

        public void CheckSlots()
        {
            Console.WriteLine("Do u wanna view all slots ? Y or N");
            char t = Convert.ToChar(Console.ReadLine());
            if (t == 'N'||t=='n')
            {
                Console.Write("Kindly provide the slot that u want to check ? : ");
                char s = Convert.ToChar(Console.ReadLine());
                ParkingSystemManager h = slots.Find(a => a.Slot == s);
                if (h != null)
                {
                    Console.Write(h.Free);
                    return;
                }
            }
            else
            {
                for(int i = 0; i < slots.Count; ++i)
                {
                    Console.WriteLine(slots[i]);
                }
                return;
            }
        }

        public void BookSlots()
        {
            Console.WriteLine("Do u wanna view slots or book directly ? ");
            char y = Convert.ToChar(Console.ReadLine());
            if (y == 'Y')
            {
                CheckSlots();
            }
            else
            {
                Console.Write("Enter the slot name that u intent to book ? : ");
                char m = Convert.ToChar(Console.ReadLine());
                ParkingSystemManager slot = slots.Find(a => a.Slot == m);
                if (slot != null)
                {
                    if (slot.Free == true)
                    {
                        slot.Free = false;
                        Console.Write("Enter ur name ? : ");
                        string name = Console.ReadLine();
                        Console.Write("Enter how many hours u want to park ?");
                        int h = Convert.ToInt16(Console.ReadLine());
                        User user = new User(name, m, h);
                        users.Add(user);

                    }
                    else
                    {
                        Console.WriteLine("Your slot is unavailable !");
                    }
                }
            }
        }

        public void ParkingService()
        {
            Console.WriteLine("Welcome , Parking space management , here u could book ur slots easily");
            while (true)
            {
                Console.Write("Enter the service , that u are in need of ? ");
                Console.WriteLine("1.Create Account 2. check slots 3.BookSlot 4.Exit service");
                int s = Convert.ToInt16(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        CreateSlots();
                        break;
                    case 2:
                        CheckSlots();
                        break;
                    case 3:
                        BookSlots();
                        break;
                    case 4:
                        return;
                    

                }   

                }
            }
        
        }

    }

