﻿using System.Collections.Generic;

namespace Core.Shogi.BitVersion
{
    public static class BitboardPredefinedStates
    {
        public static BitboardState InitialWhitePositions => new BitboardState(BinaryValues.FullRow, BinaryValues.TwoPieceRow, BinaryValues.FullRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow,
            BinaryValues.EmptyRow, BinaryValues.EmptyRow);

        public static BitboardState InitialBlackPositions => new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.FullRow,
            BinaryValues.TwoPieceRow, BinaryValues.FullRow);

        public static BitboardState InitialPositions => InitialBlackPositions & InitialWhitePositions;


        public static Dictionary<string, BitboardState> PositionState = new Dictionary<string, BitboardState>
        {
            {"9a", new BitboardState(1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8a", new BitboardState(1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7a", new BitboardState(1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6a", new BitboardState(1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5a", new BitboardState(1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4a", new BitboardState(1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3a", new BitboardState(1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2a", new BitboardState(1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1a", new BitboardState(0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9b", new BitboardState(BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8b", new BitboardState(BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7b", new BitboardState(BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6b", new BitboardState(BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5b", new BitboardState(BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4b", new BitboardState(BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3b", new BitboardState(BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2b", new BitboardState(BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1b", new BitboardState(BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1c", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1d", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1e", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1f", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"8g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"7g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"6g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"5g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"4g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"3g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"2g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"1g", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow, BinaryValues.EmptyRow)},
            {"9h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8, BinaryValues.EmptyRow)},
            {"8h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7, BinaryValues.EmptyRow)},
            {"7h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6, BinaryValues.EmptyRow)},
            {"6h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5, BinaryValues.EmptyRow)},
            {"5h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4, BinaryValues.EmptyRow)},
            {"4h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3, BinaryValues.EmptyRow)},
            {"3h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2, BinaryValues.EmptyRow)},
            {"2h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1, BinaryValues.EmptyRow)},
            {"1h", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1, BinaryValues.EmptyRow)},
            {"9i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 8)},
            {"8i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 7)},
            {"7i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 6)},
            {"6i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 5)},
            {"5i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 4)},
            {"4i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 3)},
            {"3i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 2)},
            {"2i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 1 << 1)},
            {"1i", new BitboardState(BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, BinaryValues.EmptyRow, 0x1)}
        };
    }
}