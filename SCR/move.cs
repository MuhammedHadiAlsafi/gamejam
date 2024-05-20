using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 15;
    private bool attack= false;

    private Rigidbody2D r2d; 
    private Animator anim;
    private Vector3 v;
    private Vector2 v2;
    private SpriteRenderer spr;
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr =  GetComponent<SpriteRenderer>();
        v = transform.position;
    }

    void FixedUpdate() {
        if(!attack){
            r2d.MovePosition(r2d.position+ v2 * speed * Time.fixedDeltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        v2.x = Input.GetAxis("Horizontal");
        v2.y = Input.GetAxis("Vertical");
        //if(Input.GetButtonDown(KeyCode.a)!=0){}
        anim.SetFloat("Horizontal",v2.x);
        anim.SetFloat("Vertical",v2.y);
        anim.SetFloat("speed",v2.sqrMagnitude);
    }
}
