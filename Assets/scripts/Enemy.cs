using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * Time.deltaTime;
        transform.forward = moveDirection;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "level") return;

        moveDirection= -moveDirection;


    }
}
