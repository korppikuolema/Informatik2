using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class zelle : MonoBehaviour {

    public Button inventarText;
    public Canvas inventarMenu;
    public Button bananeInventarText;
    public Button batterienInventarText;
    public Button oelInventarText;
    public Button reisInventarText;
    public Button zeitungInventarText;
    public Button haarklammerInventarText;

    void Start () {

        inventarText = inventarText.GetComponent<Button>();
        inventarMenu = inventarMenu.GetComponent<Canvas>();
        inventarMenu.enabled = false;


    }

    public void InventarPress()
    {
        inventarMenu.enabled = true;
        inventarText.enabled = false;
    }

    public void haarklammerPress()
    {
        Application.LoadLevel("zelleohnegitter");
    }

    public void haarklammerReisPress()
    {
        Application.LoadLevel("zelleohnegitterreis");
    }

    public void nichtpassendPress()
    {
        inventarMenu.enabled = false;
        inventarText.enabled = true;
    }
}
