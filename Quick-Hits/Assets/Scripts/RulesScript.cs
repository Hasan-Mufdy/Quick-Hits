using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesScript : MonoBehaviour
{
    [SerializeField]
    private GameObject rulesPanel;

    [SerializeField]
    private GameObject rulesButton;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void rulesOnClick(){
        rulesPanel.SetActive(true);
        rulesButton.SetActive(false);

    }
    public void backOnClick(){
        rulesPanel.SetActive(false);
        rulesButton.SetActive(true);
    }
}
