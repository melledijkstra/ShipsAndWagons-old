using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SAWLibrary.Entities;
using System;
using System.IO;
using System.Windows;
using System.Windows.Threading;

namespace SAWLibrary
{
    public class Game
    {
        public DispatcherTimer Timer;
        private static Game _instance;

        public static Game Instance => _instance ?? (_instance = new Game());
        public Map Map { get; }
        public Player Player { get; }
        public static bool Started => _instance != null;

        private Game()
        {
            System.Console.WriteLine("New Game instanciated");
            Map = new Map();
            Player = new Player("Player 1");
            Timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 1) };
            Timer.Tick += (sender, args) => Console.WriteLine("TICK!!");
        }

        public Game(JObject gameJson)
        {
            // Load the game from JObject
            _instance = this;
        }

        public void SaveGame(string filename)
        {
            // TODO: Optimize directory and filename checking
            // TODO: Save directory should be able to change in settings
            // Check if the file exists to save the file
            if (!File.Exists(filename))
            {
                MessageBox.Show("Could not save game to '" + filename + "', please try again");
                return;
            }
            else
            {
                // If file exists, prepare json string to be writen
                // Ask all game components to return a JObject by calling Save() on them and put them in the root JObject
                try
                {
                    // TODO: create save functionality
                    /*JObject root = new JObject();
                    root.player = Player.Save();
                    File.WriteAllText(filename,root.);
                    writer = new StreamWriter("Saves/save1.saw", false);
                    writer.Write(jsonToSave);*/
                }
                finally
                {
                    // TODO: Close writer if needed
                    //writer?.Close();
                }
            }
        }

        public static Game NewGame()
        {
            return _instance;
        }

        private static void LoadFromFile(string fileName)
        {
            JsonReader reader = null;
            try
            {
                if (fileName.ToUpper().EndsWith(".SAW"))
                {
                    JObject gameJson = JObject.Parse(File.ReadAllText(fileName));
                    _instance = new Game(gameJson);
                }
                else
                {
                    MessageBox.Show("Invalid filename extension, should be (.saw)");
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine(fileName + " does not contain valid JSON (Exception: " + e.Message + ")");
                MessageBox.Show("This is not a valid save file");
            }
            finally
            {
                reader?.Close();
            }
        }

        public static Game GetGame()
        {
            return _instance;
        }
    }
}