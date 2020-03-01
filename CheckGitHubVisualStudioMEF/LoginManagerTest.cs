using System;
using System.ComponentModel.Composition;

namespace CheckGitHubVisualStudioMEF
{
    public class LoginManagerTest
    {
        // How to test
        // 1. Install TestDriven.NET:
        //   https://marketplace.visualstudio.com/items?itemName=JamieCansdale.TestDrivenNet
        // 2. Right-click inside this method and `Test With > In-proc (VS SDK)`
        // 3. Expect "GitHub.Api.LoginManager"
        public void Test([Import("GitHub.Api.ILoginManager")] object loginManager)
        {
            Console.WriteLine(loginManager);
        }

        // If this fails, expect to see:
        //   1) No exports were found that match the constraint: 
        //      ContractName	GitHub.Api.ILoginManager
        //      RequiredTypeIdentity	
    }
}
