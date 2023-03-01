using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    public void flip_me(float scale_x, float scale_y)
    {
        transform.localScale = new Vector2(scale_x * -1, scale_y);
    }
}
