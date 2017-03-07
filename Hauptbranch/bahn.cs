using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bahn : MonoBehaviour {

    public Button handyText;
    public Button menschenText;
    public Button lesenText;
    public Button appText;
    public Button neinText;
    public Button wegsteckenText;


    void Start()
    {
        handyText = handyText.GetComponent<Button>();
        menschenText = menschenText.GetComponent<Button>();
        lesenText = lesenText.GetComponent<Button>();

        appText = appText.GetComponent<Button>();

        neinText = neinText.GetComponent<Button>();
        wegsteckenText = wegsteckenText.GetComponent<Button>();
    }

    public void HandyPress()
    {
        Application.LoadLevel ("handy");
    }

    public void MenschenPress()
    {
        Application.LoadLevel("menschenBeobachten");
    }

    public void LesenPress()
    {
        Application.LoadLevel("buchLesen");
    }

    public void AppPress()
    {
        Application.LoadLevel("handyBildschirm");
    }

    public void ablehnenPress()
    {
        Application.LoadLevel("gemüseabteilung");
    }


}
