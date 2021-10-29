using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TitleController : MonoBehaviour
{
    public void OnClick_Play()
    {
        SceneManager.LoadScene("KinsonFirstGame");
    }
}
