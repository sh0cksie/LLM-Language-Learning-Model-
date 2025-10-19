using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseapp
{
    using CsvHelper;
    using System.Formats.Asn1;
    using System.Globalization;
    using System.IO;


    public class Deck
    {
        public List<Card> Cards;
        public string File;

        public Deck(string file)
        {
            Cards = LoadDeck(file);
            File = file;
        }

        private List<Card> LoadDeck(string file)
        {
            try 
            {
                using (var reader = new StreamReader(file))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                        return csv.GetRecords<Card>().ToList(); ;
                }
            }
            catch (Exception _)
            {
                // Change this shit ong
                return new List<Card>() { new Card() { Front = "Deck not found", Back = "" } };
            }
        }
        

        public void AddCard(string front, string back)
        {
            Cards.Add(new Card() { Front = front, Back = back });

            using (var writer = new StreamWriter(File))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(Cards);
            }
        }

        public void DeleteCard(string front)
        {
            // To be added by davka
        }
    }

    public class Card
    {
        public string Front { get; set; }
        public string Back { get; set; }
    }
}
