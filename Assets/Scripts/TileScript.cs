using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    [SerializeField] public TileTypes bluetile;
    [SerializeField] public TileTypes greentile;
    //[SerializeField] public TileTypes extratile;

    void Start()
    {
        var colors = GetComponent<Button>().colors;
        colors.normalColor = greentile.color;
        GetComponent<Button>().colors = colors;
    }

    public void ChangeTile()
    {
        //
    }

    public void CreateTile()
    {
        //already have the file created and placed, but will change it's values here.
    }

}
