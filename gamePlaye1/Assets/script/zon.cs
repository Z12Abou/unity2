using UnityEngine;
using UnityEngine.SceneManagement;

public class zon : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
            skyboxSwitch.index = 0;
            skyboxSwitch.sky2 = false;

        }
           
           

    }
}
