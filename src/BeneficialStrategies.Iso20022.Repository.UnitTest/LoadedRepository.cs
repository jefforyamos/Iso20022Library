namespace BeneficialStrategies.Iso20022.Repository;

public static class LoadedRepository
{
    static LoadedRepository()
    {
        Instance = Reload();
    }

    public static IsoRepository Reload()
    {
        var expectedFolder = "/Users/Jeff/Downloads";
        var fullPath = Path.Combine(expectedFolder, IsoRepository.CurrentlySupportedRepoFile);
        return Instance = IsoRepository.Load(fullPath);
    }

    public static IsoRepository Instance { get; private set; }
}