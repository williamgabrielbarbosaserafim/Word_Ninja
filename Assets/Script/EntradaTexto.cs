using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[Serializable]
public class EntradaTexto
{
    public String palavra;

    [SerializeField]
    public string[] palavrasCertas = new string[] { "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez" };
    [SerializeField]
    public string[] palavrasErradas = new string[] {"Verde", "Azul", "Amarelo", "Vermelho", "Branco", "Preto", "Cinza", "Laranja", "Roxo", "Rosa" };

    public String path = "StreamingAssets/Palavras";
    
    public void Save() //Salva as palavras definidas em arquivo Json
    {
        var content = JsonUtility.ToJson(this, true);
        File.ReadAllText(path);
    }

    public void Load()//Carrega as palavas pré definidas num arquivo Json para o jogo
    {
        var content = File.ReadAllText(path);
        var p = JsonUtility.FromJson<EntradaTexto>(content);

        for(int i = 0; i <= palavrasCertas.Length; i++)
        {
            palavrasCertas[i] = p.palavrasCertas[i];
            palavrasErradas[i] = p.palavrasErradas[i];
        }
    }
}
//Cria e lê objetos Json