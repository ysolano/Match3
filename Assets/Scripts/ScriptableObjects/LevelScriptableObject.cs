using UnityEngine;

[CreateAssetMenu(fileName = "Level Configuration", menuName = "Match3/Level Configuration")]
public class LevelScriptableObject : ScriptableObject
{
    #region Properties
    public RuleTile BoardRuleTile;
    public BoardGame BoardGame;
    #endregion
}