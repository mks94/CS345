using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour {
    private Node[] _nodes;
    private Path path;
    private int _currentNode;
    private Vector3 _position;
    private float _time;

    //public GameObject Knight;
    public float Speed;

	// Use this for initialization
	void Start () {
        _nodes = GameObject.Find("Path").GetComponentsInChildren<Node>();
    }

    // Update is called once per frame
    void Update () {
        if (_currentNode == _nodes.Length)
            Destroy(this.gameObject);

        _position = _nodes[_currentNode].transform.position;
        _time += Time.deltaTime * Speed;
        if (this.transform.position != _position)
            this.transform.position = Vector3.Lerp(this.transform.position, _position, _time);
        else
        {
            _currentNode++;
            _time = 0;
        }

    }
}
