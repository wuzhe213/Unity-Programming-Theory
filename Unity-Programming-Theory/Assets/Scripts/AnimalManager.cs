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

    private Animal selectedAnimal = null;
    private string selectName = null;
    private string selectedAction = null;

    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(QuitGame);

        lionButton.onClick.AddListener(() => { SelectAnimal("lion"); });
        catButton.onClick.AddListener(() => { SelectAnimal("cat"); });
        dogButton.onClick.AddListener(() => { SelectAnimal("dog"); });
        penguinButton.onClick.AddListener(() => { SelectAnimal("penguin"); });

        idleButton.onClick.AddListener(() => { SelectedAction("idle"); });
        walkButton.onClick.AddListener(() => { SelectedAction("walk"); });
        jumpButton.onClick.AddListener(() => { SelectedAction("jump"); });
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

    private void SelectAnimal(string animalName)
    {
        if (selectedAnimal != null)
        {
            Destroy(selectedAnimal.Instance);
            selectedAnimal = null;
        }

        switch (animalName)
        {
            case "lion":
                selectedAnimal = new Lion(lionPrefab);
                SetButtonSelected(lionButton);
                break;

            case "cat":
                selectedAnimal = new Cat(catPrefab);
                SetButtonSelected(catButton);
                break;

            case "dog":
                selectedAnimal = new Dog(dogPrefab);
                SetButtonSelected(dogButton);
                break;

            case "penguin":
                selectedAnimal = new Penguin(penguinPrefab);
                SetButtonSelected(penguinButton);
                break;

            default:
                break;

        }

        selectName = animalName;

        if (selectedAnimal != null)
        {
            CreateAnimal(selectedAnimal);
        }
    }

    private void CreateAnimal(Animal animal)
    {
        animal.Instance = Instantiate(animal.Prefab, Vector3.zero, animal.Prefab.transform.rotation);
    }

    private void SetButtonSelected(Button button)
    {
        button.GetComponent<Image>().color = Color.gray;
        if (selectedAnimal != null)
        {
            switch (selectName)
            {
                case "lion":
                    SetButtonDeselected(lionButton);
                    break;

                case "cat":
                    SetButtonDeselected(catButton);
                    break;

                case "dog":
                    SetButtonDeselected(dogButton);
                    break;

                case "penguin":
                    SetButtonDeselected(penguinButton);
                    break;

                default:
                    break;

            }
        }
    }

    private void SetButtonDeselected(Button button)
    {
        button.GetComponent<Image>().color = Color.white;
    }

    private void SelectedAction(string action)
    {
        Debug.Log("action walk");
        switch (action)
        {
            case "idle":
                selectedAnimal.Idle();
                break;

            case "walk":
                selectedAnimal.Walk();
                break;

            case "jump":
                selectedAnimal.Jump();
                break;

            default:
                break;
        }
    }

}
