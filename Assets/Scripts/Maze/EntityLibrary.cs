using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This maps the strings defined in the SDK to spawnable prefab objects

public class EntityLibrary : MonoBehaviour
{
    public Dictionary<string, GameObject> entityLibrary;

    //Add public GameObject variables here to create an entity
    public GameObject DBG_table;

    private void Awake() {
        entityLibrary = new Dictionary<string, GameObject>() {
            { "DBG_table", DBG_table },

        };
    }

}
