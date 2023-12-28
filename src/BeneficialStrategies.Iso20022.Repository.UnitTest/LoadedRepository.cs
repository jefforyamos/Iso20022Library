namespace BeneficialStrategies.Iso20022.Repository;

public static class LoadedRepository
{
    static LoadedRepository()
    {
        var expectedFolder = "/Users/Jeff/Downloads";
        var fullPath = Path.Combine(expectedFolder, IsoRepository.CurrentlySupportedRepoFile);
        Instance = IsoRepository.Load(fullPath);
    }

    public static IsoRepository Instance { get; }
}