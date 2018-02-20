using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSpawner : MonoBehaviour {
    private float _spawnCoolDown = 0.0f;

    public GameObject Knight;
    public Vector3 SpawnPoint;
    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (_spawnCoolDown <= 0f)
        {
            GameObject se = GameObject.Instantiate(Knight);
            se.transform.position = SpawnPoint;
            _spawnCoolDown = 5.0f;
        }
        else
            _spawnCoolDown -= Time.deltaTime;

    }
}
