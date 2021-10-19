using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    [SerializeField] GameObject mainMenu = null;
    [SerializeField] GameObject optionMenu = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Play()
    {
        SceneManager.LoadScene("KinsonFirstGame");
    }

    public void OnClick_Option()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void OnClick_Menu()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
    }
}
