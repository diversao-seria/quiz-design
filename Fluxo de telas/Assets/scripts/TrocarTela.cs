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
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
