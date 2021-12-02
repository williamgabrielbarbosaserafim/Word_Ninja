using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropador : MonoBehaviour
{
    public int dropado = 0;
    float aleatorio;
    float tempoGerado;
    public GameObject sakuraPrefab;
    GameObject sakuraAtual;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector3;
        vector3 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((Mathf.Sin(Time.time)) * 10, 17.5f, 0);
        aleatorio = Random.Range(5f, 10f);

        if ((Time.time - tempoGerado) > aleatorio)
        {
            gerarPowerUp();
            tempoGerado = Time.time;
        }

    }
    public void gerarPowerUp() //Instancia um objeto do jogo, no caso, a Sakura
    {
        sakuraAtual = Instantiate(sakuraPrefab, transform.position, Quaternion.identity);
    }
}
//Classe usada para soltar PowerUps