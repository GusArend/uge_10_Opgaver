namespace uge_10_Opgaver
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Choose assignment: ");
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						// Opgave 1.1
						{
							int a = 30;
							int b = 25;
							int c = 31;
							int d = 27;

							Console.WriteLine($"{a}\n{b}\n{c}\n{d}");

							double avarage = (double)(a + b + c + d) / 4;
							Console.WriteLine("Middel alder: " + avarage);
						}
						
						break;
					case 2:
						//Opgave 1.2
						{
							int[] ages = [30, 25, 31, 27];
							int sum = 0;
							for (int i = 0; i < ages.Length; i++)
							{
								Console.WriteLine(ages[i]);
								sum += ages[i];
							}
							double avarage = (double)sum / ages.Length;
							Console.WriteLine("Middel alder: " + avarage);
						}
						break;
					case 3:
						// Opgave 1.3
						{
							int[] ages = [30, 25, 31, 27, 0];
							int sum = 0;
							for (int i = 0; i < ages.Length; i++)
							{
								Console.WriteLine(ages[i]);
								sum += ages[i];
							}
							double avarage = (double)sum / ages.Length;
							Console.WriteLine("Middel alder: " + avarage);

							Console.Write("Search for an age: ");
							int search = int.Parse(Console.ReadLine());
							bool isInAraay = false;
							foreach (int age in ages)
							{
								if (age == search)
								{
									isInAraay = true;
									break;
								}
							}
							if (isInAraay) Console.WriteLine($"Age {search} is in the Array.");
							else Console.WriteLine($"Age {search} is NOT in the Array.");
                        }
						break;
						case 4:
						// Opgave 1.4
                        {
                            Console.Write("How many persons? ");
							int numOfPersons = int.Parse(Console.ReadLine());
                            int[] ages = new int[numOfPersons];
							for (int i = 0; i < numOfPersons; i++)
							{
                                Console.Write($"Intast alder for person {i+1}: ");
								int age = int.Parse(Console.ReadLine());
								ages.Append(ages[i] = age);
                            }
                            int sum = 0;
                            for (int i = 0; i < ages.Length; i++)
                            {
                                Console.WriteLine(ages[i]);
                                sum += ages[i];
                            }
                            double avarage = (double)sum / ages.Length;
                            Console.WriteLine("Middel alder: " + avarage);

                            Console.Write("Search for an age: ");
                            int search = int.Parse(Console.ReadLine());
                            bool isInAraay = false;
                            foreach (int age in ages)
                            {
                                if (age == search)
                                {
                                    isInAraay = true;
                                    break;
                                }
                            }
                            if (isInAraay) Console.WriteLine($"Age {search} is in the Array.");
                            else Console.WriteLine($"Age {search} is NOT in the Array.");
                        }
                        break;
                    case 5:
                        // Opgave 1.5
                        {
							try
							{
                                Console.Write("How many persons? ");
                                int numOfPersons = int.Parse(Console.ReadLine());
                                int[] ages = new int[numOfPersons];
                                for (int i = 0; i < numOfPersons; i++)
                                {
                                    Console.Write($"Intast alder for person {i + 1}: ");
                                    int age = int.Parse(Console.ReadLine());
                                    ages.Append(ages[i] = age);
                                }
                                int sum = 0;
                                for (int i = 0; i < ages.Length; i++)
                                {
                                    Console.WriteLine(ages[i]);
                                    sum += ages[i];
                                }
                                double avarage = (double)sum / ages.Length;
                                Console.WriteLine("Middel alder: " + avarage);

                                Console.Write("Search for an age: ");
                                int search = int.Parse(Console.ReadLine());
                                bool isInAraay = false;
                                foreach (int age in ages)
                                {
                                    if (age == search)
                                    {
                                        isInAraay = true;
                                        break;
                                    }
                                }
                                if (isInAraay) Console.WriteLine($"Age {search} is in the Array.");
                                else Console.WriteLine($"Age {search} is NOT in the Array.");
                            } catch (FormatException)
							{
								Console.WriteLine("Enter only numbers!");
							}
                            
                        }
                        break;
                }
				
			}
			
		}
	}
}
