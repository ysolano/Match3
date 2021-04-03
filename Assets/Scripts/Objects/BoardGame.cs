using System;

[Serializable]
public class BoardGame
{
    #region StructObjects
    [Serializable]
    public struct Cell
    {
        public BoardTileType[] CellData;
    }
    #endregion

    #region Properties
    public int Rows;
    public int Columns;
    public Cell[] RowData;
    #endregion
}