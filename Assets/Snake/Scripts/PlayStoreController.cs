using System.Collections;
//using Google.Play.AppUpdate;
//using Google.Play.Common;
using UnityEngine;
using UnityEngine.UI;

public class PlayStoreController : MonoBehaviour
{
    //[SerializeField] private Text inAppStatus;

    //AppUpdateManager appUpdateManager = new AppUpdateManager();

    //// Start is called before the first frame update
    //void Start()
    //{
    //    StartCoroutine(CheckForUpdate());
    //}



    //IEnumerator CheckForUpdate()
    //{
    //    PlayAsyncOperation<AppUpdateInfo, AppUpdateErrorCode> appUpdateInfoOperation = appUpdateManager.GetAppUpdateInfo();// < --error here

    //    // Wait until the asynchronous operation completes.
    //    yield return appUpdateInfoOperation;

    //    if (appUpdateInfoOperation.IsSuccessful)
    //    {
    //        var appUpdateInfoResult = appUpdateInfoOperation.GetResult();
    //        // Check AppUpdateInfo's UpdateAvailability, UpdatePriority,
    //        // IsUpdateTypeAllowed(), etc. and decide whether to ask the user
    //        // to start an in-app update.

    //        //display if there us an update or not
    //        if (appUpdateInfoResult.UpdateAvailability == UpdateAvailability.UpdateAvailable)
    //        {
    //            inAppStatus.text = UpdateAvailability.UpdateAvailable.ToString();
    //        }
    //        else
    //        {
    //            inAppStatus.text = "No Update Avaiable";
    //        }

    //        // Creates an AppUpdateOptions defining an immediate in-app
    //        // update flow and its parameters.
    //        var appUpdateOptions = AppUpdateOptions.ImmediateAppUpdateOptions();

    //        StartCoroutine(StartImmediateUpdate(appUpdateInfoResult, appUpdateOptions));

    //    }

    //}


    //IEnumerator StartImmediateUpdate(AppUpdateInfo appUpdateInfoOp_i, AppUpdateOptions appUpdateOptions_i)
    //{
    //    // Creates an AppUpdateRequest that can be used to monitor the
    //    // requested in-app update flow.
    //    var startUpdateRequest = appUpdateManager.StartUpdate(
    //    // The result returned by PlayAsyncOperation.GetResult().
    //    appUpdateInfoOp_i,
    //    // The AppUpdateOptions created defining the requested in-app update
    //    // and its parameters.
    //    appUpdateOptions_i);
    //    yield return startUpdateRequest;

    //    // If the update completes successfully, then the app restarts and this line
    //    // is never reached. If this line is reached, then handle the failure (for
    //    // example, by logging result.Error or by displaying a message to the user).
    //}



    ///* IEnumerator StartFlexibleUpdate()
    //{
    //// Creates an AppUpdateRequest that can be used to monitor the
    //// requested in-app update flow.
    //var startUpdateRequest = appUpdateManager.StartUpdate(
    //// The result returned by PlayAsyncOperation.GetResult().
    //appUpdateInfoResult,
    //// The AppUpdateOptions created defining the requested in-app update
    //// and its parameters.
    //appUpdateOptions);

    //while (!startUpdateRequest.IsDone)
    //{
    //// For flexible flow,the user can continue to use the app while
    //// the update downloads in the background. You can implement a
    //// progress bar showing the download status during this time.
    //yield return null;
    //}

    //} */



}
