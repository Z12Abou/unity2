using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Dreamteck.Forever;

public class codevalider : MonoBehaviour
{
    // Start is called before the first frame update
    public static string codetext;
    [SerializeField] InputField inputField;
    int k = 3;
    int lvl = 0;
    


    public void btnValider()
    {
        
        if (k > 0)
        {
            if (codetext == inputField.text.Trim())
            {
                Debug.Log("win");
                lvl++;
                PlayerPrefs.SetInt("startlvl", lvl);
                SceneManager.LoadScene(0);
                

            }
            else
            {
                k--;
            }
        }
        else
        {
            Debug.Log(" ;) lose");
            SceneManager.LoadScene(0);

        }

    }
}
