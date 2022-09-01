using Dreamteck.Forever;
using UnityEngine;
using MoreMountains.Feedbacks;

public class obstacleToPlayer : MonoBehaviour
{
    [SerializeField] bool isDeathPlayer;
    [SerializeField] bool frizePlayer;
    [SerializeField] bool speedTime;
    MMFeedbacks shaking;
    LaneRunner Player;
     void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<LaneRunner>();
        shaking = GameObject.FindGameObjectWithTag("shaking").GetComponent<MMFeedbacks>();
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            if (Player.followSpeed > 2)
            {
                Player.followSpeed -= 2;
                shaking.PlayFeedbacks();

            }
        }
    }
    
}
