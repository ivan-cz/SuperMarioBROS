using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    private UIDocument menu;
    private Button botonSalirJuego;
    private Button botonIniciarJuego;
    private Button botonAyuda;
    private Button botonCreditos;
    private Button salirMenu;
    private VisualElement menuPrincipal;
    private VisualElement menuAyuda;
    private VisualElement contenedorContenido;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        menuPrincipal = root.Q<VisualElement>("MenuPrincipal");
        menuAyuda = root.Q<VisualElement>("MenuAyuda");

        salirMenu = root.Q<Button>("BotonSalirMenu");
        salirMenu.RegisterCallback<ClickEvent>(SalirMenu);

        // Inicializar el boton de salir del juego y el callback a la función de salir del juego
        botonSalirJuego = root.Q<Button>("BotonSalirJuego");
        botonSalirJuego.RegisterCallback<ClickEvent>(SalirJuego);

        // Inicializar el boton de iniciar el juego
        botonIniciarJuego = root.Q<Button>("BotonJugar");
        botonIniciarJuego.RegisterCallback<ClickEvent>(IniciarJuego);


        botonAyuda = root.Q<Button>("BotonAyuda");
        botonAyuda.RegisterCallback<ClickEvent>(DespliegaAyuda);

        botonCreditos = root.Q<Button>("BotonCreditos");
        botonCreditos.RegisterCallback<ClickEvent>(DespliegaCreditos);
        

    }

    private void SalirJuego(ClickEvent evt)
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode(); 
        #else
            Application.Quit(); 
        #endif
    }

    private void IniciarJuego(ClickEvent evt)
    {
        SceneManager.LoadScene("SampleScene");
    }


    private void DespliegaAyuda(ClickEvent evt)
    {
        menuPrincipal.style.display = DisplayStyle.None; // Hide main menu
        menuAyuda.style.display = DisplayStyle.Flex; // Show help menu
    }
    
    private void SalirMenu(ClickEvent evt)
    {
        menuAyuda.style.display = DisplayStyle.None; // Hide help menu
        menuPrincipal.style.display = DisplayStyle.Flex; // Show main menu
    }
    
    private void DespliegaCreditos(ClickEvent evt)
    {
        SceneManager.LoadScene("Credits");
    }
}
