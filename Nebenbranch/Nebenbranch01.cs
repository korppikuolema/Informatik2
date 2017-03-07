using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nebenbranch01 : MonoBehaviour {

    public Button leerenText;
    public Button behaltenText;

    public Button klingelnText;

    public Button einlenkenText;
    public Button rennenText;

    public Button wehrenText;


    void Start () {

        leerenText = leerenText.GetComponent<Button>();
        behaltenText = behaltenText.GetComponent<Button>();

        klingelnText = klingelnText.GetComponent<Button>();

        einlenkenText = einlenkenText.GetComponent<Button>();
        rennenText = rennenText.GetComponent<Button>();

        wehrenText = wehrenText.GetComponent<Button>();

    }

    public void leerenPress()
    {
        Application.LoadLevel("haus0101");
    }

    public void behaltenPress()
    {
        Application.LoadLevel("haus01");
    }

    public void klingelPress()
    {
        Application.LoadLevel("tür01");
    }

    public void einlenkenPress()
    {
        Application.LoadLevel("ende02");
    }

    public void rennenPress()
    {
        Application.LoadLevel("dunkel01");
    }


    //ohne Inventar

    public void klingelPress01()
    {
        Application.LoadLevel("tuer0101");
    }

    public void rennenPress01()
    {
        Application.LoadLevel("dunkel0101");
    }

    public void wehrenPress01()
    {
        Application.LoadLevel("zelletyp01");
    }
}
