using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class AnimalManager : MonoBehaviour
{
    [SerializeField] private Button quitButton;

    [SerializeField] private GameObject lionPrefab;
    [SerializeField] private GameObject catPrefab;
    [SerializeField] private GameObject dogPrefab;
    [SerializeField] private GameObject penguinPrefab;

    [SerializeField] private Button lionButton;
    [SerializeField] private Button dogButton;
    [SerializeField] private Button catButton;
    [SerializeField] private Button penguinButton;

    [SerializeField] private Button idleButton;
    [SerializeField] private Button walkButton;
    [SerializeField] private Button jumpButton;

    private string selectedAnimal = null;
    private string selectedAction = null;

    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
