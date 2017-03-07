using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class supermarkt : MonoBehaviour {

    public Button aepfelText;
    public Button bananenText;
    public Button nudelnText;
    public Button reisText;
    public Button bloedText;
    public Button zeitungText;

    void Start () {

        aepfelText = aepfelText.GetComponent<Button>();
        bananenText = bananenText.GetComponent<Button>();
        nudelnText = nudelnText.GetComponent<Button>();
        reisText = reisText.GetComponent<Button>();
        bloedText = bloedText.GetComponent<Button>();
        zeitungText = zeitungText.GetComponent<Button>();

    }

    public void bananePress()
    {
        Application.LoadLevel("regalabteilung");
    }

    public void apfelPress()
    {
        Application.LoadLevel("regalabteilungfalsch");
    }

    public void reisPress()
    {
        Application.LoadLevel("zeitungsständer");
    }

    public void nudelPress()
    {
        Application.LoadLevel("zeitungsständerfalsch");
    }

    public void zeitungPress()
    {
        Application.LoadLevel("haustuer");
    }

    public void bloedPress()
    {
        Application.LoadLevel("haustuer01");
    }


}
