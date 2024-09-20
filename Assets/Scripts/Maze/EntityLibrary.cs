using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This maps the strings defined in the SDK to spawnable prefab objects

public class EntityLibrary : MonoBehaviour
{
    //Add public GameObject variables here to create an entity

    public static Dictionary<string, GameObject> entityLibrary = new() {

    };
}
