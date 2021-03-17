using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    [SerializeField] public TileTypes greentile;
    [SerializeField] public TileTypes bluetile;
    [SerializeField] public TileTypes yellowtile;
    [SerializeField] public TileTypes redtile;
    [SerializeField] public TileTypes browntile;

    public Text TileName;

    [SerializeField] public int tileID = 0;

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

    public void OnMouseDown()
    {
        var colorBlock = GetComponent<Button>().colors;
        colorBlock.normalColor = ColorPick.currentColor;
        colorBlock.highlightedColor = ColorPick.currenthighlitedColor;
        colorBlock.pressedColor = ColorPick.currentColor;
        colorBlock.selectedColor = ColorPick.currentColor;
        GetComponent<Button>().colors = colorBlock;
        Debug.Log(colorBlock);
    }

    public void Reset()
    {
        /* ResetButton "onclick" not working
         
        get the tileIDs inside each Button and change to initial terms @TheGrid 
        grid = GetComponetsinChildren<Panel>("TheGrid");
        foreach (int tileID in grid)
        {
            grid.tileID = 0;
        }
        
        get the tileIDs inside each Button and change to initial terms @TileEditor
        
        get the tileIDs inside each Button and change to initial terms @EditOptions
        
        */
    }

    public void SaveGame()
    {
        //1 - need to test save after figure out strategy to switch colors.
        //2 - need to solve "Reset" to learn how to reach specific IDs in specific Buttons.
        //all I want to save is the respective ID in each Button with colors on.
    }
    
    public void LoadGame()
    {
        //need to test load after figure out strategy to switch colors.
    }
    
    public void QuitGame()
    {
        //need to test load after figure out strategy to switch colors.
    }
}

