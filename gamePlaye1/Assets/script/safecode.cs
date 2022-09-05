using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Dreamteck.Forever;

public class safecode : MonoBehaviour
{
    // Start is called before the first frame update
    public static string codetext;
    [SerializeField] InputField codesafe;
    [SerializeField] GameObject pausepanel;
    [SerializeField] GameObject btnpause;
    string code = "";
    int k = 3;
    int lvl = 0;
    public void btnValider()
    {
        
        if (k > 0)
        {
            if (codetext == codesafe.text.Trim())
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
    public void btn0()
    {
        code = code + 0;
        codesafe.text = code;
    }
    public void btn1()
    {
        code = code + 1;
        codesafe.text = code;
    }
    public void btn2()
    {
        code = code + 2;
        codesafe.text = code;

    }
    public void btn3()
    {
        code = code + 3;
        codesafe.text = code;

    }
    public void btn4()
    {
        code = code + 4;
        codesafe.text = code;

    }
    public void btn5()
    {
        code = code + 5;
        codesafe.text = code;

    }
    public void btn6()
    {
        code = code + 6;
        codesafe.text = code;

    }
    public void btn7()
    {
        code = code + 7;
        codesafe.text = code;

    }
    public void btn8()
    {
        code = code + 8;
        codesafe.text = code;

    }
    public void btn9()
    {
        code = code + 9;
        codesafe.text = code;

    }
    public void delete()
    {
        codesafe.text = "";
        code = "";
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pausepanel.SetActive(true);
        btnpause.SetActive(false);
    }
    public void resume()
    {
        Time.timeScale = 1;
        pausepanel.SetActive(false);
        btnpause.SetActive(true);
    }
    public void exit()
    {
        
    }
}
