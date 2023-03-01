using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public bool punching, shooting;

    private animations animations;
    private spaw_prefab spaw_prefab;
    private stats stats;
    private GameObject shoot_effect, bullet;
    private Vector3 spaw_position;
    private bool can_shoot = true;
    private float time = 0, shoot_delay;
    // Start is called before the first frame update
    void Start()
    {
        animations = GetComponent<animations>();
        spaw_prefab = GetComponent<spaw_prefab>();
        stats = GetComponent<stats>();

        shoot_effect = Resources.Load("prefab/shoot_effect") as GameObject;
        bullet = Resources.Load("prefab/bullet") as GameObject;

        shoot_delay = stats.shoot_delay;
    }

    // Update is called once per frame
    void Update()
    {
        spaw_position = transform.GetChild(0).transform.position;

        if (!can_shoot && time < shoot_delay)
        {
            time++;
        }
        if (time >= shoot_delay)
        {
            shooting = false;
            can_shoot = true;
            time = 0;
        }
    }

    public void start_attack()
    {
        if (animations.armed && can_shoot)
        {
            shooting = true;
            spaw_prefab.spaw(shoot_effect, spaw_position);
            spaw_prefab.spaw(bullet, spaw_position);
            can_shoot = false;
        }
        if (!animations.armed)
        {
            punching = true;
        }
    }
}
