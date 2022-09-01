using Dreamteck.Forever;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveToPlater : MonoBehaviour
{
    LaneRunner player;
    LaneRunner polise;
    public bool p2;
    int speed;
    private void Start()
    {
        if (p2)
        {
            InvokeRepeating("addSpeedToPolices", 0, 2);
            skyboxSwitch.sky2 = true;
        }
        else
        {
            InvokeRepeating("addSpeedToPolices", 4, 3);
        }
        polise = GetComponent<LaneRunner>();
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<LaneRunner>();
    }


    void Update()
    {
        polise.lane = player.lane;

        
    }
   public void addSpeedToPolices()
    {
        polise.followSpeed++;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            SceneManager.LoadScene(0);
            skyboxSwitch.index = 0;
            skyboxSwitch.sky2 = false;

        }
    }
   
}
