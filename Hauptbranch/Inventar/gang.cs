using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gang : MonoBehaviour {

    public Button inventarAlternativeText;

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

        inventarAlternativeText = inventarAlternativeText.GetComponent<Button>();

    }

    public void InventarPress()
    {
        inventarMenu.enabled = true;
        inventarAlternativeText.enabled = false;
        inventarText.enabled = false;
    }


    public void bananePress()
    {
        Application.LoadLevel("gangbanane");
    }

    public void nichtpassendPress()
    {
        inventarMenu.enabled = false;
        inventarAlternativeText.enabled = true;
        inventarText.enabled = true;
    }

    public void schleichenPress()
    {
        Application.LoadLevel("ende03");
    }
}
