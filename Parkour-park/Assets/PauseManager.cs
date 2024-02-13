using StarterAssets;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{
    FadeInOut fade;
    public GameObject pauseMenuUI; // Reference to the Pause Menu canvas
    public ThirdPersonController cameraMovement;
    public GameObject ThirdPersonEventSystem;
    public GameObject PauseMenuEventSystem;
    public EventSystem ThirdPersonEvent;
    public EventSystem PauseMenuEvent;

    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }
    public void PauseGame()
    {  
        isPaused = true;
        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (cameraMovement != null)
            cameraMovement.LockCameraPosition = true; // Lock only camera position

        if (ThirdPersonEventSystem != null)
        {
            ThirdPersonEventSystem.SetActive(false);
            ThirdPersonEvent.enabled = false;
        }
        if (PauseMenuEventSystem != null)
        {
            PauseMenuEventSystem.SetActive(true);
            PauseMenuEvent.enabled = true;
        }


        // Display the pause menu
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);
    }
    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (cameraMovement != null)
            cameraMovement.LockCameraPosition = false; // Unlock camera position

        if (PauseMenuEventSystem != null)
        {
            PauseMenuEventSystem.SetActive(false);
            PauseMenuEvent.enabled = false;
        }

        if (ThirdPersonEventSystem != null) 
        { 
            ThirdPersonEventSystem.SetActive(true);
            ThirdPersonEvent.enabled = true;
        
        }
            

        // Hide the pause menu
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);

        // Add additional resume logic if needed
    }
    public void MainMenu()
    {
        StartCoroutine(ChangeScene1());
    }
    public IEnumerator ChangeScene1()
    {
        Time.timeScale = 1f;
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");
    }
}
