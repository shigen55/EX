using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boll : MonoBehaviour
{
    public Player player;
    Vector3 startpos;
    Rigidbody rd;
    public float speed;
    public float wollHitSpeed;

    // Start is called before the first frame update
    void Start()
    {
        startpos = new Vector3(player.transform.position.x, player.transform.position.y + 5, 0);
        rd = GetComponent<Rigidbody>();
        rd.AddForce((transform.up + transform.right) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=2)
        {
            transform.position = startpos;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
