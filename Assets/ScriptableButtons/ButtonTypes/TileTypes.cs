using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "Tile")]
public class TileTypes : ScriptableObject
{
    [SerializeField] public int tileID;
    [SerializeField] public string tileName;
    [SerializeField] public Color color;
    [SerializeField] public Color h_color;
    
    #region getters and setters
    public int TileID { get => tileID; set => tileID = value; }
    public string TileName { get => tileName; set => tileName = value; }
    public Color Tilecolor { get => color; set => color = value; }
    public Color HighlightedTilecolor { get => h_color; set => h_color = value; }
    #endregion
}
