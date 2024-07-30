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
        Vector2 move = Vector2.zero;

        if (Input.GetKey(left)) move.x = -1;
        if (Input.GetKey(right)) move.x = 1;
        if (Input.GetKey(forwards)) move.y = 1;
        if (Input.GetKey(backwards)) move.y = -1;

        Vector2 targetVelocity = move * G.PLAYER_SPEED;

        rb.velocity = (move != Vector2.zero) ? Vector2.Lerp(rb.velocity, targetVelocity, G.PLAYER_ACCELERATION * Time.deltaTime) :
            Vector2.Lerp(rb.velocity, Vector2.zero, G.PLAYER_DECELERATION * Time.deltaTime);

    }//TODO: have G.SPEED be a const used in a separate speed stored in playerstats that is calculated by applying weighting from other stats

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
