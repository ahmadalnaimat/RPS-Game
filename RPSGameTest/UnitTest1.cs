using Xunit;
using RPSGame;

namespace RPSGameTest
{
    public class RPSGameTests
    {
        [Theory]
        [InlineData("Paper", "Rock", "Player")]   // Player wins
        [InlineData("Rock", "Scissors", "Player")] // Player wins
        [InlineData("Scissors", "Paper", "Player")] // Player wins
        [InlineData("Rock", "Paper", "AI")] // AI wins
        [InlineData("Scissors", "Rock", "AI")] // AI wins
        [InlineData("Paper", "Scissors", "AI")] // AI wins
        [InlineData("Rock", "Rock", "Tie")] // Tie
        [InlineData("Paper", "Paper", "Tie")] // Tie
        [InlineData("Scissors", "Scissors", "Tie")] // Tie
        public void Scoring_ShouldReturnExpectedWinner(string playerChoice, string aiChoice, string expectedWinner)
        {
            // Act
            string actualWinner = RPSGame.RPSGame.Scoring(playerChoice, aiChoice);

            // Assert
            Assert.Equal(expectedWinner, actualWinner);
        }
    }
}