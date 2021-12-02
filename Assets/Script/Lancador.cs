using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancador : MonoBehaviour
{
    public GameObject textoPrefab;
    GameObject textoAtual;
    public GameObject envolucroPrefab;
    GameObject envolucroAtual;
    GameObject level;
    Level sLevel;
    GameObject win;

    float deucerto;
    float tempo;
    float aleatorio;
    float tempoGerado;
    float dificuldadeFase;

    // Start is called before the first frame update
    void Start()
    {
        level = GameObject.Find("Level");
        sLevel = level.GetComponent<Level>();
        win = GameObject.Find("Win");
        Vector3 vector3;
        vector3 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dificuldadeFase = sLevel.numFase / 5;
        transform.position = new Vector3((Mathf.Sin(Time.time))*20 , -17.5f, -1);
        aleatorio = Random.Range(2.2f, 2.5f) - dificuldadeFase;

        if (Time.time == 0 || (Time.time - tempoGerado) > aleatorio && win.transform.position.z != -1.7f)
        {
            textoAtual = Instantiate(textoPrefab, transform.position, Quaternion.identity);
            envolucroAtual = Instantiate(envolucroPrefab, transform.position, Quaternion.identity);
            tempoGerado = Time.time;
        }
  
    }
    void lancarTxt(float x)//Instancia um nomvo arquivo de texto e seu envolucro
    {
        if(transform.position.x %1 == 0 || transform.position.x % -1 == 0)
        {
            deucerto += 1;
            textoAtual = Instantiate(textoPrefab, transform.position, Quaternion.identity);
            envolucroAtual = Instantiate(envolucroPrefab, transform.position, Quaternion.identity);
        }
    }
}
//É vinculado com um objeto que instancia novos objetos que se propelem de forma parabolica