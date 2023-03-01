using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class take_damage : MonoBehaviour
{
    public float damage_me(float damage_taken, float armor)
    {
        float damage = 0;
        damage = damage_taken - armor < 0 ? 0 : damage_taken - armor;
        return damage;
    }

    public void push_me(Rigidbody2D RB, Vector2 push_force)
    {
        RB.AddForce(push_force);
    }
}
