using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthTile : MonoBehaviour
{
    [SerializeField] public TileTypes browntile;

    public Text TileName;
    public static int tileID = 4;

    void Start()
    {
        var colors = GetComponent<Button>().colors;

        colors.highlightedColor = browntile.h_color;
        colors.normalColor = browntile.color;
        colors.pressedColor = browntile.color;
        colors.selectedColor = browntile.color;
        GetComponent<Button>().colors = colors;
        TileName.text = browntile.tileName;
    }
}