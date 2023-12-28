using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Repository;

public class Codesets
{
    private readonly ITestOutputHelper _output;

    public Codesets(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper; 
    }

    [Fact]
    public void DisplayAlphaOrder ()
    {
        foreach(var codeset in LoadedRepository.Instance.DataDictionary.CodeSets.OrderBy( i => i.Name ))
        {
            _output.WriteLine($"{codeset.Name.PadLeft(30)} Ext:{codeset.IsExternal}");
        }
       
    }

    [Fact(DisplayName = "AccountStatus1Code should load codes.")]
    public void AccountStatus1CodeShouldHaveCodesLoading()
    {
        var originalCodeset = LoadedRepository.Instance.DataDictionary.CodeSets.Where(c => c.Name == "AccountStatus1Code").First() ;
        var codeSet = originalCodeset.ForceReload();

        _output.WriteLine(codeSet.xElement.ToString());
        Assert.True(codeSet.Codes.Length > 0, "Why didn't the codes for this load?");
    }

}


public static class TestingExtensions
{
    public static CodeSet ForceReload(this CodeSet codeSetToReload)
    {
        return new CodeSet(codeSetToReload.xElement);
    }
}