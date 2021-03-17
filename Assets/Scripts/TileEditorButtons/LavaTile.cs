using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavaTile : MonoBehaviour
{
    [SerializeField] public TileTypes redtile;

    public Text TileName;
    public static int tileID = 3;

    void Start()
    {
        var colors = GetComponent<Button>().colors;

        colors.highlightedColor = redtile.h_color;
        colors.normalColor = redtile.color;
        colors.pressedColor = redtile.color;
        colors.selectedColor = redtile.color;
        GetComponent<Button>().colors = colors;
        TileName.text = redtile.tileName;
    }
}