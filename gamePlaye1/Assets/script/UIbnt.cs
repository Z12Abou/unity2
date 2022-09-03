using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] InputField codesafe;
    string code = "";

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

}
