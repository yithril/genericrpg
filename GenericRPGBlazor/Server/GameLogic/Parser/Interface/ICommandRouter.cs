using GenericRPGBlazor.Server.GameLogic.GameOutput;
using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.GameLogic.Parser.Interface
{
    public interface ICommandRouter
    {
        GameActionResult ReceiveCommand(string command, int playerId, GameState state, Living living, string action, string predicate = "");
    }
}
