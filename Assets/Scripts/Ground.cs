using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    
    public float moveSpeed = 5f;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Collector") {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        
    } //start

   
    void Update()
    {
        startMove();
    } //update

    void startMove() {
        transform.position += new Vector3((-moveSpeed*Time.deltaTime),0,0);
    }
} //class
