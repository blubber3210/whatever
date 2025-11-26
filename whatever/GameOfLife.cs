using System;
using System.Collections.Generic;
using System.Text;

namespace whatever
{
    internal class GameOfLife
    {
        static char[] _cells;
        static int _columnCount;
        static int _rowCount;

        public static void Run()
        {
            _columnCount = Console.WindowWidth;
            _rowCount = Console.WindowHeight - 1;
            var cellCount = _columnCount * _rowCount;

            _cells = CreateRandomCells(cellCount);

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(_cells);
                Thread.Sleep(120);
                Update();
            }
        }

        static void Update()
        {
            var newCells = new char[_cells.Length];
            for (var index = 0; index < _cells.Length; index++)
            {
                var cell = _cells[index];
                var isAlive = cell == '*';
                var aliveNeighbourCount = CountAliveNeighbours(index);
                var isNextCellAlive =
                    (isAlive && aliveNeighbourCount is 2 or 3)
                    || (!isAlive && aliveNeighbourCount == 3);
                newCells[index] = isNextCellAlive ? '*' : ' ';
            }
            _cells = newCells;
        }

        static int CountAliveNeighbours(int index)
        {
            var rowIndex = index / _columnCount;
            var colIndex = index % _columnCount;
            return IsCellAlive(rowIndex - 1, colIndex - 1)
                   + IsCellAlive(rowIndex - 1, colIndex)
                   + IsCellAlive(rowIndex - 1, colIndex + 1)
                   + IsCellAlive(rowIndex, colIndex - 1)
                   + IsCellAlive(rowIndex, colIndex + 1)
                   + IsCellAlive(rowIndex + 1, colIndex - 1)
                   + IsCellAlive(rowIndex + 1, colIndex)
                   + IsCellAlive(rowIndex + 1, colIndex + 1);

        }

        static int IsCellAlive(int rowIndex, int colIndex)
        {
            if (rowIndex < 0 || colIndex < 0 || rowIndex >= _rowCount || colIndex >= _columnCount) return 0;
            var index = rowIndex * _columnCount + colIndex;
            return _cells[index] == '*' ? 1 : 0;
        }

        static char[] CreateRandomCells(int cellCount)
        {
            var random = new Random();
            var cells = new char[cellCount];
            for (var i = 0; i < cells.Length; i++)
            {
                var randomNumber0or1 = random.Next(0, 2);
                var isAlive = randomNumber0or1 == 1;
                cells[i] = isAlive ? '*' : ' ';
            }
            return cells;
        }
    }
}
