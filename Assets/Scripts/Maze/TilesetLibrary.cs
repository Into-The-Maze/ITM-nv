using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

//This maps the strings defined in the SDK to rule tiles

public class TilesetLibrary : MonoBehaviour
{
    public Dictionary<string, RuleTile> tilesetLibrary;

    //Add rule tiles here
    public  RuleTile DBG_floor;
    public  RuleTile DBG_wall;

    //with string->tile references here
    private void Awake() {
        tilesetLibrary = new Dictionary<string, RuleTile>() {
            { "DBG_floor", DBG_floor },
            { "DBG_wall", DBG_wall},

        };
    }
}
