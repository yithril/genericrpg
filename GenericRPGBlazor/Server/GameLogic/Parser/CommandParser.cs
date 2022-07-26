namespace GenericRPGBlazor.Server.GameLogic.Parser
{
    public class CommandParser : ICommandParser
    {
        public void ParseCommand(string userInput)
        {
            var sentence = userInput.Split(' ');

            if(sentence.Length == 1)
            {
                switch (sentence[0].ToLower())
                {
                    case "n":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
