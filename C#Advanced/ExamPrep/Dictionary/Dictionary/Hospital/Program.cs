using System;
using System.Collections.Generic;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var Doctors = new Dictionary<string, List<string>>();
            var Hospitals = new Dictionary<string, List<string>>();
            var patients = new List<string>();


            string[] patientsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (patientsInput[0] != "Output")
            {
                if (!Hospitals.ContainsKey(patientsInput[0]))
                {
                    Hospitals[patientsInput[0]] = new List<string>();
                    Hospitals[patientsInput[0]].Add(patientsInput[3]);
                }
                else
                {
                    Hospitals[patientsInput[0]].Add(patientsInput[3]);
                }
                string doctor = patientsInput[1] + " " + patientsInput[2];

                if (!Doctors.ContainsKey(doctor))
                {
                    Doctors[doctor] = new List<string>();
                    Doctors[doctor].Add(patientsInput[3]);
                }
                else
                {
                    Doctors[doctor].Add(patientsInput[3]);
                }


                patientsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string[] Command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (Command[0] != "End")
            {
                if (Command.Length == 1)
                {
                    if (Hospitals[Command[0]].Count <= 60)
                    {
                        foreach (var patient in Hospitals[Command[0]])
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 60; i++)
                        {
                            Console.WriteLine(Hospitals[Command[0]][i]);
                        }
                    }

                }
                else
                {
                    if (Command[1].Length < 3)
                    {
                        int roomNumber = int.Parse(Command[1]);
                        if (roomNumber <= 20 && roomNumber >= 1)
                        {
                            int startindex = roomNumber * 3 - 3;
                            var room = new List<string>();
                            for (int i = startindex; i < startindex + 3; i++)
                            {
                                room.Add(Hospitals[Command[0]][i]);
                            }
                            room.Sort();
                            foreach (var patient in room)
                            {
                                Console.WriteLine(patient);
                            }
                        }

                    }
                    else
                    {
                        string doctor = Command[0] + " " + Command[1];
                        var PatientsDoctor = new List<string>();
                        foreach (var patient in Doctors[doctor])
                        {
                            PatientsDoctor.Add(patient);
                        }
                        PatientsDoctor.Sort();
                        foreach (var patient in PatientsDoctor)
                        {
                            Console.WriteLine(patient);
                        }
                    }

                }

                Command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}