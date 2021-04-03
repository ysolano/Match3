using UnityEngine;
using UnityEngine.Tilemaps;

public class BoardDrawer : MonoBehaviour
{
    #region Fields
    GameManager gameManager;
    RuleTile boardRuleTile;
    BoardGame boardGame;
    Tilemap tilemap;
    int rows;
    int columns;
    #endregion

    #region MonoBehaviour methods
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        #region Instanciation
        gameManager = FindObjectOfType<GameManager>();
        boardRuleTile = gameManager.LevelToGame.BoardRuleTile;
        tilemap = GetComponent<Tilemap>();
        rows = gameManager.LevelToGame.BoardGame.Rows;
        columns = gameManager.LevelToGame.BoardGame.Columns;
        boardGame = gameManager.LevelToGame.BoardGame;
        #endregion

        DrawBoardGame();
    }
    #endregion

    #region Private Methods
    void DrawBoardGame()
    {
        for (int i = 0; i < rows; i++)
        {
            var row = boardGame.RowData[i];
            for (int j = 0; j < columns; j++)
            {
                var position = new Vector3Int(j, boardGame.Rows - i - 1, 0);
                switch (row.CellData[j])
                {
                    case BoardTileType.Basic:
                        tilemap.SetTile(position, boardRuleTile);
                        break;

                    default:
                        break;
                }
            }
        }
    }
    #endregion

}
