using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class fabrik : MonoBehaviour {

    //Zelle Gespräch Mann
    public Button einlenkenText;
    public Button ablehnenText;
    //Zelle Reisspur
    public Button reisText;
    //Zelle Tür
    public Button tuerText;
    //Rohr Öl
    public Button rohrText;

    void Start () {

       
        einlenkenText = einlenkenText.GetComponent<Button>();
        ablehnenText = ablehnenText.GetComponent<Button>();

        reisText = reisText.GetComponent<Button>();

        tuerText = tuerText.GetComponent<Button>();

        rohrText = rohrText.GetComponent<Button>();

    }

    public void einlenkenPress()
    {
        Application.LoadLevel("ende02");
    }

    public void ablehnenPress()
    {
        Application.LoadLevel("zelle");
    }

    public void ablehnenReisPress()
    {
        Application.LoadLevel("zellereis");
    }

    public void tuerPress()
    {
        Application.LoadLevel("gang");
    }

    public void reisFolgenPress()
    {
        Application.LoadLevel("außenReis");
    }

    public void rohrPress()
    {
        Application.LoadLevel("außen");
    }

    public void schleichenPress()
    {
        Application.LoadLevel("rohr");
    }
    
    //ohneInventar


    public void ablehnenPress01()
    {
        Application.LoadLevel("ende04");
    }
}
