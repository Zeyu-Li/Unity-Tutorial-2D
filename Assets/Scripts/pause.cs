using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public static bool paused = false;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            Pause();
        }
    }

    void Pause() {
        if (!paused) {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        } else {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        paused = !paused;
    }
}
