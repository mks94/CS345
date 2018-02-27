using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLifeSpan : MonoBehaviour {
    private static int lifeCount = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "knight" || collision.gameObject.tag == "Knight")
        {
            lifeCount--;
            if (lifeCount == 0)
            {
                Destroy(this.gameObject);
                //Implement end game
            }
        }

    }
}
