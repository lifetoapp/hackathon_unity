using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WalletConnectUnity.Core;
using WalletConnectUnity.Modal;

public class WalletConnection : MonoBehaviour
{
    public void Connect()
    {
        WalletConnectModal.InitializeAsync();
    }
}
