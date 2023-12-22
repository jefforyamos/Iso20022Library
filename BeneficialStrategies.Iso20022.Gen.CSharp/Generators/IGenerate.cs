using BeneficialStrategies.Iso20022.Repository;

namespace BeneficialStrategies.Iso20022.Gen.CSharp;

public interface IGenerate
{
    void Generate(IsoRepository repo, DirectoryInfo projectDirectoryRoot);
}
