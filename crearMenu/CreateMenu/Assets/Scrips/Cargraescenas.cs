using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cargraescenas : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cargarEscenanacubo()
    {
        SceneManager.LoadScene("EscenaCubo");
    }

    public void cargarEscenanaimagen()
    {
        SceneManager.LoadScene("Escenaimagen");
    }
    public void cargarEscenanasusma()
    {
        SceneManager.LoadScene("Escenasumar");
    }
    public void cargarEscenanamucica()
    {
        SceneManager.LoadScene("Escenaaudio");
    }
    public void LoadMenuEscen()
    {
        SceneManager.LoadScene("Menu");
    }
    public void AddLoadMenuEscen()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PicLoadMenuEscen()
    {
        SceneManager.LoadScene("Menu");
    }
    public void musicLoadMenuEscen()
    {
        SceneManager.LoadScene("Menu");
    }
}
