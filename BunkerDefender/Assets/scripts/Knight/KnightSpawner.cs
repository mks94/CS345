using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightSpawner : MonoBehaviour {
    public GameObject Knight;
    public Vector3 SpawnPoint;
    public float Speed;

    private float _spawnCoolDown = 0.0f;
    private List<GameObject> Knights;
    private List<int> numbers = new List<int>() {3,4,5};
    private int count = 4;

	// Use this for initialization
	void Start () {
        Knights = new List<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Knights.Count == count)
        {
            //Wait a bit to spawn more
            Knights = new List<GameObject>();
            _spawnCoolDown = 3f;

            //Get Random number for how many in the group to spawn
            int num = Random.Range(0, 2);
            int count = numbers[num];
        }

        if (_spawnCoolDown <= 0f)
        {
            //How fast or condensed those groups spawn together
            float randomNumb = Random.Range(1f, 3f);
            _spawnCoolDown = randomNumb;
            GameObject se = GameObject.Instantiate(Knight);
            Knights.Add(se);
            se.transform.position = SpawnPoint;
        }
        else
            _spawnCoolDown -= Time.deltaTime;

    }
}
