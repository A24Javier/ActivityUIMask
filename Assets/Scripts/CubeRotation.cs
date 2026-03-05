using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * _speed);
    }
}
