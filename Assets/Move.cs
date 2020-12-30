using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Camera.main.transform.forward * Time.deltaTime *3f;
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Camera.main.transform.up * Time.deltaTime * 15f;
        }
    }
}
