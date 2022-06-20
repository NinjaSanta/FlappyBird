using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlap : MonoBehaviour
{
    
    private Animator anim;

    [SerializeField]
    public float flapForce = 10f;

    private Rigidbody2D myBody;

    private void Awake() {

        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }//awake
    void Start()
    {
        
    } //start


    void Update()
    {
        Flap();
        AnimateBird();

    } //update

    void Flap() {
        if (Input.GetButtonDown("Jump")){
            myBody.AddForce(new Vector2(0f,flapForce),ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Pipe") {
            Destroy(this.gameObject);
        }
    }

    void AnimateBird() {
        if (Input.GetButtonDown("Jump")) {
            anim.SetBool("Flap", true);
        }
        else {
            anim.SetBool("Flap", false);
        }
    }
}//class
