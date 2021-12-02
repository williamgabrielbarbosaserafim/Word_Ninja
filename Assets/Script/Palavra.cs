using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palavra : MonoBehaviour
{
    float girox;
    float giroz;
    TextMesh tm;
    public EntradaTexto entradaTexto;
    GameObject gameover;
    float randomizacao;
    public int contText;
    public bool subir;
    float velocidade;
    float distancia;
    public int numDaPalavra;
    string palavraRecebida;
    GameObject pause;
    Pause sPause;
    GameObject GarraNeko;
    GameObject botaoPW;
    Poderes sPoderes;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Lamina" || col.tag == "GarraNeko" || col.tag == "Raio")
        {
            if(col.tag == "GarraNeko")
            {
                GameObject garraNeko;
                Neko sGarraNeko;
                Debug.Log("Destuido pela garra");
                garraNeko = GameObject.FindGameObjectWithTag("GarraNeko");
                sGarraNeko = garraNeko.GetComponent<Neko>();
                sGarraNeko.palavrasCortadas++;
            }
            if(col.tag == "Raio")
            {
                Debug.Log("Destruido por Raio");
            }
            Debug.Log("Destruiu Palavra");
            Destroy(this.gameObject);
            for (int i = 0; i <= entradaTexto.palavrasErradas.Length-1; i++) {
                if (tm.text == entradaTexto.palavrasErradas[i])
                {
                    GameObject vidaObj;
                    vidaObj = GameObject.Find("Vida");
                    Vida vida;
                    vida = vidaObj.GetComponent<Vida>();
                    vida.dano();
                    
                }
                else if(tm.text == entradaTexto.palavrasCertas[i])
                {
                    GameObject pontuacao;
                    Pontuacao sPontuacao;
                    
                    botaoPW = GameObject.Find("BotaoPW");
                    sPoderes = botaoPW.GetComponent<Poderes>();
                   
                    pontuacao = GameObject.Find("Pontuacao");
                    sPontuacao = pontuacao.GetComponent<Pontuacao>();
                    sPontuacao.pontos++;
                }
            }
            
        }
        if (col.gameObject.CompareTag("Trampolim") && subir == false)
        {
            subir = true;
            Debug.Log("Trampulou");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        pause = GameObject.Find("Pause");
        sPause = pause.GetComponent<Pause>();

        subir = true;
        palavraRecebida = entradaTexto.palavrasCertas[1];

        numDaPalavra = Mathf.RoundToInt(Random.Range(0, 9));

        tm = GetComponent<TextMesh>();
        tm.anchor = TextAnchor.MiddleCenter;

        randomizacao = Random.Range(0.01f, -0.01f);

        if (transform.position.x > 0)
        {
            randomizacao += transform.position.x * -0.01f / 5f;
        }
        else if (transform.position.x < 0)
        {
            randomizacao += transform.position.x * -0.01f / 2f;
        }
        girox = Random.Range(0.05f, 0.1f);
        giroz = Random.Range(0.1f, 0.5f);

        if (numDaPalavra % 2 == 0)
        {
            int numPalavraCerta = Random.Range(0, entradaTexto.palavrasCertas.Length);
            tm.text = entradaTexto.palavrasCertas[numPalavraCerta];
            contText = tm.text.Length;
        }
        else if(numDaPalavra % 2 != 0)
        {
            int numPalavraErrada = Random.Range(0, entradaTexto.palavrasErradas.Length);
            tm.text = entradaTexto.palavrasErradas[numPalavraErrada];
            contText = tm.text.Length;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > -9.8)
        {
            tag = "Instanciado";
        }
        if (sPause.pausado)
        {
            transform.Rotate(0, 0, 0);
            transform.position += new Vector3(0, 0, 0);
        }
        else
        {
            transform.Rotate(girox, 0, giroz);
            transform.position += new Vector3(randomizacao, 0, 0);
        }
        
        parabola();
        
        
        destruirObj();
        //corAleatoria();

    }

    void destruirObj()//Destroi a palavra
    {
        if (transform.position.y < -18)
        {
            Destroy(gameObject);
        }
    }

    void parabola()//Define a trajetoria que o objeto tomara após ser instanciado
    {
        distancia = 7.7f - transform.position.y;
        if (transform.position.y >= 7.7f)
        {
            subir = false;
        }
        if(subir)
        {
            velocidade = 2 * distancia + 1;
            transform.position = transform.position + new Vector3(0, velocidade, 0) * Time.deltaTime;
        }
        else if(subir == false)
        {
            velocidade = -2 * distancia - 2;
            transform.position = transform.position + new Vector3(0, velocidade, 0) * Time.deltaTime;
        }
    }
    void corAleatoria()//(Incompleto) muda aleatoriamente a cor da palavra
    {
        int corRandomizada;
        //Color[] cores = new Color[] { Color.cyan, Color.red, Color.black, Color.yellow, Color.blue, Color.white, Color.green};
        Color[] cores = new Color[] {Color.black, Color.white, Color.gray, Color.gray};
        corRandomizada = (int) Random.Range(0, 4);
        tm.color = cores[corRandomizada];
    }
}
// Define as caracteristicas do objeto palavra, o qual contem a string vinda do arquivo Json, num espaço tridimensional