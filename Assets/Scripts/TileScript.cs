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
    //public GridLayoutGroup grid;
    //[SerializeField] public TileTypes extratile;
    [SerializeField] public int tileID;

    /*  colors.highlightedColor = greentile.h_color;
        colors.normalColor = greentile.color;
        colors.pressedColor = greentile.color;
     */
    void Start()
    {
        var colors = GetComponent<Button>().colors;

        if (tileID == 0)
        {
            colors.highlightedColor = greentile.h_color;
            colors.normalColor = greentile.color;
            colors.pressedColor = greentile.color;
            colors.selectedColor = greentile.color;
            GetComponent<Button>().colors = colors;
            TileName.text = greentile.tileName;
        }
        else if (tileID == 1)
        {
            colors.highlightedColor = bluetile.h_color;
            colors.normalColor = bluetile.color;
            colors.pressedColor = bluetile.color;
            colors.selectedColor = bluetile.color;
            GetComponent<Button>().colors = colors;
            TileName.text = bluetile.tileName;
        }
        else if (tileID == 2)
        {
            colors.highlightedColor = yellowtile.h_color;
            colors.normalColor = yellowtile.color;
            colors.pressedColor = yellowtile.color;
            colors.selectedColor = yellowtile.color;
            GetComponent<Button>().colors = colors;
            TileName.text = yellowtile.tileName;
        }
        else if (tileID == 3)
        {
            colors.highlightedColor = redtile.h_color;
            colors.normalColor = redtile.color;
            colors.pressedColor = redtile.color;
            colors.selectedColor = redtile.color;
            GetComponent<Button>().colors = colors;
            TileName.text = redtile.tileName;
        }
        else if (tileID == 4)
        {
            colors.highlightedColor = browntile.h_color;
            colors.normalColor = browntile.color;
            colors.pressedColor = browntile.color;
            colors.selectedColor = browntile.color;
            GetComponent<Button>().colors = colors;
            TileName.text = browntile.tileName;
        }

        /*else if (tileID == 5) {
            colors.highlightedColor = extratile.h_color;
            colors.normalColor = extratile.color;
            colors.pressedColor = extratile.color;
            colors.selectedColor = extratile.color;
            GetComponent<Button>().colors = colors;
            TileName.text = extratile.tileName;
        }*/
    }

    public void ReplaceTile()
    {
        /*on clicking the button, switches ID from 1st button click to 2nd button click, but how?
         
         - could change per click, per button? on click, a for loops between IDs 0 and 4.
         - drag event, but would need to implement mouse target location
         - onclick two buttons "select them" and switch their IDs. how to break this apart?
         */
    }

    public void CreateTile()
    {
        //already have an extra file created and placed as ID = 5, but will change it's values here.
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

}
