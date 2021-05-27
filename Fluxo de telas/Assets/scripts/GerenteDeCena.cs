using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GerenteDeCena : MonoBehaviour
{
    
    public int questao;
    public Text contador;
    public Perguntas perguntas;

    [SerializeField]
    private Image FundoImg;
    public Sprite fundoPadrao;

    
    public void TrocarFundo(Sprite fundo)
    {
        FundoImg.sprite = fundo;
        StartCoroutine(EsperaEvolta());
    }

    public void CarregarCena(string cena)
    {

        SceneManager.LoadScene(cena);

    }

    public void Sair()
    {
        Application.Quit();
        print("saiu");
    }
    
    

    IEnumerator EsperaEvolta()
    {
        yield return new WaitForSeconds(2);
        FundoImg.sprite = fundoPadrao;

    }
}
