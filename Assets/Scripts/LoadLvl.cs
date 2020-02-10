using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLvl : MonoBehaviour
{
    public int i;

#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
    void OnMouseDown() => Application.LoadLevel("FirstLvl");
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
    void OnMouseUpAsButton()
    {
#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
        Application.LoadLevel("FirstLvl");
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
        SceneManager.LoadScene(i);
    }
    public void LoadLevel(string lvl)
    {
        SceneManager.LoadScene(lvl);

    }

}
