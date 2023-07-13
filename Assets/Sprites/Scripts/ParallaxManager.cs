using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxManager : MonoBehaviour
{
    public Transform _paralaxPivot;
    public float _speedMultiplier;

    public static ParallaxManager Instance;

    public Transform GetParalaxPivot() =>_paralaxPivot;

    public float GetSpeedMultiplier() =>_speedMultiplier;

    private void Awake()
    {
        Instance = this;    
    }

    private IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
        }
    }
}
