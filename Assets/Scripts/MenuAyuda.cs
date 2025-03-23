using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;


public class MenuAyuda : MonoBehaviour
{
    private UIDocument menu;
    private Button botonSalirmenu;
    private Button botonSalirJuego;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Inicializar el boton de salir del juego y el callback a la función de salir del juego
        botonSalirJuego = root.Q<Button>("BotonSalirJuego");
        botonSalirJuego.RegisterCallback<ClickEvent>(SalirJuego);

        botonSalirmenu = root.Q<Button>("BotonSalirMenu");
        botonSalirmenu.RegisterCallback<ClickEvent>(SwitchToMain);

    }

    private void SalirJuego(ClickEvent evt)
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode(); 
        #else
            Application.Quit(); 
        #endif
    }
    private void SwitchToMain(ClickEvent evt)
    {
        
    }
}