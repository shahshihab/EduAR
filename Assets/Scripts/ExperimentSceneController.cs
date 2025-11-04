using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExperimentSceneController : MonoBehaviour
{
    public Text titleText;
    public Text descriptionText;
    public Button launchButton;

    private void Start()
    {
        var exp = GameManager.Instance.currentExperiment;
        if (exp == null)
        {
            SceneManager.LoadScene("ExperimentList");
            return;
        }

        titleText.text = exp.title;
        descriptionText.text = exp.description;
        launchButton.onClick.AddListener(LaunchExperiment);
    }

    public void LaunchExperiment()
    {
        SceneManager.LoadScene("ARScene");

        Debug.Log("Launch experiment: " + GameManager.Instance.currentExperiment.title);
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene("ExperimentList");
    }
}
