using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject head;
    public GameObject torso;
    public GameObject legs;

    private KeyCode forwards;
    private KeyCode backwards;
    private KeyCode left;
    private KeyCode right;

    private void Awake() {
        InitKeybinds();
    }

    private void FixedUpdate() {
        HandleMove();
    }

    private void HandleMove() {
        int horizontal = 0;
        int vertical = 0;

        if (Input.GetKeyDown(left)) horizontal = -1;
        if (Input.GetKeyDown(right)) horizontal = 1;
        if (Input.GetKeyDown(forwards)) vertical = 1;
        if (Input.GetKeyDown(backwards)) vertical = -1;

        rb.AddForce(new Vector2(horizontal, vertical).normalized);
    }

    private void HandleHeadRotation() {
        //todo
    }

    private void HandleTorsoRotation() {
        //todo
    }

    private void HandleLegs() {
        //todo
    }

    private void InitKeybinds() {
        forwards = K.GetKeybind("Forwards");
        backwards = K.GetKeybind("Backwards");
        left = K.GetKeybind("Left");
        right = K.GetKeybind("Right");
    }
}
