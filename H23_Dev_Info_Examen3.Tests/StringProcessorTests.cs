using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace H23_Dev_Info_Examen3.Tests
{
    [TestClass]
    public class StringProcessorTests
    {
        private StringProcessor processor;

        [TestInitialize]
        public void Initialize()
        {
            processor = new StringProcessor();
        }

        [TestMethod]
        public void StartsWithUpper_EntreeNull_RetourneFalse()
        {
            // Arrange
            string input = null;

            // Act
            bool result = processor.StartsWithUpper(input);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void ReverseString_ValidInput_ReturnsReversedString()
        {
            // Arrange
            string input = "Hello World";
            string expected = "dlroW olleH";

            // Act
            string result = processor.ReverseString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseString_EntreeNull_RetourneNull()
        {
            // Arrange
            string input = null;

            // Act
            string result = processor.ReverseString(input);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void CountVowels_ValidInput_ReturnsCorrectCount()
        {
            // Arrange
            string first = null;
            string second = null;
            
            // Act
            string result = processor.ConcatenateStrings(first, second);

            // Assert
            Assert.IsNull(result);
        }


        
        // AUTRES CAS D'ESSAIS
        // StartsWithUpper:
        //   - Entrée vide => retourne false
        //   - Entrée avec un seul caractère => retourne true si c'est une majuscule, false sinon
        //   - Entrée avec plusieurs caractères => retourne true si le premier caractère est une majuscule, false sinon
        // ReverseString:
        //   - Entrée vide => retourne une chaîne vide
        //   - Entrée avec un seul caractère => retourne la même chaîne
        // CountVowels:
        //   - Entrée vide => retourne 0
        //   - Entrée avec un seul caractère => retourne 1 si c'est une voyelle, 0 sinon
        //   - Entrée avec plusieurs caractères contenant 3 voyelles => retourne 3
        // ConcatenateStrings:
        //  - La première entrée est null => retourne la deuxième entrée
        //  - Les deux entrées sont non null => retourne la concaténation des deux entrées
    }
}