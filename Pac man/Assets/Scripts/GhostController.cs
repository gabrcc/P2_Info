using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent ghost;
    public Transform start;
    private PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        ghost = GetComponent<NavMeshAgent>();  
        playerScript = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveGh();
    }
    void MoveGh()
    {
        if(playerScript.adv == true)
        {
            ghost.destination = start.position;
        }
        if(playerScript.adv == false)
        {
            ghost.destination = player.position;
        }
    }
}
