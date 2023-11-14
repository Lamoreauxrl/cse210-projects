public class Questions
{
   public List<string> _questions;

   public Questions()
   {
      _questions = new List<string>{"What is the toughest challenge you overcame today?",
      "How did I see the hand of the Lord in my life today?",
      "If I had one thing I could do over today, what would it be?",
      "What was the best part of my day?",
      "In what way did I help someone today?"};
   }



   public string GetRandomQuestion()
   {
      var rndm = new Random();
      int index = rndm.Next(_questions.Count);
      return _questions[index];
   }
}