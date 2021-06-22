using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarTela : MonoBehaviour
{
    public GameObject Painel;
    public GameObject PainelQuestao;
    public GameObject Esconder;
    public bool iniciarC;

    public void abrirTela()
    {
        this.Painel.SetActive(true);
        this.Esconder.SetActive(false);
    }

    public void fecharTela()
    {
        this.Painel.SetActive(false);
        this.Esconder.SetActive(true);
    }

    public void NovaChanceFechar()
    {
        StartCoroutine(NovaChance());
        
    }

    public void NextQ()
    {
        StartCoroutine(ProximaQuestao());
        iniciarC = true;
    }
    
    public void PrimeiraQ()
    {
        iniciarC = true;
       
    }



    IEnumerator NovaChance()
    {
        yield return new WaitForSeconds(1);
        this.Painel.SetActive(false);
    }

    IEnumerator ProximaQuestao()
    {
        yield return new WaitForSeconds(3/2);
        //PainelQuestao.SetActive(true);
        this.Painel.SetActive(true);
        print("next");
        
    }
    


}
