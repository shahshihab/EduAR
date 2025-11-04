using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExperimentListController : MonoBehaviour
{
    public Transform contentParent;
    public GameObject listItemPrefab;
    public Text titleText;

    private void Start()
    {
        var subject = GameManager.Instance.currentSubject;
        if (subject == null)
        {
            // fallback: go back to main menu
            SceneManager.LoadScene("MainMenu");
            return;
        }

        titleText.text = subject.subjectName + " Experiments";
        PopulateExperiments(subject);
    }

    private void PopulateExperiments(SubjectData subject)
    {
        foreach (var exp in subject.experiments)
        {
            var localExp = exp;
            GameObject go = Instantiate(listItemPrefab, contentParent);
            var li = go.GetComponent<ListItemUI>();
            li.Init(localExp.title, () => OnExperimentClicked(localExp));
        }
    }

    private void OnExperimentClicked(ExperimentData exp)
    {
        GameManager.Instance.currentExperiment = exp;
        SceneManager.LoadScene("Experiment");
    }
}
