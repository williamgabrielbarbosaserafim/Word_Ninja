using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropadorSakura : MonoBehaviour
{
    GameObject SakuraAtual;
    public GameObject PrefabSakura;
    float randomAltura;
    float tempo;
    // Start is called before the first frame update
    void Start()
    {
        randomAltura = Random.Range(-1, 3);
        tempo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        randomAltura = Random.Range(-6, 4);
        transform.position = new Vector3(-6, randomAltura, -1);
        gerarSakura();

    }
    void gerarSakura() //Instancia objetos (Petalas Sakuras) em função do tempo definido
    {
        if(Time.time - tempo >= 0.5f)
        {
            SakuraAtual = Instantiate(PrefabSakura, transform.position, Quaternion.identity);
            tempo = Time.time;
        }
        
    }
}
//Na tela de menu, cria várias petalas decorativas
