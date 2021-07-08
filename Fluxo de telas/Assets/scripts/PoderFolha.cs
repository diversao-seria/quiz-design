using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderFolha : MonoBehaviour
{
    public List<GameObject> Folhinha;
    public GameObject BotaoFolha;
    public GameObject feedback;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AtivarFolha()
    {
        BotaoFolha.SetActive(false);
        foreach (var folha in Folhinha)
        {
            folha.SetActive(true);
        }
    }

    public void DesativarFolha()
    {
        StartCoroutine(EsperaESome());
    }

    IEnumerator EsperaESome()
    {
        yield return new WaitForSeconds(3/2);
        feedback.SetActive(false);
        foreach (var folha in Folhinha)
        {
            folha.SetActive(false);
        }
    }
}
