using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitoria : MonoBehaviour
{
    GameObject pontuacao;
    Pontuacao sPontuacao;
    GameObject level;
    Level sLevel;
    public int aCortar;
    public int numVitoria = 0;
    public float tempoExibicao = 0;
    public float testeTempo;

    // Start is called before the first frame update
    void Start()
    {
        aCortar = 5;
        level = GameObject.Find("Level");
        sLevel = level.GetComponent<Level>();
        pontuacao = GameObject.Find("Pontuacao");
        sPontuacao = pontuacao.GetComponent<Pontuacao>();
        transform.position = new Vector3(0, 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        win();
    }
    public void win()//Acrescenta um ao numero de vitorias quando a fase é concluida, e move o objeto win
    {
        aCortar = sLevel.numFase + 2;
        GameObject level;
        ResetLevel sResetLevel;
        level = GameObject.Find("Level");
        sResetLevel = level.GetComponent<ResetLevel>();
        GameObject win;
        win = GameObject.Find("Win");
        if(win.transform.position.z >= 10 && sPontuacao.pontos >= aCortar)
        {
            numVitoria++;
            win.transform.position = new Vector3(0, 0, -1.7f);
            tempoExibicao = Time.time;
        }
        testeTempo = Time.time - tempoExibicao;
        if(Time.time - tempoExibicao >= 5)
        {
            sResetLevel.resetLevel();
            win.transform.position = new Vector3(0, 10, 10);
        }
        
    }
}
//Estabelece que todos os requisitos para a conclusão do nivel, e imprime na tela quando o mesmo é concluido