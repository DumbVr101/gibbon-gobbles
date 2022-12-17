using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class horrornpc : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject destination;
    public GameObject[] objects;
    public Vector3 pos;
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("NetworkPlayer");
        objects = gos;
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance <= distance)
            {
                closest = go;
                distance = curDistance;               
            }
        }
        destination = closest;
        return closest;
    }
    void LateUpdate()
    {
        FindClosestEnemy();
        agent.SetDestination(destination.transform.position);
        pos = transform.position;
    }
}