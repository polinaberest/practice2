using System;
using System.Collections.Generic;
using System.Linq;

namespace parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Text: file.txt(6B); Some string content
            Image: img.bmp(19MB); 1920х1080
            Text:data.txt(12B); Another string
            Text:data1.txt(7B); Yet another string
            Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";

            string[] preProceededArr = InitialParser(text);
            string[] postProceededArr;
            var movieList = new List<Movie>();
            var imagesList = new List<Image>();
            var textFilesList = new List<TextFile>();


            for (int i = 0; i < preProceededArr.Length; i++)
            {
                if (preProceededArr[i].Contains(".txt"))
                {
                    postProceededArr = GetData(preProceededArr[i]);
                    var textFile = new TextFile(postProceededArr[0], postProceededArr[1], postProceededArr[2]);
                    textFilesList.Add(textFile);
                }
                else if (preProceededArr[i].Contains(".bmp"))
                {
                    postProceededArr = GetData(preProceededArr[i]);
                    var image = new Image(postProceededArr[0], postProceededArr[1], postProceededArr[2]);
                    imagesList.Add(image);
                }
                else if (preProceededArr[i].Contains(".mkv"))
                {
                    postProceededArr = GetData(preProceededArr[i]);
                    var movie = new Movie(postProceededArr[0], postProceededArr[1], postProceededArr[2], postProceededArr[3]);
                    movieList.Add(movie);
                }

            }
            List<Movie> sortedMovie = movieList.OrderByDescending(m => m.Size).ToList();
            List<TextFile> sortedText = textFilesList.OrderByDescending(f => f.Size).ToList();
            List<Image> sortedImages = imagesList.OrderByDescending(i => i.Size).ToList();

        }

        

        static string[] InitialParser(string text)
        {
            string[] separator = { "Text:", "Image:", "Movie:" };
            return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }

        static string[] GetData(string item)
        {
            string[] separator = { "(", "); " , "; " };
            return item.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
