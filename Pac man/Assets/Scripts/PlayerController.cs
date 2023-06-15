using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool adv = false;
    public int time;
    private float timeGo;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        TimeGo();
    }
    void Move()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(mh,0f,mv);
        playerRb.velocity = move * speed;
    }
    void TimeGo()
    {
        if(adv) 
        {
            timeGo += Time.deltaTime;
            time = Mathf.RoundToInt(timeGo);
            if(time == 8)
            {
                adv = false;
                timeGo = 0;
                time = 0;
            }
        }
    }
}
