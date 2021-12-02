using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema : MonoBehaviour
{
    private string input;
    TextMesh tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if(input != null)
        {
            tm.text = input;
        }
        
    }
    public void readStringInput(string s)
    {
        input = s;
    }
}
//Mostra para o usuário, qual o tema relacionado ao jogo
