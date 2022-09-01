using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class code : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI txtCion;
    //[SerializeField] TextMeshProUGUI SupperP;
    [SerializeField] TextMeshProUGUI TimeGamer;
    [SerializeField] TextMeshProUGUI txtCode;
    string codetxt;
    int k=0;
    float time;

    void Start()
    {
        codetxt = Random.Range(100, 999).ToString();
        codevalider.codetext = codetxt;
            Debug.Log(codetxt);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        TimeGamer.text = Mathf.FloorToInt(time).ToString();
        if (k <= 2)
        {
        if (time >= 7)
        {
            txtCode.gameObject.SetActive(true);

            txtCode.text = codetxt[k].ToString();
            k++;
            time = 0;
            Invoke("afficherCode", 2);
        }
        }
     
       
    }
   
    public void afficherCode()
    {
        txtCode.gameObject.SetActive(false);
    }
}
