using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera mainCam;
    public Transform player;

    private void Start() {

    }

    private void Update() {
        Vector3 v = player.position;
        v.z = G.CAMERA_Z_POS;
        mainCam.transform.position = v;
    }
    

    //I can use this later to make variable zoom scopes. The player should not be able to see themselves while scoped, maybe blur most of the screen or sm, as this causes a strange visual bug where the player shakes.

    //Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
    //mousePos.z = player.position.z;
    //    Vector3 target = Vector3.Lerp(player.position, mousePos, G.CAMERA_POS_DISTANCE_FROM_PLAYER);

    //Vector3 pos = Vector3.Lerp(mainCam.transform.position, target, G.CAMERA_POS_ADJUST_SPEED);
    //pos.z = G.CAMERA_Z_POS;

    //    mainCam.transform.position = pos;
}
