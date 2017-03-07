using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wohnung : MonoBehaviour {

    public Button haustuerText;
    public Button nachbarinpositivText;
    public Button nachbarinnegativText;
    public Button tuerschlossText;

    public Button gameboyText;
    public Button zeitungText;
    public Button fernsehenText;

    public Button misstrauischText01;
    public Button naivText01;

    public Button misstrauischText02;
    public Button naivText02;


    void Start()
    {

        haustuerText = haustuerText.GetComponent<Button>();
        nachbarinpositivText = nachbarinpositivText.GetComponent<Button>();
        nachbarinnegativText = nachbarinnegativText.GetComponent<Button>();
        tuerschlossText = tuerschlossText.GetComponent<Button>();

        gameboyText = gameboyText.GetComponent<Button>();
        zeitungText = zeitungText.GetComponent<Button>();
        fernsehenText = fernsehenText.GetComponent<Button>();

        misstrauischText01 = misstrauischText01.GetComponent<Button>();
        naivText01 = naivText01.GetComponent<Button>();

        misstrauischText02 = misstrauischText02.GetComponent<Button>();
        naivText02 = naivText02.GetComponent<Button>();

    }

    //mit Zeitung und Batterien

    public void umdrehenPress()
    {
        Application.LoadLevel("nachbarin");
    }

    public void nachbarinpositiv()
    {
        Application.LoadLevel("nachbarinpositiv");
    }

    public void nachbarinnegativ()
    {
        Application.LoadLevel("nachbarinnegativ");
    }

    public void platzmachenPress()
    {
        Application.LoadLevel("türschloss");
    }

    public void eintretenPress()
    {
        Application.LoadLevel("wohnzimmer");
    }

    public void gameboyPress()
    {
        Application.LoadLevel("gameboy");
    }

    public void zeitungPress()
    {
        Application.LoadLevel("zeitung");
    }

    public void fernsehenPress()
    {
        Application.LoadLevel("fernseher");
    }

    public void handyPress()
    {
        Application.LoadLevel("handydisplay02");
    }

    public void misstrauischPress01()
    {
        Application.LoadLevel("handydisplay0202");
    }

    public void naivPress01()
    {
        Application.LoadLevel("handydisplayende");
    }

    public void misstrauischPress02()
    {
        Application.LoadLevel("diele02");
    }

    public void naivPress02()
    {
        Application.LoadLevel("diele01");
    }

    //ohne Zeitung und Batterien

    public void umdrehenPress01()
    {
        Application.LoadLevel("nachbarin01");
    }

    public void nachbarinpositiv01()
    {
        Application.LoadLevel("nachbarin0101");
    }

    public void platzmachenPress01()
    {
        Application.LoadLevel("türschloss01");
    }

    public void eintretenPress01()
    {
        Application.LoadLevel("wohnzimmer01");
    }

    public void gameboyPress01()
    {
        Application.LoadLevel("gameboy01");
    }


  
}
