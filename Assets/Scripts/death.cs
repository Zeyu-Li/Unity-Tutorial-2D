using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    // collides with object tagged death
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "death") {
            Die();
        }
    }

    // kills player and resets
    void Die() {
        Destroy(transform.parent.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
