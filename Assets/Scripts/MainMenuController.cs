using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public SubjectData[] subjects;              // assign via Inspector (drag your Subject assets)
    public Transform contentParent;             // assign to Scroll View Content
    public GameObject listItemPrefab;           // assign your ListItem prefab

    private void Start()
    {
        PopulateSubjects();
    }

    private void PopulateSubjects()
    {
        foreach (var s in subjects)
        {
            var localSubject = s; // prevent closure capture bug
            GameObject go = Instantiate(listItemPrefab, contentParent);
            var li = go.GetComponent<ListItemUI>();
            li.Init(localSubject.subjectName, () => OnSubjectClicked(localSubject));
        }
    }

    private void OnSubjectClicked(SubjectData subject)
    {
        GameManager.Instance.currentSubject = subject;
        SceneManager.LoadScene("ExperimentList");
    }
}
