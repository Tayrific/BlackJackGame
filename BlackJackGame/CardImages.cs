using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace BlackJackGame
{
    public class CardImages
    {
        private Dictionary<string, Image> cardImages;

        public CardImages()
        {
            cardImages = new Dictionary<string, Image>();
            LoadCardImages();
        }

        private void LoadCardImages()
        {
            // Get the base directory of the application (where the .exe is located)
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine it with the relative path to the Resources folder
            string resourcesPath = Path.Combine(baseDirectory, "Resources");

            // Get all the files in the Resources folder
            string[] files = Directory.GetFiles(resourcesPath, "*.png");

            foreach (var file in files)
            {
                // Extract the file name without the extension
                string fileName = Path.GetFileNameWithoutExtension(file);
                cardImages.Add(fileName, Image.FromFile(file));
            }
        }

        public Image GetCardImage(string cardKey)
        {
            if (cardImages.ContainsKey(cardKey))
            {
                return cardImages[cardKey];
            }
            return null;
        }
    }
}
