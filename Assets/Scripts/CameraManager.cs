using System;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    #region Fields
    GameManager gameManager;
    float positionZ;
    #endregion

    #region MonoBehaviour Methods
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        #region Instanciation
        gameManager = FindObjectOfType<GameManager>();
        positionZ = transform.position.z;
        #endregion

        SetCameraPosition();
    }
    #endregion

    #region Private Methods
    void SetCameraPosition()
    {
        var board = gameManager.LevelToGame.BoardGame;
        var positionX = gameObject.transform.position.x - ((float)gameManager.MAX_COLUMNS - board.Columns) / 2;
        var positionY = gameObject.transform.position.y - ((float)gameManager.MAX_ROWS - board.Rows) / 2;
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
    #endregion
}
