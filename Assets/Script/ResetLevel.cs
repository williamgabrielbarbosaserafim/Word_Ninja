using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    int pontuas;
    float tempoWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetLevel()//Define os atributos da fase para começar o level
    {
        GameObject win;
        win = GameObject.Find("Win");
        GameObject timer;
        Timer sTimer;
        timer = GameObject.Find("Timer");
        sTimer = timer.GetComponent<Timer>();
        GameObject pontuacao;
        Pontuacao sPontuacao;
        pontuacao = GameObject.Find("Pontuacao");
        sPontuacao = pontuacao.GetComponent<Pontuacao>();
        GameObject trampolim;

        trampolim = GameObject.Find("Trampolim");

        if(trampolim != null)
        {
            Destroy(trampolim);
        }
        

        if (win.transform.position.z == -1.7f)
        {
            sTimer.tempoCronometro = 30;
            sTimer.tempoFimFase += 5;
            sPontuacao.pontos = 0;
           
        }
        else
        {
            sTimer.tempoCronometro = (int)(30 - Time.time + sTimer.tempoFimFase);
        }
    }
}
//Reseta a fase para passar para o próxima