using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource aud;
    void Start()
    {
        aud = GetComponent<AudioSource>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "stairs")
        {
            aud.Play();
        }
    }
}
