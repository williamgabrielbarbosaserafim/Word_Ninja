using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPower : MonoBehaviour
{
    Poderes poderes;
    GameObject lamina;
    bool tocouBotao;
    public bool usarPU;
    // Start is called before the first frame update
    void Start()
    {
        usarPU = false;
        tocouBotao = false;
        transform.position = new Vector3(23, -12, 5);
    }

    // Update is called once per frame
    void Update()
    {
        liberarPoder();
        pressionarBotao();
    }
    void liberarPoder()
    {
        poderes = GetComponent<Poderes>();
        if(poderes.powerUp != 0)
        {
            transform.position = new Vector3(23, -12, 0);
        }
        else
        {
            transform.position = new Vector3(23, -12, 5);
        }
    }
    void pressionarBotao()
    {
        lamina = GameObject.Find("Lamina");
        if ((lamina.transform.position.x < transform.position.x + 2 && lamina.transform.position.x > transform.position.x - 2) && (lamina.transform.position.y < transform.position.y + 2 && lamina.transform.position.y > transform.position.y -2)&& transform.position.z == 0)
        {
            tocouBotao = true;
            transform.localScale = new Vector3(6.5f, 0.02f, 6.1f);
            if (Input.GetMouseButtonDown(0))
            {
                usarPU = true;
                
            }
        }
        else
        {
            tocouBotao = false;
            transform.localScale = new Vector3(5.2f, 0.02f, 4.89f);
        }
    }
}
//Classe que será usada para ativar os PowerUps