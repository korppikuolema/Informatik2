using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dunkel02 : MonoBehaviour {

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

        inventarAlternativeText = inventarAlternativeText.GetComponent<Button>();

        inventarText = inventarText.GetComponent<Button>();
        inventarMenu = inventarMenu.GetComponent<Canvas>();
        inventarMenu.enabled = false;

    }

    public void wehrenPress()
    {
        Application.LoadLevel("zelletyp");
    }

    public void InventarPress()
    {
        inventarMenu.enabled = true;
        inventarAlternativeText.enabled = false;
        inventarText.enabled = false;
    }

    public void reisPress()
    {
        Application.LoadLevel("zellereistyp");
    }

    public void nichtpassendPress()
    {
        inventarMenu.enabled = false;
        inventarAlternativeText.enabled = true;
        inventarText.enabled = true;
    }
}
