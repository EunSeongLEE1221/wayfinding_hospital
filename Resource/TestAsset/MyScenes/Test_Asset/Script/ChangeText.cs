using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text textObject;

    // Start is called before the first frame update
    void Start()
    {
        
        
        //Text textObject = GameObject.Find("textObject");
    }

    // Update is called once per frame
    void Update()
    {
        textChange(Variable.global);
    }

    public void textChange(int num)
    {
        if (num == 0)
        {
            textObject.text = "<b><color=#FF7F27>�Ʊ⸦</color> ������</b>";
        }
        else if (num == 1)
        {
            textObject.text = "<b><color=#ED1C24>�帱��</color> ������</b>";
        }
    }
}
