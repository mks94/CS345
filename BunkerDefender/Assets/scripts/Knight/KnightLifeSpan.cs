using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightLifeSpan : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet" || collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            TowerLifeSpan.HitKnight();
        }
            
    }
}
