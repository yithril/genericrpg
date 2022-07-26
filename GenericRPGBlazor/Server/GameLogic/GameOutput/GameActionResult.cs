namespace GenericRPGBlazor.Server.GameLogic.GameOutput
{
    public class GameActionResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public GameActionResult(string message, bool success = false)
        {
            Message = message;
            Success = success;
        }
    }
}
