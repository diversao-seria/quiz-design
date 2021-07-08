using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perguntas : MonoBehaviour
{
    public bool ativado;
    public Image barra;
    public GameObject feedback;
    public GerenteDeCena gerenteDeCena;
    public bool novaChance;
    


    public void Start()
    {
      
        
    }

    
   
    void Update()
    {
        
        if (ativado == true )
        {
          if(barra.fillAmount < 1)
          {
            barra.fillAmount ++;
          }

          else
          {
                feedback.SetActive(true);

                StartCoroutine(EsperaEAvança());
                ativado = false;
                
          }      
            

        }

        if (novaChance == true)
        {
            if (barra.fillAmount < 1)
            {
                barra.fillAmount++;
            }

            else
            {
                feedback.SetActive(true);

                StartCoroutine(NovaChance());
               
                novaChance = false;
            }
        }
       
    }

    
    







    public void Ativar()
    {
        ativado = true;
    }
    
    public void AtivarNovaChance()
    {
        novaChance = true;
    }


    void UpdateCount()
    {
        gerenteDeCena.contador.text = gerenteDeCena.questao.ToString();
    }





    IEnumerator EsperaEAvança()
    {
        yield return new WaitForSeconds(1);

        feedback.SetActive(false);
        gerenteDeCena.questao+=1;
        UpdateCount();
        barra.fillAmount=0;
        print("proxima questao");

    }

    IEnumerator NovaChance()
    {
        yield return new WaitForSeconds(2);
        barra.fillAmount = 0;
        feedback.SetActive(false);
        print("nova chance");
        ativado = false;
    }

}
