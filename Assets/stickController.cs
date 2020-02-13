using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject stickHolder;
    public Vector3 axis;
    public float angle;
    void Update()
    {
        transform.RotateAround(stickHolder.transform.position, axis, angle);
    }
}
