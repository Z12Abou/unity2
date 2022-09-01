using UnityEngine;

public class switshColore : MonoBehaviour
{
    [SerializeField] Material[] m;
    Renderer rend;
   public static bool SupperP=true;
    void Start()
    {
        this.gameObject.SetActive(false);
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (SupperP)
        {
            rend.material = m[2];
        }
     
    }
}
