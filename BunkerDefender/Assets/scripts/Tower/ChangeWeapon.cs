using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour {
    public GameObject Gun;
    public GameObject Cannon;
    public GameObject Bomb;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1"))
        {
            Gun.SetActive(true);
            Cannon.SetActive(false);
            Bomb.SetActive(false);
        }
        else if (Input.GetKeyDown("2"))
        {
            Gun.SetActive(false);
            Cannon.SetActive(true);
            Bomb.SetActive(false);
        }
        else if (Input.GetKeyDown("3"))
        {
            Gun.SetActive(false);
            Cannon.SetActive(false);
            Bomb.SetActive(true);
        }

    }
}
