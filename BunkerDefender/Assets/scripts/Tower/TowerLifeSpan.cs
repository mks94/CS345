using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerLifeSpan : MonoBehaviour {
    public int LifeCount;
    public static int KnightsToKill = 30;
    public static Text KnightLife;
    public Image towerhealthBar;
    public float stayBotton;
    private static int _startKnighCount;

    // Use this for initialization
    void Start () {
        KnightLife = GameObject.Find("Canvas/KnightLifeCount").GetComponent<UnityEngine.UI.Text>();
        _startKnighCount = KnightsToKill;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public static void HitKnight()
    {
        KnightsToKill--;
        KnightLife.text = (_startKnighCount - KnightsToKill).ToString();
        if (KnightsToKill == 0)
            SceneManager.LoadScene(2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "knight" || collision.gameObject.tag == "Knight")
        {
            LifeCount--;
            ReduceHealth();
            if (LifeCount == 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene(3);
            }
        }

    }

    private void ReduceHealth()
    {
        towerhealthBar.transform.localScale -= new Vector3(0, 0.1f, 0);
        towerhealthBar.transform.position += new Vector3(0, stayBotton, 0);
        if(LifeCount <= 5)
            towerhealthBar.color = new Color32(255, 0, 0, 255);
    }
}
