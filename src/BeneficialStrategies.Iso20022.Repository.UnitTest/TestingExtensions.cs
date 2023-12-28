using System.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public static class TestingExtensions
{
    public static CodeSet ForceReload(this CodeSet codeSetToReload)
    {
        return new CodeSet(codeSetToReload.xElement);
    }
}