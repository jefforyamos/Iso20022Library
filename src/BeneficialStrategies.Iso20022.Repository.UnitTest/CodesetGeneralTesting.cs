using Xunit.Abstractions;
using System.Collections.Generic;
using System.Linq;


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

    [Fact(DisplayName = "WorkflowStatus1Code should use Description from DerivedFrom")]
    public void WorkFlowStatus1CodeShouldHaveDescription()
    {
        LoadedRepository.Load();
        var superclass = LoadedRepository.Instance.DataDictionary.CodeSets.Where(c => c.Name == "WorkflowStatusCode").First();
        var subclass = LoadedRepository.Instance.DataDictionary.CodeSets
            .Where(c => c.Name == "WorkflowStatus1Code")
            .First();

        var superclassCodesByName = superclass.Codes.ToDictionary<string, Code>(c => c.Name);

        Assert.True(subclass.Codes.Length > 0, "No codes found");
        foreach( var subclassMember in subclass.Codes )
        {
            //Assert.False(subclassCode.Definition[0].StartsWith("?"), "Set to bogus value");
            var superclassMember = superclassCodesByName[subclassMember.GenNames.Enum];
            Assert.Equal(superclassMember.Definition[0], subclassMember.Definition[0]);
        }
    }

    [Fact(DisplayName = "WorkflowStatus1Code should use LegalCodeName from DerivedFrom")]
    public void WorkFlowStatus1CodeShouldHaveLegalCodeName()
    {
        // LoadedRepository.Load();
        var superclass = LoadedRepository.Instance.DataDictionary.CodeSets.Where(c => c.Name == "WorkflowStatusCode").First();
        var subclass = LoadedRepository.Instance.DataDictionary.CodeSets
            .Where(c => c.Name == "WorkflowStatus1Code")
            .First();

        subclass.UpdateMissingValues(superclass); // Normally called during repo load

        var superclassCodesByName = superclass.Codes.ToDictionary<string, Code>(c => c.Name);

        Assert.True(subclass.Codes.Length > 0, "No codes found");
        foreach (var subclassMember in subclass.Codes)
        {
            var superclassMember = superclassCodesByName[subclassMember.Name];
            Assert.Equal(superclassMember.CodeName, subclassMember.CodeName);
            Assert.Equal(superclassMember.LegalCodeName, superclassMember.LegalCodeName);
        }
    }
}
