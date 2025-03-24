using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]

public class SimpleTMPBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;
    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWithIntData();
    }
    void UpdateWithIntData()
    {
        textObj.text = "ScoRe: " + dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
