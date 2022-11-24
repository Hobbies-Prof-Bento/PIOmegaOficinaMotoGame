using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private string nomeDoLeveldeJogo;
    [SerializeField] private GameObject painelMenuPC;
    [SerializeField] private GameObject painelLoja;
    [SerializeField] private GameObject painelMissoes;
    [SerializeField] public GameObject menuInteracao;


    public void AbrirLoja()
    {
        painelLoja.SetActive(true);
        painelMenuPC.SetActive(false);
    }

    public void FecharLoja()
    {
        painelLoja.SetActive(false);
        painelMenuPC.SetActive(true);
    }

    public void AbrirMissoes()
    {
        painelMissoes.SetActive(true);
        painelMenuPC.SetActive(false);
    }

    public void FecharMissoes()
    {
        painelMissoes.SetActive(false);
        painelMenuPC.SetActive(true);
    }
    public void sair()
    {
        menuInteracao.SetActive(false);
    }   
}
