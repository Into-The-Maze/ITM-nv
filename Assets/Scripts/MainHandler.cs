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

    private void MyDebug() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            //todo: generate debugging room, just some pillars to test shaders and other items when added
        }
    }
}
