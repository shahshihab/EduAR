using UnityEngine;

[CreateAssetMenu(menuName = "EduAR/Subject")]
public class SubjectData : ScriptableObject
{
    public string subjectName;
    public ExperimentData[] experiments;
}
