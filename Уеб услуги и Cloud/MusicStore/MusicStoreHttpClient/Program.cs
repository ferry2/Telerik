using System.Linq;

namespace MusicStoreHttpClient
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using MusicStore.Models;    

    class Program
    {
        static string baseUrl = "http://localhost:61876/api";

        static void Main()
        {
            ClientRequest reqConsumer = new ClientRequest(baseUrl);
            
            while (true)
            {
                PrintMenu();
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    string inputLine = readLine.ToLower();

                    if (inputLine == "4")
                    {
                        break;
                    }

                    ExecuteMenuChoice(inputLine, reqConsumer);
                }

                PrintEndOperationsCycle();
            }
        }

        static void ExecuteMenuChoice(string inputChoice, ClientRequest clientRequest)
        {
            switch (inputChoice)
            {
                case "1":
                    {
                        const string controller = "/artists";
                        PrintCurrentPath(controller);

                        PrintCrudOperationsChoices();
                        inputChoice = Console.ReadLine();

                        ExecuteCrudChoice(inputChoice, clientRequest, controller, EnterArtist, UpdateArtist);
                    }
                    break;
                case "2":
                    {
                        const string controller = "/albums";

                        PrintCurrentPath(controller);

                        PrintCrudOperationsChoices();

                        inputChoice = Console.ReadLine();

                        ExecuteCrudChoice(inputChoice, clientRequest, controller, EnterAlbum, UpdateAlbum);
                    } break;
                case "3":
                    {
                        const string controller = "/songs";

                        PrintCurrentPath(controller);

                        PrintCrudOperationsChoices();

                        inputChoice = Console.ReadLine();

                        ExecuteCrudChoice(inputChoice, clientRequest, controller, EnterSong, UpdateSong);
                    } break;

                default: Console.WriteLine("Error, incorrect digit."); break;
            }
        }

        static void ExecuteCrudChoice(string inputChoice, ClientRequest clientRequest, string controller,
            Func<ClientRequest, string, string> createEntry, Func<ClientRequest, string, string> updateEntry)
        {
            switch (inputChoice)
            {
                case "1":
                    {
                        var sent = createEntry(clientRequest, controller);
                        Console.WriteLine(sent);
                    }
                    break;
                case "2":
                    {
                        var recieved = clientRequest.Read(controller);
                        Console.WriteLine(recieved);
                    }
                    break;
                case "3":
                    {
                        var recieved = updateEntry(clientRequest, controller);
                        Console.WriteLine(recieved);
                    }
                    break;
                case "4":
                    {
                        Console.Write("Enter id: ");
                        var inputId = int.Parse(Console.ReadLine());
                        var recieved = clientRequest.Delete(controller, inputId.ToString());
                        Console.WriteLine("Deleted: \n{0}", recieved);
                    }
                    break;
                case "5":
                    {
                        Console.Write("Enter id: ");
                        var inputId = int.Parse(Console.ReadLine());
                        var recieved = clientRequest.Read(controller, inputId.ToString());
                        Console.WriteLine(recieved);
                    }
                    break;
                default: Console.WriteLine("Error, incorrect digit."); break;
            }
        }

        private static string UpdateArtist(ClientRequest clientRequest, string controller)
        {
            Console.Write("Enter id: ");
            var inputId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter country(optional): ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter birth date(optional): ");
            DateTime? date = null;
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            ArtistModel artist = new ArtistModel()
            {
                ArtistId = inputId,
                Name = name,
                Country = country,
                DateOfBirth = date
            };

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = clientRequest.UpdateAsJson<ArtistModel>(artist, controller, inputId.ToString());
                return sent;
            }
            else
            {
                var sent = clientRequest.UpdateAsXml<ArtistModel>(artist, controller, inputId.ToString());
                return sent;
            }
        }

        private static string EnterArtist(ClientRequest clientRequest, string controller)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter country(optional): ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter birth date(optional): ");
            DateTime? date = null;
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            ArtistModel artist = CreateArtistObject(0, name, country, date);

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = clientRequest.CreateAsJson<ArtistModel>(artist, controller);
                return sent;
            }
            else
            {
                var sent = clientRequest.CreateAsXml<ArtistModel>(artist, controller);
                return sent;
            }
        }

        private static ArtistModel CreateArtistObject(int id, string name, string country, DateTime? date)
        {
            ArtistModel artist = new ArtistModel()
            {
                ArtistId = id,
                Name = name,
                Country = country,
                DateOfBirth = date
            };
            return artist;
        }

        private static string EnterAlbum(ClientRequest clientRequest, string controller)
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter producer(optional): ");
            string producer = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            AlbumModel album = new AlbumModel()
            {
                Title = title,
                Producer = producer,
                ReleaseDate = releaseDate,
            };

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = clientRequest.CreateAsJson<AlbumModel>(album, controller);
                return sent;
            }
            else
            {
                var sent = clientRequest.CreateAsXml<AlbumModel>(album, controller);
                return sent;
            }
        }

        private static string UpdateAlbum(ClientRequest clientRequest, string controller)
        {
            Console.Write("Enter id: ");
            var inputId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter producer(optional): ");
            string producer = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            Console.WriteLine("Artist Name(optional): ");
            string artistName = Console.ReadLine();


            MusicStoreDb db = new MusicStoreDb();

            var artist = (from a in db.Artists
                          where a.Name == artistName
                          select a
                        ).ToList();

            AlbumModel album;

            if (false)
            {
                album = new AlbumModel()
                {
                    AlbumId = inputId,
                    Title = title,
                    Producer = producer,
                    ReleaseDate = releaseDate
                };
            }
            else
            {
                List<ArtistModel> artists = new List<ArtistModel>();
                foreach (var art in artist)
                {
                    artists.Add(CreateArtistObject(artist[0].ArtistId, artist[0].Name, artist[0].Country, artist[0].DateOfBirth));
                }

                album = new AlbumModel()
                {
                    AlbumId = inputId,
                    Title = title,
                    Producer = producer,
                    ReleaseDate = releaseDate,
                    Artists = artists
                };
            }

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = clientRequest.UpdateAsJson<AlbumModel>(album, controller, inputId.ToString());
                return sent;
            }
            else
            {
                var sent = clientRequest.UpdateAsXml<AlbumModel>(album, controller, inputId.ToString());
                return sent;
            }
        }

        private static string EnterSong(ClientRequest clientRequest, string controller)
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter genre(optional): ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            MusicStoreDb db = new MusicStoreDb();

            Console.WriteLine("Artist Name(optional): ");
            string artistName = Console.ReadLine();

            var artist = (from a in db.Artists
                          where a.Name == artistName
                          select a
                        ).FirstOrDefault();

            SongModel song = new SongModel()
            {
                Title = title,
                Genre = genre,
                ReleaseDate = releaseDate
            };

            song.Artist = CreateArtistObject(artist.ArtistId, artist.Name, artist.Country, artist.DateOfBirth);

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = clientRequest.CreateAsJson<SongModel>(song, controller);
                return sent;
            }
            else
            {
                var sent = clientRequest.CreateAsXml<SongModel>(song, controller);
                return sent;
            }
        }

        private static string UpdateSong(ClientRequest clientRequest, string controller)
        {
            Console.Write("Enter id: ");
            var inputId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter genre(optional): ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;

            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            MusicStoreDb db = new MusicStoreDb();

            Console.WriteLine("Artist Name(optional): ");
            string artistName = Console.ReadLine();

            var artist = (ArtistModel)(from a in db.Artists
                                  where a.Name == artistName
                                  select a
                        ).FirstOrDefault();
            SongModel song;

            if (artist == null)
            {
                song = new SongModel()
                {
                    SongId = inputId,
                    Title = title,
                    Genre = genre,
                    ReleaseDate = releaseDate
                };
            }
            else
            {
                song = new SongModel()
                {
                    SongId = inputId,
                    Title = title,
                    Genre = genre,
                    ReleaseDate = releaseDate,
                    Artist = CreateArtistObject(artist.ArtistId, artist.Name, artist.Country, artist.DateOfBirth)
                };
            }

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = clientRequest.UpdateAsJson<SongModel>(song, controller, inputId.ToString());
                return sent;
            }
            else
            {
                var sent = clientRequest.UpdateAsXml<SongModel>(song, controller, inputId.ToString());
                return sent;
            }
        }

        static string PrintCurrentPath(string controller)
        {
            string path = baseUrl + controller;
            Console.WriteLine(path);

            return path;
        }

        static void PrintMenu()
        {
            Console.WriteLine("Enter corresponding number for each option:\n1. Artist\n2. Album\n3. Song\n4. End");
        }

        static void PrintCrudOperationsChoices()
        {
            Console.WriteLine("1. Create\n2. Read\n3. Update\n4. Delete\n5. Read with Id");
        }

        static void PrintEndOperationsCycle()
        {
            Console.WriteLine("\n========================\n");
        }
    }
}
