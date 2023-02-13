using System;
using System.Collections.Generic;

namespace EXERCISES3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tran Dinh Khanh _ 20IT271_ 20MC";
            Console.WriteLine("Nhap so bai");
           int numSongs = int.Parse(Console.ReadLine());    
            List<Song> songs = new List<Song>();

            for(int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song s = new Song();

                s.TypeList = type;
                s.Name = name;
                s.Time = time;
                
                songs.Add(s);
            }

            Console.WriteLine("Nhap so bai hat trong danh sach");
            string typenumber = Console.ReadLine(); 

            if(typenumber == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(var song in songs)
                {
                    if(song.TypeList == typenumber)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
