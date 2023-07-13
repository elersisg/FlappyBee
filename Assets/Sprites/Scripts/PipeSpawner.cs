using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float _maxTime = 1.5f;
    public float _heightRange = 0.45f;
    public GameObject _pipe;

    private float _timer;

    private void Start()
    {
        SpawnPipe();
    }


    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
