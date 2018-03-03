using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerLifeSpan : MonoBehaviour {
    public int LifeCount;
    public static int KnightsToKill = 30;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void HitKnight()
    {
        KnightsToKill--;
        if(KnightsToKill == 0)
            SceneManager.LoadScene(2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "knight" || collision.gameObject.tag == "Knight")
        {
            LifeCount--;
            if (LifeCount == 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene(3);
            }
        }

    }
}
