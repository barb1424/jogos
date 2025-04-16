using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class rotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform Target;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.up, 50 * Time.deltaTime);
    }
}
