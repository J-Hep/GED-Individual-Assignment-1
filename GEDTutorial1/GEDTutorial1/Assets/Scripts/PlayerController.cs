using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Player movement
    PlayerAct inputAction;
    Vector2 move, look;

    Rigidbody rBody;
    private float distanceToGround, walkSpeed = 5.0f;
    private bool isGrounded = true;

    public Camera playerCamera;
    Vector3 cameraRotation;

    //Player Animations
    Animator playerAnim;
    private bool isWalk = false;

    //Projectiles
    public GameObject bullet;
    public Transform bulletSpawn;

    // Start is called before the first frame update
    void Start()
    {

        rBody = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
