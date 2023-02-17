namespace Launch_LinqExercises
{
    public class WhereTest
    {
        [Fact]
        public void PickEvenNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = numbers.Where(n => n % 2 == 0);

            Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, evens);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickOddNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var odds = numbers.Where(n =>
              false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<int> { 1, 3, 5, 7, 9 }, odds);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickWordsWithThreeLetters()
        {
            var words = new List<string> { "pill", "bad", "finger", "cat", "blue", "dog", "table", "red" };

            var selected = words.Where(w =>
                false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<string> { "bad", "cat", "dog", "red" }, selected);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickWordsWithMoreThanThreeLetters()
        {
            var words = new List<string> { "pill", "bad", "finger", "cat", "blue", "dog", "table", "red" };

            var selected = words.Where(w =>
                false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<string> { "pill", "finger", "blue", "table" }, selected);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickWordsEndingInE()
        {
            var words = new List<string> { "are", "you", "strike", "thinking", "belt", "piece", "warble", "sing", "pipe" };

            var selected = words.Where(w =>
                false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<string> { "are", "strike", "piece", "warble", "pipe" }, selected);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickWordsEndingInIng()
        {
            var words = new List<string> { "bring", "finger", "drought", "singing", "bingo", "purposeful" };

            var selected = words.Where(w =>
                false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<string> { "bring", "singing" }, selected);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickWordsContainingE()
        {
            var words = new List<string> { "four", "red", "five", "blue", "pizza", "purple" };

            var selected = words.Where(w =>
                false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<string> { "red", "five", "blue", "purple" }, selected);
        }

        [Fact(Skip = "Remove this once code complete")]
        public void PickDinosaurs()
        {
            var animals = new List<string> { "tyrannosaurus", "narwhal", "eel", "achillesaurus", "qingxiusaurus" };

            var dinosaurs = animals.Where(w =>
                false // Replace 'false' with your code code. Can collapse into one line.
            );

            Assert.Equal(new List<string> { "tyrannosaurus", "achillesaurus", "qingxiusaurus" }, dinosaurs);
        }
    }
}
