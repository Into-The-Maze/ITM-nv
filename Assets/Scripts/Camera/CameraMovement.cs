using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // The camera essentially should position itself at some point between the player and the mouse.

    public Camera mainCam;
    public Transform player;

    private void Update() {
        Vector3 v = Vector3.zero;
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = player.position.z; 
        Vector3 target = Vector3.Lerp(player.position, mousePos, G.CAMERA_POS_DISTANCE_FROM_PLAYER);
        //Vector3 pos = Vector3.Lerp(mainCam.transform.position, target, G.CAMERA_POS_ADJUST_SPEED);

        Vector3 pos = Vector3.SmoothDamp(mainCam.transform.position, target, ref v, G.CAMERA_POS_ADJUST_SPEED);
        pos.z = G.CAMERA_Z_POS; 

        mainCam.transform.position = pos;
    }
}
