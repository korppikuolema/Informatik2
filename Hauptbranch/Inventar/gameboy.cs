using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameboy : MonoBehaviour {

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

    public void handyPress()
    {
        Application.LoadLevel("handydisplay02");
    }

    public void InventarPress()
    {
        inventarMenu.enabled = true;
        inventarAlternativeText.enabled = false;
        inventarText.enabled = false;
    }

    public void batterienPress()
    {
        Application.LoadLevel("ende01");
    }

    public void nichtpassendPress()
    {
        inventarMenu.enabled = false;
        inventarAlternativeText.enabled = true;
        inventarText.enabled = true;
    }


}
