using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increase : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    void Update()
    {
        transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * _increaseSpeed;
    }
}
