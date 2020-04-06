using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    private float length;
    private float startpos;

    public GameObject cam;
    public float parallex;

    // Start is called before the first frame update
    void Start()
    {
        // if you want to do it by the y, just change x to y
        startpos = transform.position.x;

        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float dis = cam.transform.position.x * parallex;
        float tmp = cam.transform.position.x * (1-parallex);

        transform.position = new Vector3(startpos + dis, transform.position.y, transform.position.z);

        if (tmp > startpos+length) {
            startpos += length;
        } else if (tmp < startpos - length) {
            startpos -= length;
        }
    }
}
