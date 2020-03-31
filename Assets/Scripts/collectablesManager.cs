using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collectablesManager : MonoBehaviour
{
    public static collectablesManager instance;
    public TextMeshProUGUI text;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (instance==null) {
            instance = this;
        }
    }

    // Update is called once per frame
    public void changeScore(int gemValue) {
        score += gemValue;
        text.text = "x" + score.ToString();
    }
}
