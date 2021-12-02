using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fases : MonoBehaviour
{
    GameObject fase;
    GameObject win;
    Level sLevel;
    public int faseAtual = 1;
    Vitoria vitoria;
    // Start is called before the first frame update
    void Start()
    {
        win = GameObject.Find("Win");
        fase = GameObject.Find("Level");
        sLevel = fase.GetComponent<Level>();
        vitoria = win.GetComponent<Vitoria>();
    }

    // Update is called once per frame
    void Update()
    {
        faseAtual = 1 + vitoria.numVitoria;
    }
    public class Fase //Clase com caracteristica das possiveis fases
    {
        private int numero;
        private float tempo;
        private int numPalavrasAAcertar;
        private bool completada = false;

        int getNumero()
        {
            return this.numero;
        }
        public float getTempo()
        {
            return this.tempo;
        }
        public int getNumPalavrasAAcertas()
        {
            return this.numPalavrasAAcertar;
        }
        public bool getCompletada()
        {
            return this.completada;
        }
        public void setTempo(float time)
        {
            tempo = time;
        }
        public void setNumPalavrasAAcertar(int numPalavras)
        {
            numPalavrasAAcertar = numPalavras;
        }

    }
}
//Classe que contem os atributos da fase