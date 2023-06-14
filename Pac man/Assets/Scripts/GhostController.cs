using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent ghost;

    // Start is called before the first frame update
    void Start()
    {
        ghost = GetComponent<NavMeshAgent>();  
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        ghost.destination = player.position;
    }
}
