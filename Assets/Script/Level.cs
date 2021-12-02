using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    TextMesh tm;
    GameObject win;
    Vitoria sVitoria;
    public int numFase = 1;
    // Start is called before the first frame update
    void Start()
    {
        win = GameObject.Find("Win");
        sVitoria = win.GetComponent<Vitoria>();
    }

    // Update is called once per frame
    void Update()
    {
        numLevel();
    }
    public void numLevel()//Define o texto do objeto que mostra a fase atual
    {
        tm = GetComponent<TextMesh>();
        numFase = 1 + sVitoria.numVitoria;
        tm.text = ("LEVEL " + numFase);
    }
}
//Esta classe possui os atributos relacionados a vizualização do Level