using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialDot : MonoBehaviour
{
    private PlayerController playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerScript.adv = true;
            Destroy(gameObject);
        }
    }
}
