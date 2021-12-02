using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteracoesJson : MonoBehaviour
{
    TextEditor te;
    public string inputText;
    // Start is called before the first frame update
    void Start()
    {
        te = GetComponent<TextEditor>();
        inputText = te.text;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
//Classe para atribuir a objetos os dados da Json