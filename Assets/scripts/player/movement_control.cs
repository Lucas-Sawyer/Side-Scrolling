using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_control : MonoBehaviour
{
    public bool grounded;
    public int side = 1, direction;

    private bool facing_right = true;
    private Rigidbody2D RB;
    private movement movement;
    private stats stats;
    private flip flip;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<movement>();
        flip = GetComponent<flip>();
        stats = GetComponent<stats>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RB = GetComponent<Rigidbody2D>();

        if (side == 1 && !facing_right || side == -1 && facing_right)
        {
            flip.flip_me(transform.localScale.x, transform.localScale.y);
            facing_right = !facing_right;
        }

        RB.velocity = movement.walk(direction, stats.walk_speed, RB.velocity.y);
    }

    public void move_left()
    {
        direction = -1;
        side = -1;
    }

    public void move_right()
    {
        direction = 1;
        side = 1;
    }

    public void stop()
    {
        direction = 0;
    }
}
