using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChesscapeProject.chess
{
    /// <summary>
    /// Note: byte (unsigned 8-bit integer) is used as a type to reduce waste on memory by using int (unsigned 8-bit integer);
    /// 0-indexed values are used for File and Rank (i.e., File and Rank are in range [0,7] for ease of access in the Board matrix, 
    ///                                              but are formally defined as [a-h] and [1-8] respectively)
    /// </summary>
    public class Square
    {
        public readonly byte File;
        public readonly byte Rank;
        private Piece Piece;
        public readonly static Dictionary<int, char> NumericToFile = new Dictionary<int, char>();
        public readonly static Dictionary<char, int> FileToNumeric = new Dictionary<char, int>();

        // TODO: add attributes for drawing

        /// <summary>
        /// Full identification and definition of a square.
        /// </summary>
        /// <param name="File">The File of the Square</param>
        /// <param name="Rank">The Rank of the Square</param>
        /// <param name="Piece">Piece resident on this Square</param>
        public Square(byte File, byte Rank, Piece Piece)
        {
            Trace.Assert(File <= 7 && Rank >= 0); // insurance the File is in the range [0, 7]
            Trace.Assert(Rank <= 7 && Rank >= 0); // insurance the Rank is in the range [0, 7]

            this.File = File; // the file is indexed by j in the board matrix (columns)
            this.Rank = Rank; // the rank is indexed by i in the board matrix (rows)
            this.Piece = Piece;
        }

        public static void SetFileTranslation()
        {
            for (char i = 'a'; i < 'a' + 8; ++i)
            {
                NumericToFile.Add((i - 'a'), i);
                FileToNumeric.Add(i, (i - 'a'));
            }
        }

        public override string ToString()
        {
            return $"{NumericToFile[File]}{Rank + 1}";
        }

        public void Draw(Graphics g)
        {
            // TODO: Implement particular square drawing (more arguments may be needed, position...)
            throw new NotImplementedException();
        }
    }
}
