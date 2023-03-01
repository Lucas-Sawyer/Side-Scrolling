using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    public float max_health, health, armor, walk_speed, jump_height, jump_speed, shoot_delay, damage;
    public string[] buffs, debuffs;
    public Rigidbody2D RB;
    public Vector2 push_force;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        health = max_health;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
