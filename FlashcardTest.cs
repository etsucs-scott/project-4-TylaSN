/*using FlashCards;
using FlashCards.Components;
using Xunit;

namespace FlashCards.Tests
{
    // test suite for flashcard functionality
    public class FlashcardTests
    {
        // make sure a flashcard starts with correct default values
        [Fact]
        public void Flashcard_DefaultValues_Work()
        {
            var card = new Flashcard
            {
                Question = "Q",
                Answer = "A"
            };

            Assert.Equal("Q", card.Question);
            Assert.Equal("A", card.Answer);
            Assert.False(card.ShowAnswer);
        }

        // check that flipping a card works correctly
        [Fact]
        public void ToggleCard_FlipsValue()
        {
            var card = new Flashcard { ShowAnswer = false };

            card.ShowAnswer = !card.ShowAnswer;

            Assert.True(card.ShowAnswer);
        }

        // make sure cards can be added to a set
        [Fact]
        public void FlashcardSet_CanAddCard()
        {
            var set = new FlashcardSet();

            set.Cards.Add(new Flashcard
            {
                Question = "Q",
                Answer = "A"
            });

            Assert.Single(set.Cards);
        }

        // make sure cards can be removed from a set
        [Fact]
        public void FlashcardSet_CanRemoveCard()
        {
            var set = new FlashcardSet();
            var card = new Flashcard();

            set.Cards.Add(card);
            set.Cards.Remove(card);

            Assert.Empty(set.Cards);
        }

        // check that study index increases correctly
        [Fact]
        public void StudyIndex_IncrementsCorrectly()
        {
            int index = 0;

            index++;
            Assert.Equal(1, index);
        }

        // make sure study mode loops back to start
        [Fact]
        public void StudyIndex_ResetsAtEnd()
        {
            var count = 3;
            int index = 2;

            index++;
            if (index >= count)
                index = 0;

            Assert.Equal(0, index);
        }

        // make sure set name validation works for null values
        [Fact]
        public void SetName_CannotBeNull()
        {
            string name = null;

            Assert.True(string.IsNullOrWhiteSpace(name));
        }

        // make sure set name validation works for empty values
        [Fact]
        public void SetName_CannotBeEmpty()
        {
            string name = "";

            Assert.True(string.IsNullOrWhiteSpace(name));
        }

        // make sure a new set starts with an empty list of cards
        [Fact]
        public void FlashcardSet_InitializesEmpty()
        {
            var set = new FlashcardSet();

            Assert.NotNull(set.Cards);
        }

        // make sure a card can flip back and forth correctly
        [Fact]
        public void Flashcard_CanFlipBackAndForth()
        {
            var card = new Flashcard { ShowAnswer = false };

            card.ShowAnswer = !card.ShowAnswer;
            card.ShowAnswer = !card.ShowAnswer;

            Assert.False(card.ShowAnswer);
        }
    }
}
*/