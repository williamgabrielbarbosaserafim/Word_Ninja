using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    

    public int pontos = 0;
    public string teste;
    TextMesh tm;
    GameObject win;
    Vitoria sWin;
    // Start is called before the first frame update
    void Start()
    {
        win = GameObject.Find("Win");
        sWin = win.GetComponent<Vitoria>();
        tm = GetComponent<TextMesh>();
        tm.text = pontos.ToString();
        tm.fontSize = 18;
    }

    // Update is called once per frame
    void Update()
    {
        tm.text = pontos.ToString() + "/" + sWin.aCortar.ToString();
    }
}
// Imprime para o usuario qual é a pontuação em um objeto de texto 