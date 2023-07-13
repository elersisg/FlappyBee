using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotationFalling : MonoBehaviour
{
    public float velocidadDeRotacion = 10f;

    public Rigidbody2D rb;

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * velocidadDeRotacion);
    }
}
