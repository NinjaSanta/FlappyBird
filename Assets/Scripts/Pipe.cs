using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5f;
    public AudioClip bling;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Collector") {
            Destroy(this.gameObject);
        }
   }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name == "Bird") {
            ScoreManager.instance.AddPoint();
            GetComponent<AudioSource> ().Play ();
    }
}

    void Start()
    {
        GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = bling;
    } //start

   
    void Update()
    {
        startMove();
    
    } //update

    void startMove() {
        transform.position += new Vector3((-moveSpeed*Time.deltaTime),0,0);
    }  
} //class