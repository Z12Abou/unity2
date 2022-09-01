using UnityEngine;

public class affichePo : MonoBehaviour
{
    [SerializeField] GameObject[] p1;
    bool trov = true;// fix problime repete fonction ;

    private void OnTriggerEnter(Collider other)
    {

        if (trov)
        {
            if (other.gameObject.tag == "Player")
            {
                if (skyboxSwitch.index == 0)
                {
                    Instantiate(p1[1]);
                    skyboxSwitch.index++;
                    trov = false;

                }
                else if (skyboxSwitch.index == 1)
                {
                    Destroy(GameObject.FindGameObjectWithTag("polices1"));

                    Vector3 v3 = new Vector3(GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.x, 5.62f, GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.y);
                    p1[0].gameObject.GetComponent<moveToPlater>().p2 = true;
                    Instantiate(p1[0], v3, Quaternion.identity);
                    trov = false;
                    
                }
            }
        }   
    }
}
