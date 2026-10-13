using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool HasKey { get; private set; }

    private int initializeCount = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        // Punto de inicializacion del juego
        this.Initialize(); // B: preparar el estado del juego
    }

    public void Initialize()
    {
        initializeCount = initializeCount + 1;
        Debug.Log("GameManager inicializado. Veces: " + initializeCount);

        if (initializeCount > 1)
        {
            Debug.LogError("ERROR: Initialize() se ejecuto mas de una vez.");
        }
    }

    public void ObtainKey()
    {
        HasKey = true;
    }
}
