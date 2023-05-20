using UnityEngine;
using UnityEngine.Analytics;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class WinLevel : MonoBehaviour
{
    async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
            List<string> consentIdentifiers = await AnalyticsService.Instance.CheckForRequiredConsents();
        }
        catch(ConsentCheckException e)
        {
            //something
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Flag")
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"Fabulous String", "You won" },
            };

            AnalyticsService.Instance.CustomData("myEvent", parameters);

            Debug.Log("Win");
        }
    }
}
