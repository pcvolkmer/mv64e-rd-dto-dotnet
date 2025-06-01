using System.Diagnostics;
using System.Reflection;

namespace MV64e.RD.Test;

public class RdTest
{
    [Test]
    public void ShouldParseJsonData()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = @"MV64e.RD.Test.TestData.mv64e-rd-fake-patient.json";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, "Cannot find test data file");
        using var reader = new StreamReader(stream);
        
        var json = reader.ReadToEnd();
        var rd = Rd.FromJson(json);
                
        Assert.IsNotNull(rd);
    }
}