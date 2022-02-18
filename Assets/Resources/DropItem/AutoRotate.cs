using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    //
    [SerializeField]
    float speed;
    [SerializeField]
    Vector3 angle;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angle * speed * Time.deltaTime);
    }
}
