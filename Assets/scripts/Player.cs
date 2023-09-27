using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    Vector3 spawnPoint = new Vector3 (0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3();
        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        transform.position += input * speed * Time.deltaTime;

        transform.forward = input;
    }

    private void OnCollisionEnter(Collision other)
    {
        transform.position = spawnPoint;
    }


}
