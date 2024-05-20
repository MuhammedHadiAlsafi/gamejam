using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class can : MonoBehaviour
{   
    public int sira;
    public GameObject player;
    
    void Start()
    {
    }

    void Update()
    {
        var atm = player.GetComponent<Damage>();
        if(sira > atm.can){
            Destroy(this.gameObject);
        }
    }
}
