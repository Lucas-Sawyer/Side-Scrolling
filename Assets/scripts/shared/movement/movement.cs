using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector2 walk(int direction, float speed, float y)
    {
        Vector2 move = new Vector2(direction * speed, y);
        return move;
    }
}
