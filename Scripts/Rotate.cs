using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotatingSpeed;

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * _rotatingSpeed, 0, Space.Self);
    }
}
