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
    
    private VisualElement contenedorContenido;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

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
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        var contenedorContenido = root.Q<VisualElement>("Selector");
        contenedorContenido.Clear();

        
        Button botonCerrar = new Button();
        botonCerrar.text = "X"; 
        botonCerrar.style.fontSize = 30;
        botonCerrar.style.width = Length.Percent(10);
        botonCerrar.style.height = Length.Percent(10);
        botonCerrar.style.position = Position.Absolute;
        botonCerrar.style.top = Length.Percent(10); // 10px from the top
        botonCerrar.style.right = Length.Percent(10); // 10px from the right
        botonCerrar.style.backgroundColor = new StyleColor(Color.clear);
        botonCerrar.style.borderLeftWidth = 0; 
        botonCerrar.style.borderRightWidth = 0; 
        botonCerrar.style.borderTopWidth = 0; 
        botonCerrar.style.borderBottomWidth = 0;
        botonCerrar.style.color = new StyleColor(Color.white);
        //botonCerrar.style.borderRadius = new Length(5, LengthUnit.Pixel);
        botonCerrar.style.fontSize = 20;
        botonCerrar.style.unityTextAlign = TextAnchor.MiddleCenter;
        
        Label textoAyuda = new Label();
        textoAyuda.style.unityTextAlign = TextAnchor.MiddleCenter;
        textoAyuda.style.fontSize = 35;
        textoAyuda.style.color = new StyleColor(Color.white);
        textoAyuda.style.flexGrow = 0;
        textoAyuda.style.overflow = Overflow.Hidden;
        textoAyuda.style.whiteSpace = WhiteSpace.Normal;
        textoAyuda.style.width = Length.Percent(95);
        textoAyuda.style.alignSelf = Align.Center;
        textoAyuda.style.unityFontStyleAndWeight = FontStyle.Bold;
        textoAyuda.text = "Lorem Ipsum\n\n Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc dapibus a nibh quis varius. Praesent eu convallis ex. Integer ullamcorper imperdiet lectus ac mollis. Donec erat velit, blandit sed diam sed, pharetra gravida ex. Mauris eu varius purus, ac lacinia turpis. Etiam at purus eget augue auctor ultrices. Integer risus justo, vestibulum vel libero eu, tempus auctor risus. Nam sed est quis ex vulputate facilisis in quis ipsum. Quisque consectetur leo purus, a mollis mi efficitur vel. Fusce euismod quam id sem pretium, at porttitor ex dictum. Nam ut urna vehicula, condimentum justo vulputate, volutpat eros. Ut cursus blandit mauris, nec ornare libero ornare eu. Sed in turpis id dui condimentum condimentum non sed mi. Cras porta dolor sit amet luctus ultrices.";
        
        
        contenedorContenido.Add(textoAyuda);
        contenedorContenido.Add(botonCerrar);
    }

    private void DespliegaCreditos(ClickEvent evt)
    {
        SceneManager.LoadScene("Creditos");
    }
}
