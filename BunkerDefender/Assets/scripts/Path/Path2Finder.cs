using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path2Finder : MonoBehaviour {
    public int currentWayPoint = 0;
    public float speed;
    public string pathToFollow;

    private Transform targetWayPoint;
    private List<Transform> wayPointList;
    private Node[] Nodes;

    void Start()
    {
        Nodes = GameObject.Find(pathToFollow).GetComponentsInChildren<Node>();
        wayPointList = new List<Transform>();
        foreach (Node obj in Nodes)
            wayPointList.Add(obj.transform);
    }

    void Update()
    {
        if (currentWayPoint < wayPointList.Count)
        {
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            walk();
        }
        else
            Destroy(this.gameObject);
    }

    void walk()
    {
        // rotate towards the target
        Vector3 vectorToTarget = targetWayPoint.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);

        // move towards the target
        this.transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (this.transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            targetWayPoint = wayPointList[currentWayPoint];
        }
    }
}
