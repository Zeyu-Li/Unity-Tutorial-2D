using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour {
    // inits
    // hoziontal speed
    public float speed = 10f;

    // vertical jump
    public float jumpForce = 10f;

    // different jump heights for how long jump button is pressed
    // change it as you change gravity
    public float jumpCheck = .2f;
    // is ground check
    public float checkRadius = 0.3f;

    // ground jump check
    public bool isGrounded;
    public Transform feetPos;
    public LayerMask whatIsGround;

    // so that infin jumps are not a thing
    private float jumpCheckCounter;
    private bool jumping;
    private float moveInput;

    // inits rigid body
    private Rigidbody2D rb;

    // audio    
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.2f;

    // change animation states
    private Animator animator;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {

        // bool to see if overlap of floor layer and feet object
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        // if is touching ground and jump button pressed, add jump force
        if (Input.GetButtonDown("Jump") && isGrounded == true) {
            jumping = true;
            jumpCheckCounter = jumpCheck;
            rb.velocity = Vector2.up * jumpForce;

            animator.SetInteger("AnimValue", 2);
        }

        if (Input.GetButton("Jump") && jumping == true) {
            // can jump only once
            if (jumpCheckCounter > 0) {
                rb.velocity = Vector2.up * jumpForce;
                jumpCheckCounter -= Time.deltaTime;
            }

        }
        else {
            // once jumping is not true, set jump to false
            jumping = false;
        }

        if (Input.GetButtonUp("Jump")) {
            jumping = false;
            animator.SetInteger("AnimValue", 0);
        }

        if (Input.GetKey("escape")) {
            Application.Quit();
        }

        // flips player
        if (moveInput > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveInput < 0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("gems")) {
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(clip, volume);
        }
    }

    void FixedUpdate() {
        // gets horizontal input from Unity (1 = right, -1 = left)
        moveInput = Input.GetAxisRaw("Horizontal");

        // if moving, then idle, else set to moving animation
        if (animator.GetInteger("AnimValue") == 2) {
            ;
        } else if (moveInput != 0) {
            animator.SetInteger("AnimValue", 1);
        } else {
            animator.SetInteger("AnimValue", 0);
        }

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
