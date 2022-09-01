using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxSwitch : MonoBehaviour
{
    [SerializeField] Material[] m;
    public static int index=0;
    public static bool sky2;
    void Start()
    {
            RenderSettings.skybox = m[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (sky2)
        {
            RenderSettings.skybox = m[1];

        }
    }
}
