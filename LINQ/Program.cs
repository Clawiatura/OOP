using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//33 2
//class Movie
//{
//    public string Title { get; set; }
//    public string ReleaseDate { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var movies = new List<Movie>();
//        var lines = File.ReadAllLines("Movies.csv");

//        foreach (var line in lines.Skip(1)) 
//        {
//            var parts = line.Split(',');
//            var movie = new Movie
//            {
//                Title = parts[0],
//                ReleaseDate = parts[2]
//            };
//            movies.Add(movie);
//        }

//        var sortedMovies = movies.OrderByDescending(m => m.ReleaseDate).ToList();

//        foreach (var movie in sortedMovies) 

//        {
//            Console.WriteLine($"Title: {movie.Title}, Release Date: {movie.ReleaseDate}");
//        }
//    }
//}

// 33 1
class Good
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        var movies = new List<Good>();
        var lines = File.ReadAllLines("inventoryControl.csv");

        foreach (var line in lines.Skip(1))
        {
            var parts = line.Split(',');
            var movie = new Good
            {
                Name = parts[0],
                Quantity = int.Parse(parts[1])
            };
            movies.Add(movie);
        }
        var scores = movies.Where(s => s.Quantity % 2 == 0).ToList();        
        foreach (var line in scores)
        {
            Console.WriteLine($"Name: {line.Name}, Quantity: {line.Quantity}");
        }

    }
}

