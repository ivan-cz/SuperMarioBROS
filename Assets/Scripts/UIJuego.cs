using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class UIJuego : MonoBehaviour
{

    private UIDocument uiJuego;
    private Button botonRegresar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        uiJuego = GetComponent<UIDocument>();
        var root = uiJuego.rootVisualElement;

        botonRegresar = root.Q<Button>("BotonRegresar");
        botonRegresar.RegisterCallback<ClickEvent>(RegresarMenu);
    }

    // Update is called once per frame
    private void RegresarMenu(ClickEvent evt)
    {
       SceneManager.LoadScene("MenuPrincipal"); 
    }
}
