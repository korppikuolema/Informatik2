using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ende : MonoBehaviour {

    public Button endText;

    void Start()
    {

        endText = endText.GetComponent<Button>();


    }

    public void endePress()
    {
        Application.LoadLevel("Hauptmenue");
    }
}
