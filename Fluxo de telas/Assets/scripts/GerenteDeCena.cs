using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GerenteDeCena : MonoBehaviour
{
    
    public int questao;
    public int questoesCertas;
    public int questoesCertasSeguidas;
    public Text contador;
    public Text contadorQCertas;
    public Perguntas perguntas;

    [SerializeField]
    private Image FundoImg;
    public Sprite fundoPadrao;
    public Sprite fundoFoguinho;
    public GameObject painelFinal;
    //public bool errou;
    

    public void Update()
    {
        if ( questoesCertasSeguidas >= 3)
        {
            FundoImg.sprite = fundoFoguinho;
        }
        if (questao == 10)
        {
            this.painelFinal.SetActive(true);
            UpdateCount();
        }
    }


    
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

    void UpdateCount()
    {
        contadorQCertas.text = questoesCertas.ToString();
    }

    public void Acertou()
    {
        questoesCertas += 1;
        questoesCertasSeguidas  += 1;
        //errou = false;
    }
    public void Errou()
    {
        //errou = true;
        questoesCertasSeguidas = 0;
        FundoImg.sprite = fundoPadrao;
    }

    IEnumerator EsperaEvolta()
    {
        yield return new WaitForSeconds(2);
        FundoImg.sprite = fundoPadrao;

    }
}
