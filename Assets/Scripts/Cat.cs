using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float thrust;
    private Rigidbody2D catRigidbody;

    void Awake()
    {
        catRigidbody = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // transform.Translate(transform.right * Time.deltaTime * thrust);
        catRigidbody.AddForce(transform.right * thrust);
    }
}
