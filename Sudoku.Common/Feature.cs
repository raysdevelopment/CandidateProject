using System;
using System.Collections.Generic;
using NightRays;

namespace Sudoku.Common
{
    /// <summary>
    /// Represents a puzzle feature that knows references to cells and its position within a puzzle.
    /// </summary>
    public class Feature
    {
        #region Properties

        private readonly List<Cell> _Cells;
        /// <summary>
        /// Gets the cells associated with this feature.
        /// </summary>
        public List<Cell> Cells
        {
            get { return _Cells; }
        }

        private readonly int _Position;
        /// <summary>
        /// Gets the position of this feature.
        /// </summary>
        public int Position
        {
            get { return _Position; }
        }

        #endregion Properties

        #region Construction

        /// <summary>
        /// Initializes a new instance of the Sudoku.Common.Feature class
        /// with its specified position.
        /// </summary>
        public Feature(int position)
        {
            if (position < 0)
                throw new ArgumentException("Features must have positive positions", "position");

            _Cells = new List<Cell>();
            _Position = position;
        }

        #endregion Construction

        #region Methods

        /// <summary>
        /// Determines whether the feature is currently valid.
        /// </summary>
        /// <exception cref="Sudoku.Common.DuplicateValueException"></exception>
        public virtual void Validate()
        {
            List<int> found = new List<int>();
            
            // TODO: Refactor to use LINQ
            foreach (Cell cell in this.Cells)
            {
                if (cell.IsSolved)
                {
                    if (found.Contains(cell.Value))
                        throw new DuplicateValueException(this, cell.Value);
                    found.Add(cell.Value);
                }
            }
        }

        public override string ToString()
        {
            return this.Cells.Implode(" ", c => c.ToString());
        }

        #endregion Methods
    }
}
