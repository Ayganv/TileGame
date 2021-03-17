using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterTile : MonoBehaviour
{
    [SerializeField] public TileTypes bluetile;

    public Text TileName;
    public static int tileID = 1;

    void Start()
    {
        var colors = GetComponent<Button>().colors;

        colors.highlightedColor = bluetile.h_color;
        colors.normalColor = bluetile.color;
        colors.pressedColor = bluetile.color;
        colors.selectedColor = bluetile.color;
        GetComponent<Button>().colors = colors;
        TileName.text = bluetile.tileName;
    }
}