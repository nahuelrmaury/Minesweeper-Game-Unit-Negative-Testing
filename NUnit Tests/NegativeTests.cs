using Minesweeper.Core;
using Minesweeper.Core.Enums;
using MineSweeper.PositiveUnitTests;
using NUnit.Framework;

namespace NUnit_Tests
{
    public class NegativeTests
    {
        private GameProcessor _gameProcessor;
        private bool[,] _field;
        private PointState[,] _pointState;
        private NewFieldGenerator _newField = new NewFieldGenerator();

        /* verifies that GameProcessor object correctly throws an InvalidOperationException  */
        [Test]
        [TestCase(5, 5, 9, 9, 0)] /* beginner open cell after win */
        [TestCase(10, 10, 16, 16, 0)] /* intermediate open cell after win */
        [TestCase(5, 5, 16, 30, 0)] /* expert open cell after win */
        [TestCase(5, 5, 9, 9, 81)] /* beginner open cell after lose */
        [TestCase(10, 10, 16, 16, 256)] /* intermediate open cell after lose */
        [TestCase(5, 5, 16, 30, 480)] /* expert open cell after lose */
        public void T01_RandomFieldGenerator_OpenCellAfterWinAndLoseWithEverySizePosible_ThrowException(int x, int y, int row, int column, int mines)
        {
            /* precondition */
            _field = FieldGenerator.GetRandomField(row, column, mines);
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.Throws<InvalidOperationException>(() => _gameProcessor.Open(x, y));
        }

        [Test]
        [TestCase(10, 10, 9, 9, 0)] /* beginner open cell outside the grid */
        [TestCase(17, 0, 16, 16, 0)] /* intermediate open cell outside the grid */
        [TestCase(17, 0, 16, 30, 0)] /* expert open cell outside the grid */
        /* verify error message when open cell outside the game grid */
        public void T02_RandomFieldGenerator_OpenCellOutsideFieldWithEverySizePosible_ThrowErrorMessage(int x, int y, int row, int column, int mines)
        {
            /* precondition */
            _field = FieldGenerator.GetRandomField(row, column, mines);
            _gameProcessor = new GameProcessor(_field);

            /* action */
            
            /* assert */
            Assert.Throws<InvalidOperationException>(() => _gameProcessor.Open(x, y));
        }



    }
}
