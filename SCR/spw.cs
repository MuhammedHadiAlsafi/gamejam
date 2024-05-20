using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class spw : MonoBehaviour
{
    // Start is called before the first frame update
    public float xmax;
    public float ymax;
    public float xmin;
    public float ymin;
    public GameObject obje;
    private int puanh;

    public void spwF(int puan){
        if(puan%10==0){
            var x = Random.Range(xmin,xmax);
            var y = Random.Range(ymin,ymax);
            var konum = new Vector2(x,y);
            Instantiate(obje,konum,quaternion.identity);
            this.puanh=0;
        }
    }
}
