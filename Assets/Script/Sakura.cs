using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sakura : MonoBehaviour
{
    Rigidbody2D rb2;
    public GameObject botaopw;
    Poderes sBotaoPW;
    public Vector3 rotacao;

    private void OnTriggerEnter2D(Collider2D col)//Verica a colisão do powerup com a lamina
    {
        if (col.tag == "Lamina")
        {
            Debug.Log("Destruiu");
            atribuirPoder();
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rotacao = new Vector3(Random.Range(1, 4), Random.Range(1, 4), 0);
    }

    // Update is called once per frame
    void Update()
    {
        sakuraFall();
        destruirObjeto();

    }
    public void sakuraFall()//Define a queda do powerUp
    {
        rb2.AddForce(new Vector2(Random.Range(-3, 3),0));
        rb2.gravityScale = Mathf.Sin(Time.deltaTime) + 0.2f;
        transform.Rotate(rotacao);
    }
    void destruirObjeto()//destroi o powerup
    {
        if(transform.position.y <= -18)
        {
            Destroy(gameObject);
        }
    }
    void atribuirPoder()
    {
        botaopw = GameObject.Find("BotaoPW");
        sBotaoPW = botaopw.GetComponent<Poderes>();
        sBotaoPW.powerUp = Random.Range(1,100);
    }
}
//Objeto que ao ser cortado gera powerup