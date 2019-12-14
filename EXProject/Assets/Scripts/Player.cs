using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 pos;
    public float speed;
    Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        rd.velocity = new Vector3(x, 0, 0);
    }
}
