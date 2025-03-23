using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuCreditos : MonoBehaviour
{

    private UIDocument menu;
    private Button botonSalirMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        botonSalirMenu = root.Q<Button>("SalirMenuBoton");
        botonSalirMenu.RegisterCallback<ClickEvent>(SalirCreditos);
    }

    // Update is called once per frame
    void SalirCreditos(ClickEvent evt)
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
