using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisileController : MonoBehaviour
{
    public float misileSpeed;
    public Rigidbody2D rbMisile;

    // Start is called before the first frame update
    void Start()
    {
        rbMisile.velocity = transform.right * misileSpeed;
    }
}
