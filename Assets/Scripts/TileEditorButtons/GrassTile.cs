using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrassTile : MonoBehaviour
{
    [SerializeField] public TileTypes greentile;

    public Text TileName;
    public static int tileID = 0;

    void Start()
    {
        var colors = GetComponent<Button>().colors;

        colors.highlightedColor = greentile.h_color;
        colors.normalColor = greentile.color;
        colors.pressedColor = greentile.color;
        colors.selectedColor = greentile.color;
        GetComponent<Button>().colors = colors;
        TileName.text = greentile.tileName;
    }
}

