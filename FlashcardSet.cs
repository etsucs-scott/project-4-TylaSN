using System.Collections.Generic;

namespace FlashCards.Components
{
    /* Flashcard Set Class*/
    public class FlashcardSet
    {
        //Gets/ Sets flashcard name
        public string Name { get; set; }
        public List<Flashcard> Cards { get; set; } = new();
    }
    
}
