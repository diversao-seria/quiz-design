using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarTela : MonoBehaviour
{
    public GameObject Painel;
    public GameObject Esconder;

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

    IEnumerator NovaChance()
    {
        yield return new WaitForSeconds(1);
        this.Painel.SetActive(false);
    }
}
