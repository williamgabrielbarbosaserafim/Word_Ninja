using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neko : MonoBehaviour
{
    Rigidbody2D rb2;
    TrailRenderer tr;
    public GameObject palavra;
    GameObject botaoPW;
    Poderes sPoderes;
    public EntradaTexto entradaTexto;

    public string palavraDoMesh;
    public string palavraComparacao;
    public int match = 0;
    public int dentroDoRange = 0;
    
    public int palavrasCortadas;
    // Start is called before the first frame update
    void Start()
    {
        botaoPW = GameObject.Find("BotaoPW");
        sPoderes = botaoPW.GetComponent<Poderes>();
        palavrasCortadas = 0;
        rb2 = GetComponent<Rigidbody2D>();
        rb2.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        cortar();
        movimentacaoGarra();
        destruirNeko();
    }
    void cortar()
    {
        GameObject neko;
        Palavra sPalavra;

        tr = GetComponent<TrailRenderer>();
        neko = GameObject.FindGameObjectWithTag("Neko");
        palavra = GameObject.FindGameObjectWithTag("Instanciado");
        if(palavra != null)
        {
            sPalavra = palavra.GetComponent<Palavra>();
            palavraDoMesh = palavra.GetComponent<TextMesh>().text;
            for (int i = 0; i < entradaTexto.palavrasCertas.Length; i++)
            {
                palavraComparacao = entradaTexto.palavrasCertas[i];
                if(palavraDoMesh == palavraComparacao)
                {
                    match++;
                }
                if (palavra.GetComponent<TextMesh>().text == entradaTexto.palavrasCertas[i] && sPalavra.subir == false)
                {
                    if (palavra.transform.position.y < neko.transform.position.y + 20 && palavra.transform.position.y > neko.transform.position.y -20 && palavra.transform.position.x < neko.transform.position.x + 20 && palavra.transform.position.x > neko.transform.position.x - 20)
                    {
                        dentroDoRange++;
                        rb2.simulated = true;
                        transform.position = new Vector3(palavra.transform.position.x + 1, palavra.transform.position.y, transform.position.z);
                        transform.position = new Vector3(palavra.transform.position.x, palavra.transform.position.y, transform.position.z);
                        transform.position = new Vector3(palavra.transform.position.x -1, palavra.transform.position.y, transform.position.z);

                        tr.emitting = false;
                    }
                    else
                    {
                        tr.emitting = true;
                        rb2.simulated = false;
                    }
                    
                    
                }
            }
        }
        
        
    }
    void movimentacaoGarra()
    {
        GameObject neko;
        neko = GameObject.FindGameObjectWithTag("Neko");
        transform.position = new Vector3((neko.transform.position.x + 2 )+(Mathf.Sin(Time.time) * 0.5f), (neko.transform.position.y)+(Mathf.Cos(Time.time) * 0.5f), 0);
    }
    void destruirNeko()
    {
        GameObject neko;
        neko = GameObject.Find("Neko");
        if (palavrasCortadas == 3)
        {
            sPoderes.nekoInstanciado = false;
            Destroy(neko);
        }
    }
}
