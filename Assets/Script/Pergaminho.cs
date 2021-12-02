using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pergaminho : MonoBehaviour
{
    GameObject papelPergaminho;
    GameObject lamina;
    bool aberto = false;

    // Start is called before the first frame update
    void Start()
    {
        lamina = GameObject.Find("Lamina");
        papelPergaminho = GameObject.Find("PapelPergaminho");

    }

    // Update is called once per frame
    void Update()
    {
        if (lamina.transform.position.y < -13)
        {
            abrirfecharPergaminho();
        }

    }

    void abrirfecharPergaminho()//Recebe o input do mouse em uma area pre definida para abrir ou fechar o pergaminho
    {
        if (Input.GetMouseButtonUp(0) && aberto == false && lamina.transform.position.y <= -13)
        {
            aberto = true;
            for (int i = 0; transform.position.y <= -13; i++)
            {
                transform.position = transform.position + new Vector3(0, i / 100, 0) * Time.deltaTime;
            }
        }
        else if (Input.GetMouseButtonUp(0) && aberto == true && lamina.transform.position.y <= -13)
        {
            aberto = false;
            for (int i = 0; transform.position.y >= -14.5f; i++)
            {
                transform.position = transform.position - new Vector3(0, i / 100, 0) * Time.deltaTime;
            }
        }

    }
}
//Define as caracteristicas do pergaminho onde se lê qual o tema das palavras a serem cortadas