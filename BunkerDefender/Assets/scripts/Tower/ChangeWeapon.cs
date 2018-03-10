using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeWeapon : MonoBehaviour {
    public GameObject Gun;
    public GameObject Cannon;
    public GameObject Bomb;
    public Image GunImage;
    public Image CannonImage;
    public Text Weapon;

	// Use this for initialization
	void Start () {
        Weapon.text = "<b>Gun</b>";
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1"))
        {
            Gun.SetActive(true);
            Cannon.SetActive(false);
            GunImage.enabled = true;
            CannonImage.enabled = false;
            Weapon.text = "<b>Gun</b>";
        }
        else if (Input.GetKeyDown("2"))
        {
            Gun.SetActive(false);
            Cannon.SetActive(true);
            GunImage.enabled = false;
            CannonImage.enabled = true;
            Weapon.text = "<b>Cannon</b>";
        }

    }
}
