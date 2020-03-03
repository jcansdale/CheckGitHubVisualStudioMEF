using System;
using System.ComponentModel.Composition;

namespace CheckGitHubVisualStudioMEF
{
    public class CompositionServicesTest
    {
        // How to test
        // 1. Install TestDriven.NET:
        //   https://marketplace.visualstudio.com/items?itemName=JamieCansdale.TestDrivenNet
        // 2. Right-click inside this method and `Test With > In-proc (VS SDK)`
        // 3. Expect "GitHub.VisualStudio.CompositionServices"
        public void Test([Import("GitHub.VisualStudio.CompositionServices")] object compositionServices)
        {
            Console.WriteLine(compositionServices);
        }

        // If this fails, expect to see:
        //   1) No exports were found that match the constraint: 
        //      ContractName	GitHub.VisualStudio.CompositionServices
        //      RequiredTypeIdentity	
    }
}
