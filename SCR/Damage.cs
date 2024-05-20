using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class Damage : MonoBehaviour
{
    public float xmax;
    public float ymax;
    public float xmin;
    public float ymin;
    public GameObject obje;

    public int can;
    public int hasar;
    public GameObject you;
    private GameObject my;
    [SerializeField] TextMeshProUGUI puantext;
    private int puan=0;

    void Start() {
        my = GetComponent<GameObject>();
    }
    public void hasarAlma(int amount){
        can -= amount;
    }

    public void hasarVermek(GameObject hedef){
        var atm = hedef.GetComponent<Damage>();
        if(atm != null){
            atm.hasarAlma(hasar);
        }
    }

    
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="enemy"){
            GameObject deneme = other.gameObject;
            var atm = deneme.GetComponent<Damage>();
            if(atm != null){
                hasarAlma(atm.hasar);
            }
            if(can==0){
                go.scan("end");
            }
        }
    }
    void  OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="collectible"){
            puan++;
            puantext.text =  puan.ToString();
            var x = Random.Range(xmin,xmax);
            var y = Random.Range(ymin,ymax);
            var konum = new Vector2(x,y);
            Instantiate(obje,konum,quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
