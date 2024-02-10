using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WalletConnectUnity.Core;

public class WalletConnection : MonoBehaviour
{
    // private async void Start()
    // {
    //     // Initialize singleton
    //     await WalletConnect.Instance.InitializeAsync();
    //
    //     // Try resume last session
    //     var sessionResumed = await WalletConnect.Instance.TryResumeSessionAsync();              
    //     if (!sessionResumed)                                                                         
    //     {                                                                                            
    //         Debug.Log("Try initialize new session");
    //         var connectedData = await WalletConnect.Instance.ConnectAsync(connectOptions);
    //
    //         // Create QR code texture
    //         var texture = WalletConnectUnity.Core.Utils.QRCode.EncodeTexture(connectedData.Uri);
    //
    //         // ... Display QR code texture
    //
    //         // Wait for wallet approval
    //         await connectedData.Approval;     
    //         Debug.Log("Wallet approved");
    //     }
    //     else
    //     {
    //         Debug.Log("Session resumed");
    //     }
    // }
}
