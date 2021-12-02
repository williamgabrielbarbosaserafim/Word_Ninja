using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raio : MonoBehaviour
{
    public GameObject palavra;
    Palavra sPalavra;
    TrailRenderer tr;
    EntradaTexto entradaTexto;

    public float altura;

    float tragetoriaRaio = 0;
    float deltaAltura;
    int raio;
    // Start is called before the first frame update
    void Start()
    {
        raio = 0;
        altura = transform.position.y;
        tr = GetComponent<TrailRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(raio <= 2)
        {
            atingirComRaio();
        }
        
        
    }
    public void atingirComRaio()
    {
        tragetoriaRaio = Random.Range(-5f, 5f);

        palavra = GameObject.FindGameObjectWithTag("Instanciado");
        if (palavra != null)
        {
            sPalavra = palavra.GetComponent<Palavra>();
            for (int i = 0; i < sPalavra.entradaTexto.palavrasCertas.Length; i++)
            {
                if (palavra.GetComponent<TextMesh>().text == sPalavra.entradaTexto.palavrasCertas[i] && sPalavra.subir == false)
                {
                    
                    deltaAltura = transform.position.y - palavra.transform.position.y / 4;

                    /*if (transform.position.y - palavra.transform.position.y > 1)
                    {
                        tr.emitting = true;
                         transform.position -= new Vector3(tragetoriaRaio, deltaAltura, 0) * Time.deltaTime * 10;

                    }
                    else
                    {
                         palavra = GameObject.FindGameObjectWithTag("Instanciado");
                         transform.position = palavra.transform.position;

                    }*/
                    tr.emitting = true;
                    transform.position = palavra.transform.position;

                }
            }
        }
        raio++;
        Destroy(gameObject, 0.5f);
    }
}
