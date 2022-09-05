using UnityEngine;
using Dreamteck.Forever;
using MoreMountains.Feedbacks;

public class move : MonoBehaviour
{

    LaneRunner lr;
    Animator ani;
    [SerializeField] GameObject polise1;
    [SerializeField] GameObject polise2;
    [SerializeField] float JumpFoce;
    float time;
    bool statuSP;
    [SerializeField] GameObject ui;
    MMFeedbacks soundcoin;
    [SerializeField] LevelGenerator  lvlgen;
    [SerializeField] ParticleSystem particals;
    

    private void Awake()
    {
        lvlgen.startLevel = PlayerPrefs.GetInt("startlvl");
        lvlgen.Restart();
        Time.timeScale = 1;
    }

    void Start()
    {
      soundcoin = GameObject.FindGameObjectWithTag("soundcoin").GetComponent<MMFeedbacks>();
        lr = GetComponent<LaneRunner>();
        ani = GetComponent<Animator>();
        InvokeRepeating("AddspeedPlayer", 4, 2);
       

    }

    private void Update()
    {
        
    }
    // Update is called once per frame

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(lr.lane>2)
                lr.lane--;
        }
            
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (lr.lane < lr.laneCount-1)
                lr.lane++;
        }
       
        ani.SetBool("statuJump", false);
        ani.SetBool("statuSlide", false);

        if (Input.GetKey(KeyCode.UpArrow) )
        {
            ani.SetBool("statuJump", true);
            transform.Translate(0, JumpFoce, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            ani.SetBool("statuSlide", true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            other.gameObject.GetComponent<cion>().affecteCoin(particals.gameObject);
            soundcoin.PlayFeedbacks();
           
            Destroy(other.gameObject,0.2f) ;
        }

        if (other.gameObject.tag == "ui")
        {
            Time.timeScale = 0;
            ui.SetActive(true);
           
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {

        }
     
    }
   
    //public void AddspeedPlayer()
    //{
    //    if (lr.followSpeed <= 20)
    //    {
    //        lr.followSpeed++;
    //        Debug.Log("Add spped player ");
    //    }
       // 


    public void AddspeedPlayer()
    {
        if (lr.followSpeed <= 20)
        {
            lr.followSpeed++;
            Debug.Log("Add spped player ");
        }
        
    }

    public void SupparPaoire(GameObject playerEffect)
    {
        Instantiate(playerEffect, this.transform);
        Debug.Log("ok daze");
        
    }
   

}
   

