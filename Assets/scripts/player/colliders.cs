using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliders : MonoBehaviour
{
    private movement movement;
    private animations animations;
    private Collider2D player_collider;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<movement>();
        animations = GetComponent<animations>();
        player_collider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animations.armed) player_collider.offset = new Vector2(-0.055f, 0);
        else player_collider.offset = new Vector2(0, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "ground":
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.gameObject.tag)
        {
            case "gun":
                animations.get_armed();
                Destroy(other.gameObject);
                break;
        }
    }
}
