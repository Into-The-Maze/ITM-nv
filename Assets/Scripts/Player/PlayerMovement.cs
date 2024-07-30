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
        
    }

    private void HandleMove() {

    }

    private void HandleHeadRotation() {

    }

    private void HandleTorsoRotation() {

    }

    private void InitKeybinds() {
        forwards = K.GetKeybind("Forwards");
        backwards = K.GetKeybind("Backwards");
        left = K.GetKeybind("Left");
        right = K.GetKeybind("Right");
    }
}
