using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class PASpeed : MonoBehaviour
{
    LaneRunner lr;
    public bool salaSpeed;
    float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        lr = GameObject.FindGameObjectWithTag("Player").GetComponent<LaneRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(move.klaSpeed==true&&timer>0)
        {
            speed();
            timer -= Time.deltaTime;
        }
        else if(timer<=0)
        {
            move.klaSpeed = false;
        }
        
    }
    public void speed()
    {
        lr.followSpeed=lr.followSpeed+5;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            move.klaSpeed = true;
        }
    }
}
