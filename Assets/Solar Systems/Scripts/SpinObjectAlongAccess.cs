using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectAlongAccess : MonoBehaviour
{
    [SerializeField] private Vector3 axis;
    [SerializeField] private float speed;


    void Start()
    {
         
    }

    
    void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime);
    }
}
