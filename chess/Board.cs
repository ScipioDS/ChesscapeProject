using ChesscapeProject.chess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ChesscapeProject
{

    /// <summary>
    /// The main board class. Only one instance of the class may exist at any given moment, and is used by a separate form, opened from the Menu.
    /// </summary>
    public class Board
    {
        public Square[][] Squares { get; set; }
        private static Board SingleBoard = null;
        public bool WhiteToPlay { get; set; }


        /// <summary>
        /// Reserves memory for the Square matrix (the board itself). Private due to singleton.
        /// </summary>
        private Board()
        {
            Squares = new Square[8][];
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    Squares[i] = new Square[8];
                }
            }
        }

        public static Board GetInstance()
        {
            // Board singleton
            SingleBoard = SingleBoard == null? new Board() : SingleBoard;
            return SingleBoard;
        }

        public void SetBoard(string FEN)
        {
            SingleBoard = FENTranslate(FEN);
        }

        /// <summary>
        /// A Forsyth-Edwards notation translator function.
        /// </summary>
        /// <param name="FEN">A given Forsyth-Edwards notation chess position.</param>
        /// <returns>A fully defined board (i.e., a chess position)</returns>
        private Board FENTranslate(string FEN)
        {
            // TODO: Add translation algorithm.
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns the square in the Board matrix with the position passed as an argument
        /// </summary>
        /// <param name="position">A formally defined square position.</param>
        /// <returns></returns>
        public static Square PositionToSquare(string position)
        {
            int file = Square.FileToNumeric[position[0]];
            int rank = int.Parse(position[1].ToString()) - 1;
            return SingleBoard.Squares[rank][file];
        }   

        public void DrawAllComponents(Graphics g)
        {
            Array.ForEach(Squares, rank => Array.ForEach(rank, square => square.Draw(g)));
        }
    }
}
