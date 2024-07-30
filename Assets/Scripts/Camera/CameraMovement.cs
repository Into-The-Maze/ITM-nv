using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // The camera should follow the player slightly behind them.

    public Camera mainCam;
    public Transform player;

    Vector3 v;


    private void Start() {
        v = Vector3.zero;
    }

    private void FixedUpdate() {
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = player.position.z;
        Vector3 target = Vector3.Lerp(player.position, mousePos, G.CAMERA_POS_DISTANCE_FROM_PLAYER);

        Vector3 pos = Vector3.Lerp(mainCam.transform.position, target, G.CAMERA_POS_ADJUST_SPEED);
        pos.z = G.CAMERA_Z_POS;

        mainCam.transform.position = pos;
    }
}
