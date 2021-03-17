using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPick : MonoBehaviour
{
    public static Color currentColor;
    public static Color currenthighlitedColor;

    public void OnMouseDown()
    {
        currentColor = GetComponent<Button>().colors.normalColor;
        currenthighlitedColor = GetComponent<Button>().colors.highlightedColor;
    }
}
