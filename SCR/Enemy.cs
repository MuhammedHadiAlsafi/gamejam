using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float sinyal;
    
    private Animator anim;
    private float distance;
    void Start()
    {
        anim = GetComponent<Animator>();
        //player.name = "player";
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position,player.transform.position);
        Vector2 direcyion = player.transform.position - transform.position;
        if(distance < sinyal){
            transform.position = Vector2.MoveTowards(this.transform.position,player.transform.position,speed*Time.deltaTime);
            anim.SetFloat("Horizontal",direcyion.x);
            anim.SetFloat("Vertical",direcyion.y);
            anim.SetFloat("speed",direcyion.sqrMagnitude);
            }
        else{
            anim.SetFloat("speed",0);
        }
    }
}
