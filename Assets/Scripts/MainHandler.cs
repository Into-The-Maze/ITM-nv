using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

//Code that relates to the "bigger picture" should be called from here for clarity
//So for example, baking navmeshes on Awake, or generating inventory on Start.
public class MainHandler : MonoBehaviour
{
    private void Awake() {
        K.InitKeybindsFromPlayerprefs();
        //todo: Fetch Player Stats into PSTATS
    }

    private void Update() { 

    }
}
