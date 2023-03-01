using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed, damage;
    public Vector2 push_force;

    private Rigidbody2D bullet_rb;
    private movement_control movement_control;
    private movement movement;
    // Start is called before the first frame update
    void Start()
    {
        bullet_rb = GetComponent<Rigidbody2D>();

        movement = GetComponent<movement>();

        movement_control = GameObject.Find("player").GetComponent<movement_control>();

        bullet_rb.velocity = movement.walk(movement_control.side, speed, bullet_rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}
