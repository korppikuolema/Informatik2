using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nebenbranch02 : MonoBehaviour {

    public Button leerenText;
    public Button behaltenText;

    public Button umdrehenText;

    public Button wehrenText;


    void Start () {

        leerenText = leerenText.GetComponent<Button>();
        behaltenText = behaltenText.GetComponent<Button>();

        umdrehenText = umdrehenText.GetComponent<Button>();

        wehrenText = wehrenText.GetComponent<Button>();


    }

    public void leerenPress()
    {
        Application.LoadLevel("haus0202");
    }

    public void behaltenPress()
    {
        Application.LoadLevel("haus02");
    }

    public void umdrehenPress()
    {
        Application.LoadLevel("dunkel02");
    }


    //ohne Inventar

    public void umdrehenPress01()
    {
        Application.LoadLevel("dunkel0202");
    }

    public void wehrenPress01()
    {
        Application.LoadLevel("zelletyp01");
    }


}
