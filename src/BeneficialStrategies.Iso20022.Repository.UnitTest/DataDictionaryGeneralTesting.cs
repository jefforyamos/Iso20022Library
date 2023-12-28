namespace BeneficialStrategies.Iso20022.Repository;

public class DataDictionaryGeneralTesting
{
    private readonly ITestOutputHelper _output;

    public DataDictionaryGeneralTesting(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper;
    }

    [Fact(DisplayName = "Used to test the load process for all the types supported by the data dictionary")]
    public void LoadRepo()
    {
        var repo = LoadedRepository.Reload();
        var dd = repo.DataDictionary;
        AssertMinimalCount(dd.CodeSets, dd.CodeSetsById, 3860);
        AssertMinimalCount(dd.BusinessComponents, dd.BusinessComponentsById, 783);
        AssertMinimalCount(dd.Amounts, dd.AmountsById, 21);
        AssertMinimalCount(dd.Binaries, dd.BinariesById, 17);
        AssertMinimalCount(dd.Choices, dd.ChoicesById, 3872);
        AssertMinimalCount(dd.Dates, dd.DatesById, 3);
        AssertMinimalCount(dd.DateTimes, dd.DateTimesById, 0);
        AssertMinimalCount(dd.ExternalSchemas, dd.ExternalSchemasById, 6);
        AssertMinimalCount(dd.IdentifierSets, dd.IdentifierSetsById, 69);
        AssertMinimalCount(dd.IndicatorSets, dd.IndicatorSetsById, 14);
        AssertMinimalCount(dd.MessageComponents, dd.MessageComponentsById, 12653);
        AssertMinimalCount(dd.Months, dd.MonthsById, 1);
        AssertMinimalCount(dd.Quantities, dd.QuantitiesById, 25);
        AssertMinimalCount(dd.Rates, dd.RatesById, 7);
        AssertMinimalCount(dd.SchemaTypes, dd.SchemaTypesById, 44);
        AssertMinimalCount(dd.Texts, dd.TextsById, 153);
        AssertMinimalCount(dd.Times, dd.TimesById, 1);
        AssertMinimalCount(dd.UnrecognizedEntries, dd.UnrecognizedEntriesById, 0);
    }

    private void AssertMinimalCount<T>( IEnumerable<T> list, IDictionary<string, T> dictionary, int minimumCount)
        where T : IsoRepoElement
    {
        _output.WriteLine($@"{typeof(T).Name} : {list.Count()} records.");
        Assert.True(list.Count() >= minimumCount, $@"This list containing {typeof(T).Name} values should have at least {minimumCount} but only has {list.Count()}.");
        Assert.True(list.Count() == dictionary.Count(), $@"The list of {typeof(T).Name} values contains {list.Count()}, but the dictionary contains {dictionary.Count()}. ");
    }
}