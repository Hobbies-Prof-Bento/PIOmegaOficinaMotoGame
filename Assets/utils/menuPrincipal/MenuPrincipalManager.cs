using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour{
    
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject menuPrincipal;                                

    public void Jogar()
    {
        menuPrincipal.SetActive(false);        
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {     
            painelOpcoes.SetActive(false);
            painelMenuInicial.SetActive(true);
            menuPrincipal.SetActive(true);
        }
    }
}