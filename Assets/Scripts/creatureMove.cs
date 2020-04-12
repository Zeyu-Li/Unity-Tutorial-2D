using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatureMove : MonoBehaviour
{
    // speed of creature
    public float speed = 5f;
    public bool smartTurn = true;

    // wall detection
    public Transform creature, wall;

    public bool collision;

    private Rigidbody2D body;

    // creature is called before the first frame update
    void Start()
    {
        body = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        collision = Physics2D.Linecast(creature.position, wall.position, 1 << LayerMask.NameToLayer("Ground"));

        if (collision == smartTurn) {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1);
        }

        body.velocity = new Vector2(transform.localScale.x, 0) * speed;

    }
}
