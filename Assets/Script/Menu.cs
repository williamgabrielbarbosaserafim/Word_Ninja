using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public bool telaJogo;
    // Start is called before the first frame update
    void Start()
    {
        telaJogo = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sair()//Sai do jogo
    {
        Application.Quit();
    }
    public void credito()//(Incompleto) Entra na tela de credito do jogo
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TelaCreditos");
    }
    public void campanha()//Começa a campanha do jogo
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("WordNinja_Unity_2909");
        telaJogo = true;
    }
    public void treinamento()//(Incompleto) Entra na fase de treinamento
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TelaTreinamento");
    }
}
//Define os comandos para cada botão do menu