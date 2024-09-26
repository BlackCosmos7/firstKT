using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Fire : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
