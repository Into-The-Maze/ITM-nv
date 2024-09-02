using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void MyDebug() {
        //Debug.Log($"{Vector3.Angle(head.transform.up, torso.transform.up)}, {head.transform.rotation.eulerAngles}, {torso.transform.rotation.eulerAngles}, {legs.transform.rotation.eulerAngles}, {legsRotating} ");
        Debug.Log(Vector2.Angle(movementDirection, head.transform.rotation * Vector2.up));
        Debug.DrawRay(head.transform.position, head.transform.up, Color.red);
        Debug.DrawRay(torso.transform.position, torso.transform.up, Color.yellow);
        Debug.DrawRay(legs.transform.position, legs.transform.up, Color.blue);
        Debug.DrawRay(head.transform.position, Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, movementDirection)) * Vector2.up);
        Debug.DrawRay(head.transform.position, Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, movementDirection) + 180f) * Vector2.up, Color.green);
    }

    public Camera mainCam;
    public Rigidbody2D rb;
    public GameObject head;
    public GameObject torso;
    public GameObject legs;

    private KeyCode forwards;
    private KeyCode backwards;
    private KeyCode left;
    private KeyCode right;
    private KeyCode sprint;

    private PlayerMovementType playerMovementType;

    private void Awake() {
        InitKeybinds();
    }

    private void Start() {
        legsRotating = false;
        movementDirection = Vector2.zero;
    }

    private void FixedUpdate() {
        HandleMove();
    }

    private void Update() {
        HandleBodyVisuals();
        HandleMovementType();
        MyDebug();
    }

    private Vector2 movementDirection;
    private void HandleMove() {
        Vector2 move = Vector2.zero;

        if (Input.GetKey(left)) move.x = -1;
        if (Input.GetKey(right)) move.x = 1;
        if (Input.GetKey(forwards)) move.y = 1;
        if (Input.GetKey(backwards)) move.y = -1;

        movementDirection = move.normalized;
        Vector2 targetVelocity = (move * PSTATS.PLAYER_SPEED).normalized;

        

        rb.velocity = (move != Vector2.zero) ? Vector2.Lerp(rb.velocity, targetVelocity, PSTATS.PLAYER_ACCELERATION * Time.deltaTime) :
            Vector2.Lerp(rb.velocity, Vector2.zero, PSTATS.PLAYER_DECELERATION * Time.deltaTime);

    }//TODO: have G.SPEED be a const used in a separate speed stored in playerstats that is calculated by applying weighting from other stats. Use event system to have a live playerstats class that is updated on the stats changed event

    private bool legsRotating;
    private void HandleBodyVisuals() {

        switch (playerMovementType) {
            case PlayerMovementType.Standing:

                RotateHeadTowardsMouse();

                if (Vector3.Angle(head.transform.up, torso.transform.up) > G.PLAYER_NECK_ROTATE_CONSTRAINT)
                    RotateTorsoTowardsMouse();

                if (Vector3.Angle(torso.transform.up, legs.transform.up) > G.PLAYER_HIP_ROTATE_CONSTRAINT && !legsRotating) {
                    legsRotating = true;
                    StartCoroutine(RotateLegsStanding());
                }

                break;

            case PlayerMovementType.Walking: //todo: needs animations for legs moving back and forth, this just handles correct rotation

                RotateHeadTowardsMouse();
                RotateTorsoTowardsMouse();

                if (Vector2.Angle(movementDirection, head.transform.rotation * Vector2.up) < 90f) //ie. if we can walk within a reasonable angle of where we are looking
                    legs.transform.rotation = Quaternion.Slerp(legs.transform.rotation, Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, movementDirection)), G.PLAYER_FOOT_TURN_SPEED * Time.deltaTime);
                
                //otherwise, walk backwards
                else legs.transform.rotation = Quaternion.Slerp(legs.transform.rotation, Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, movementDirection) + 180f), G.PLAYER_FOOT_TURN_SPEED * Time.deltaTime);
                
                break;

            case PlayerMovementType.Sprinting:
                //todo: add animation and probably some checks
                break;

        }
    }

    private void RotateHeadTowardsMouse() {
        head.transform.rotation = Quaternion.RotateTowards(head.transform.rotation,
                   Quaternion.LookRotation(Vector3.forward, (mainCam.ScreenToWorldPoint(Input.mousePosition) - head.transform.position).normalized),
                   PSTATS.PLAYER_TURN_SPEED * Time.deltaTime);
    }
    private void RotateTorsoTowardsMouse() {
        torso.transform.rotation = Quaternion.RotateTowards(torso.transform.rotation,
                        Quaternion.LookRotation(Vector3.forward, (mainCam.ScreenToWorldPoint(Input.mousePosition) - head.transform.position).normalized),
                        PSTATS.PLAYER_TURN_SPEED * Time.deltaTime);
    }

    IEnumerator RotateLegsStanding() {

        float footRotationSpeedMultiplier = 10f;
        while (Vector3.Angle(legs.transform.up, torso.transform.up) > 10f) {
            legs.transform.rotation = Quaternion.RotateTowards(legs.transform.rotation, torso.transform.rotation, PSTATS.PLAYER_TURN_SPEED * Time.deltaTime * footRotationSpeedMultiplier);
            //initialRotationSpeed /= Time.deltaTime + 1.026f; //This changes how quickly the leg rotation slows. Must be below 1.1f ish, needs changing when hip constraint changes.
            yield return null; 
        }

        legsRotating = false; 
    }

    private void HandleMovementType() {
        if (movementDirection == Vector2.zero)
            playerMovementType = PlayerMovementType.Standing;
        else if (rb.velocity.magnitude < 1f)
            playerMovementType = PlayerMovementType.Walking;
        else
            playerMovementType = PlayerMovementType.Sprinting;
    }

    private void InitKeybinds() {
        forwards = K.GetKeybind("Forwards");
        backwards = K.GetKeybind("Backwards");
        left = K.GetKeybind("Left");
        right = K.GetKeybind("Right");
        sprint = K.GetKeybind("Sprint");
    }

    private enum PlayerMovementType {
        Standing,
        Walking,
        Sprinting,
    }
}
