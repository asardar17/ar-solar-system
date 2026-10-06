using UnityEngine;
using TMPro;

public class PlanetInfo : MonoBehaviour
{
    public GameObject infoPanel;

    public TMP_Text planetName;
    public TMP_Text description;
    public TMP_Text stats;

    [TextArea]
    public string planetNameText;

    [TextArea]
    public string descriptionText;

    [TextArea]
    public string statsText;

    public void ShowInfo()
    {
        planetName.text = planetNameText;
        description.text = descriptionText;
        stats.text = statsText;

        infoPanel.SetActive(true);
    }

    public void HideInfo()
    {
        infoPanel.SetActive(false);
    }
}