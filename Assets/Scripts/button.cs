using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // renderer and timer
    // TODO: array of platforms
    public GameObject somePlatform;

    // change button state
    private Animator animator;

    // audio    
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.2f;

    // timer for how long the platform stays
    private bool timerOn = false;
    public float timeLeft = 8.0f;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate() {
        // when pressed, wait for timer to go down, then revert
        if (timerOn) {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0) {
                animator.SetInteger("button", 0);
                somePlatform.SetActive(false);
                timerOn = false;
                timeLeft = 8.0f;
            }
        }
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        // when collision with obj with player tag, set button to pressed down,
        // play tone, set platform active and activate timer to turn the things back to normal
        if (collision.gameObject.CompareTag("Player")) {
            animator.SetInteger("button", 1);
            audioSource.PlayOneShot(clip, volume);
            somePlatform.SetActive(true);
            timerOn = true;
            timeLeft = 8.0f;
        }
    }
}
