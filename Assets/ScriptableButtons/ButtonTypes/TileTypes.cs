﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "Tile")]
public class TileTypes : ScriptableObject
{
    [SerializeField] public int tileID;
    [SerializeField] public string tileName;
    [SerializeField] public Color color;
    
    #region getters and setters
    public int TileID { get => tileID; set => tileID = value; }
    public string TileName { get => tileName; set => tileName = value; }
    public Color Titlecolor { get => color; set => color = value; }
    #endregion
}
