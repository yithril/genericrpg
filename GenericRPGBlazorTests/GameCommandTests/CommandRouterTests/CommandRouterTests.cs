using FluentAssertions;
using GenericRPGBlazor.Server.GameLogic.Parser;
using GenericRPGBlazor.Server.GameLogic.State;
using GenericRPGBlazor.Server.Models;
using System.Collections.Generic;
using Xunit;

namespace GenericRPGBlazorTests.GameCommandTests.CommandRouterTests
{
    public class CommandRouterTests
    {
        [Fact]
        public void CommandRouter_BlankCommand_ReturnsMessage()
        {
            var cRouter = new CommandRouter();

            var player = new Player();

            var state = new GameState(new List<GameZone>(), new List<GenericRPGBlazor.Shared.DTO.RoomDTO>(), new List<GenericRPGBlazor.Shared.DTO.PlayerDTO>());

            var result = cRouter.ReceiveCommand("", state, player);

            result.Should().NotBeNull();
            result.Success.Should().BeFalse();
            result.Message.Should().Be("Please type a command.");
        }

        [Fact]
        public void CommandRouter_CommandDoesntExist_ReturnsFalse()
        {
            var cRouter = new CommandRouter();

            var player = new Player();

            var state = new GameState(new List<GameZone>(), new List<GenericRPGBlazor.Shared.DTO.RoomDTO>(), new List<GenericRPGBlazor.Shared.DTO.PlayerDTO>());

            var result = cRouter.ReceiveCommand("fahrVergnuegen", state, player);

            result.Should().NotBeNull();
            result.Success.Should().BeFalse();
            result.Message.Should().NotBeEmpty();
        }

        [Fact]
        public void ValidCommandInput_ReturnsSuccess()
        {
            var cRouter = new CommandRouter();

            var player = new Player();

            var state = new GameState(new List<GameZone>(), new List<GenericRPGBlazor.Shared.DTO.RoomDTO>(), new List<GenericRPGBlazor.Shared.DTO.PlayerDTO>());

            var result = cRouter.ReceiveCommand("take", state, player, "longsword");

            result.Should().NotBeNull();
            result.Success.Should().BeTrue();
        }
    }
}
