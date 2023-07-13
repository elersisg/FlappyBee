using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxMovement : MonoBehaviour
{
    public float _paralaxSpeed;

    void Update()
    {
        float xPosition = transform.position.x;
        if (xPosition > ParallaxManager.Instance.GetParalaxPivot().position.x * 2)
        {
            transform.position = new Vector3(xPosition - _paralaxSpeed * ParallaxManager.Instance.GetSpeedMultiplier() * Time.deltaTime,
                transform.position.y, transform.position.z);
        }

        else
        {
            transform.position = new Vector3(transform.position.x + (17.95f * 2),
                transform.position.y, transform.position.z);
        }
    }
}
