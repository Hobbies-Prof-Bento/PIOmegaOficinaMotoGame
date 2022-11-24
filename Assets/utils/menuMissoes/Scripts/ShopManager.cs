using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public ShopItemSO[] ShopItemSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] comprarBotao;

    void Start()
    {
        for (int i = 0; i < ShopItemSO.Length; i++)
            shopPanelsGO[i].SetActive(true);
        coinUI.text = "Coins: " + coins.ToString();
        LoadPanels();
        CheckCompra();
    }

    public void AddCoins()
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
        CheckCompra();
    }

    public void ComprarItem(int btnNo)
        {
            if (coins >= ShopItemSO[btnNo].preco)
            {
                coins = coins - ShopItemSO[btnNo].preco;
                coinUI.text = "Coins: " + coins.ToString();
                CheckCompra();
            }
        }

    public void CheckCompra()
    {
        for (int i = 0; i < ShopItemSO.Length; i++)
        {
            if (coins >= ShopItemSO[i].preco)
                comprarBotao[i].interactable = true;
            else
                comprarBotao[i].interactable = false;
        }
    }

    public void LoadPanels()
    {
        for (int i = 0; i < ShopItemSO.Length; i++)
        {
            shopPanels[i].tituloTxt.text = ShopItemSO[i].titulo;
            shopPanels[i].precoTxt.text = "Coins: " + ShopItemSO[i].preco.ToString();
        }
    }
}
