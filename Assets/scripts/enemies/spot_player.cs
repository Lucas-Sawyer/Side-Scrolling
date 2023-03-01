using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spot_player : MonoBehaviour
{
    public float range;
    public LayerMask mask;
    public bool saw_player;
    public float distance;
    public int direction;


    private GameObject exclamation, player;
    private Vector2 player_position;
    private flip flip;
    // Start is called before the first frame update
    void Start()
    {
        exclamation = transform.GetChild(0).gameObject;
        exclamation.SetActive(false);

        player = GameObject.Find("player").gameObject;

        flip = GetComponent<flip>();
    }

    // Update is called once per frame
    void Update()
    {
        player_position = player.transform.position;
        distance = transform.position.x - player_position.x;

        saw_player = Physics2D.OverlapCircle(transform.position, range, mask);
        if (saw_player)
        {
            exclamation.SetActive(true);
            if (transform.localScale.x > 0 && distance > 0 || transform.localScale.x < 0 && distance < 0)
            {
                flip.flip_me(transform.localScale.x, transform.localScale.y);
                direction = distance > 0 ? -1 : 1;
            }
        }
        else exclamation.SetActive(false);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
