using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pausado;
    // Start is called before the first frame update
    void Start()
    {
        pausado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(pausado == false)
            {
                pause();
                pausado = true;
            }
            else
            {
                unpause();
                pausado = false;
            }
        }
    }
    void pause()//Pausa o jogo
    {
        Time.timeScale = 0;
    }
    void unpause()//Despausa o jogo
    {
        Time.timeScale = 1;
    }
}
// Classe responsavel por pausar o jogo