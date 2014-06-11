using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku.Common
{
    /// <summary>
    /// Represents a puzzle box that knows references to cells and its position within a puzzle.
    /// </summary>
    public class Box : Feature
    {
        #region Construction

        /// <summary>
        /// Initializes a new instance of the Sudoku.Common.Box class
        /// with its specified position and associated puzzle.
        /// </summary>
        public Box(int position, Puzzle puzzle)
            : base(position)
        {
            // TODO: Identify cells
        }

        #endregion Construction
    }
}
