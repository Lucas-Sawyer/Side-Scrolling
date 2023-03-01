using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_player : MonoBehaviour
{
    public float range;
    public bool can_attack = false;
    public bool attack;
    public float time = 0;


    private spot_player spot_player;
    private movement movement;
    private enemy_animations anim;
    private stats stats;
    // Start is called before the first frame update
    void Start()
    {
        spot_player = GetComponent<spot_player>();
        movement = GetComponent<movement>();
        stats = GetComponent<stats>();
    }

    // Update is called once per frame
    void Update()
    {
        attack = Physics2D.OverlapCircle(transform.position, range, spot_player.mask);
        if (spot_player.saw_player)
        {
            if (!attack) time++;
            if (time >= stats.shoot_delay)
            {
                can_attack = true;
                time = 0;
            }
        }

    }

    private void FixedUpdate()
    {

        stats.RB.velocity = can_attack ? stats.RB.velocity =
        movement.walk(spot_player.direction, stats.walk_speed, stats.RB.velocity.y) : stats.RB.velocity = new Vector2(0, stats.RB.velocity.y);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
