using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skogen
{
    class Program
    {
        static void Main(string[] args)
        {

            var animals = new List<Skogen>();
            // Skogen skogen = new Skogen();
            //Skogen skogen1 = new Skogen("Bat", true);
            //Skogen skogen2 = new Skogen("Dolphin", false);
            //Skogen skogen3 = new Skogen("Eagle", false); ;
            animals.Add(new Skogen("Bat", true));
            animals.Add(new Skogen("Wolf", true));
            animals.Add(new Skogen("Dolphin", false));
            animals.Add(new Skogen("Eagle", false));
            animals.Add(new Skogen("Horse", false));
            animals.Add(new Skogen("Cow", false));
            animals.Add(new Skogen("Hayna", true));
            animals.Add(new Skogen("Lion", false));

            //skogen.Animal();
            //skogen.Animal("Bat", true);
            //skogen.Animal;
            //skogen.Animal
            //skogen.Animal
            //skogen.Animal
            //skogen.Animal
            //skogen.Animal
            //animals.Add(skogen.Animal("Wolf", true));
            while (true)
            {
                Console.WriteLine("Pess Q to see the Night Animals.D for Day Animals. And any key to see all the animals: ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                

                foreach (Skogen anime in animals)
                {
                    if (key.KeyChar == 'q')
                    {
                        if (anime.Nature==true)
                        {
                            Console.WriteLine($"{anime.Name} are Hunting for foods...\n");
                        }
                        else 
                        {
                            Console.WriteLine($"{anime.Name} are sleeping\n");
                        }
                        

                    }
                    else if(key.KeyChar=='d')
                    {
                        if (anime.Nature == false)
                        {
                            Console.WriteLine($"{anime.Name} are Hunting for foods...\n");
                        }
                        else
                        {
                            Console.WriteLine($"{anime.Name} are sleeping\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"All the animals in the Forest are: {anime.Name}");
                    }
                    

                }
                //if (key.KeyChar == 'q')
                //{
                //    foreach (Skogen anime in animals)
                //    {
                //        if (anime.Nature == true)
                //        {
                //            Console.WriteLine($" Night animals are: {anime.Name} ");
                //        }

                //    }



                //}
                //if (key.KeyChar == 'd')
                //{
                //    foreach (Skogen anime in animals)
                //    {
                //        if (anime.Nature == false)
                //        {
                //            Console.WriteLine($" Day animals are: {anime.Name} ");
                //        }


                //    }
                //Console.WriteLine($"Animals are {item.Name} and their Nature are {item.Nature}");


            }

            Console.Clear();
            Console.ReadKey();


            
        }
    }

        class Skogen
        {
            public string Name { get; set; }
            public bool Nature { get; set; }

            public Skogen(string name, bool nature)
            {
                this.Name = name;
                this.Nature = nature;
            }

        }

}