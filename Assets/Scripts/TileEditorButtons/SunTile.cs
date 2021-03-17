using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunTile : MonoBehaviour
{
    [SerializeField] public TileTypes yellowtile;

    public Text TileName;
    public static int tileID = 2;

    void Start()
    {
        var colors = GetComponent<Button>().colors;

        colors.highlightedColor = yellowtile.h_color;
        colors.normalColor = yellowtile.color;
        colors.pressedColor = yellowtile.color;
        colors.selectedColor = yellowtile.color;
        GetComponent<Button>().colors = colors;
        TileName.text = yellowtile.tileName;
    }
}