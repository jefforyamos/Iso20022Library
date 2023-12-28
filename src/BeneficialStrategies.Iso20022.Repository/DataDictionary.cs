using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class DataDictionary : IsoRepoElement
{
    public DataDictionary([NotNull] XElement xElement) : base(xElement)
    {
        var codeSetList = new List<CodeSet>();
        var businessComponentsList = new List<BusinessComponentDictionaryEntry>();
        var messageComponentList = new List<MessageComponentDictionaryEntry>();
        var choiceComponentList = new List<ChoiceComponentDictionaryEntry>();
        var userDefinedList = new List<UserDefinedDictionaryEntry>();
        var textList = new List<TextDictionaryEntry>();
        var externalSchemaList = new List<ExternalSchemaDictionaryEntry>();
        var dateTimeList = new List<DateTimeDictionaryEntry>();
        var dateList = new List<DateDictionaryEntry>();
        var identifierSetList = new List<IdentifierSetDictionaryEntry>();
        var indicatorList = new List<IndicatorDictionaryEntry>();
        var quantityList = new List<QuantityDictionaryEntry>();
        var amountList = new List<AmountDictionaryEntry>();
        var timeList = new List<TimeDictionaryEntry>();
        var rateList = new List<RateDictionaryEntry>();
        var yearMonthList = new List<YearMonthDictionaryEntry>();
        var yearList = new List<YearDictionaryEntry>();
        var binaryList = new List<BinaryDictionaryEntry>();
        var schemaTypeList = new List<SchemaTypeDictionaryEntry>();
        var monthList = new List<MonthDictionaryEntry>();
        var unrecognizedList = new List<UnrecognizedDictionaryEntry>();

        var actionsByEntryType = new Dictionary<string, Action<XElement>>()
        {
            ["iso20022:CodeSet"] = e => codeSetList.Add(new (e)),
            ["iso20022:BusinessComponent"] = e => businessComponentsList.Add(new (e)),
            ["iso20022:MessageComponent"] = e => messageComponentList.Add(new (e)),
            ["iso20022:ChoiceComponent"] = e => choiceComponentList.Add(new (e)),
            ["iso20022:UserDefined"] = e => userDefinedList.Add(new(e)),
            ["iso20022:ExternalSchema"] = e => externalSchemaList.Add(new(e)),
            ["iso20022:Text"] = e => textList.Add(new(e)),
            ["iso20022:DateTime"] = e => dateList.Add(new(e)),
            ["iso20022:Date"] = e => dateList.Add(new(e)),
            ["iso20022:IdentifierSet"] = e => identifierSetList.Add(new(e)),
            ["iso20022:Indicator"] = e => indicatorList.Add(new(e)),
            ["iso20022:Quantity"] = e => quantityList.Add(new(e)),
            ["iso20022:Amount"] = e => amountList.Add(new(e)),
            ["iso20022:Time"] = e => timeList.Add(new(e)),
            ["iso20022:Rate"] = e => rateList.Add(new(e)),
            ["iso20022:YearMonth"] = e => yearMonthList.Add(new(e)),
            ["iso20022:Year"] = e => yearList.Add(new(e)),
            ["iso20022:Binary"] = e => binaryList.Add(new(e)),
            ["iso20022:SchemaType"] = e => schemaTypeList.Add(new(e)),
            ["iso20022:Month"] = e => monthList.Add(new(e)),
        };

        foreach (var node in xElement.Elements())
        {
            if (node == null) throw new NullReferenceException("Null returned from collection");
            XElement element = (XElement)node;
            var topLevelEntryType = element.Attribute(IsoXmlAttributes.Xsi.Type)?.Value ?? "(type is missing)";
            if ( actionsByEntryType.ContainsKey(topLevelEntryType))
            {
                actionsByEntryType[topLevelEntryType].Invoke(element);
            }
            else
            {
                Debug.Fail($"Why does {topLevelEntryType} not have an associated action?");
                unrecognizedList.Add(new UnrecognizedDictionaryEntry(element));
            }
        }
        CodeSets = codeSetList.ToImmutableArray();
        CodeSetsById = CodeSets.ToImmutableDictionary(i => i.Id);

        foreach(CodeSet parentCodeSet in CodeSets.Where(cs => cs.DerivationItems.Length > 0))
        {
            var list = new List<CodeSet>();
            foreach(var childItemId in parentCodeSet.DerivationItems)
            {
                var childCodeSet = CodeSetsById.ContainsKey(childItemId) ? CodeSetsById[childItemId] : null;
                if ( childCodeSet is not null)
                {
                    childCodeSet.DerivedFrom = parentCodeSet;
                    childCodeSet.UpdateMissingValues(parentCodeSet);
                    list.Add(childCodeSet);
                }
            }
            parentCodeSet.Derivations = list.ToArray();
        }

        BusinessComponents = businessComponentsList.ToImmutableArray();
        BusinessComponentsById = BusinessComponents.ToImmutableDictionary(i => i.Id);

        MessageComponents = messageComponentList.ToImmutableArray();
        MessageComponentsById = MessageComponents.ToImmutableDictionary(i => i.Id);

        Choices = choiceComponentList.ToImmutableArray();
        ChoicesById = Choices.ToImmutableDictionary(i => i.Id);

        UserDefinedEntries = userDefinedList.ToImmutableArray();
        UserDefinedEntriesById = UserDefinedEntries.ToImmutableDictionary(i => i.Id);

        ExternalSchemas = externalSchemaList.ToImmutableArray();
        ExternalSchemasById = ExternalSchemas.ToImmutableDictionary(i => i.Id);

        Texts = textList.ToImmutableArray();
        TextsById = textList.ToImmutableDictionary(i => i.Id);

        DateTimes = dateTimeList.ToImmutableArray();
        DateTimesById = DateTimes.ToImmutableDictionary(i => i.Id);

        Dates = dateList.ToImmutableArray();
        DatesById = Dates.ToImmutableDictionary(i => i.Id);

        IdentifierSets = identifierSetList.ToImmutableArray();
        IdentifierSetsById = IdentifierSets.ToImmutableDictionary(i => i.Id);

        IndicatorSets = indicatorList.ToImmutableArray();
        var dict = new Dictionary<string, IndicatorDictionaryEntry>();
        foreach(var ind in IndicatorSets)
        {
            if (!dict.TryAdd(ind.Id, ind)) Debug.Fail("Why will this not load?");
        }
        IndicatorSetsById = dict.ToImmutableDictionary();

        Quantities = quantityList.ToImmutableArray();
        QuantitiesById = Quantities.ToImmutableDictionary(i => i.Id);

        Amounts = amountList.ToImmutableArray();
        AmountsById = Amounts.ToImmutableDictionary(i => i.Id);

        Times = timeList.ToImmutableArray();
        TimesById = Times.ToImmutableDictionary(i => i.Id);

        Rates = rateList.ToImmutableArray();
        RatesById = Rates.ToImmutableDictionary(i => i.Id);

        YearMonths = yearMonthList.ToImmutableArray();
        YearMonthsById = YearMonths.ToImmutableDictionary(i => i.Id);

        Years = yearList.ToImmutableArray();
        YearsById = Years.ToImmutableDictionary(i => i.Id);

        Binaries = binaryList.ToImmutableArray();
        BinariesById = Binaries.ToImmutableDictionary(i => i.Id);

        SchemaTypes = schemaTypeList.ToImmutableArray();
        SchemaTypesById = SchemaTypes.ToImmutableDictionary(i => i.Id);

        Months = monthList.ToImmutableArray();
        MonthsById = Months.ToImmutableDictionary(i => i.Id);

        UnrecognizedEntries = unrecognizedList.ToImmutableArray();
        UnrecognizedEntriesById = UnrecognizedEntries.ToImmutableDictionary(i => i.Id);
    }

    public ImmutableArray<CodeSet> CodeSets { get; }
    public ImmutableArray<BusinessComponentDictionaryEntry> BusinessComponents { get; }
    public ImmutableArray<MessageComponentDictionaryEntry> MessageComponents { get; }
    public ImmutableArray<ChoiceComponentDictionaryEntry> Choices { get; }
    public ImmutableArray<UserDefinedDictionaryEntry> UserDefinedEntries { get; }
    public ImmutableArray<ExternalSchemaDictionaryEntry> ExternalSchemas { get; }
    public ImmutableArray<TextDictionaryEntry> Texts { get; }
    public ImmutableArray<DateTimeDictionaryEntry> DateTimes { get; }
    public ImmutableArray<DateDictionaryEntry> Dates { get; }
    public ImmutableArray<IdentifierSetDictionaryEntry> IdentifierSets { get; }
    public ImmutableArray<IndicatorDictionaryEntry> IndicatorSets { get; }
    public ImmutableArray<QuantityDictionaryEntry> Quantities { get; }
    public ImmutableArray<AmountDictionaryEntry> Amounts { get; }
    public ImmutableArray<TimeDictionaryEntry> Times { get; }
    public ImmutableArray<RateDictionaryEntry> Rates { get; }
    public ImmutableArray<YearMonthDictionaryEntry> YearMonths { get; }
    public ImmutableArray<YearDictionaryEntry> Years { get; }
    public ImmutableArray<BinaryDictionaryEntry> Binaries { get; }
    public ImmutableArray<SchemaTypeDictionaryEntry> SchemaTypes { get; }
    public ImmutableArray<MonthDictionaryEntry> Months { get; }
    public ImmutableArray<UnrecognizedDictionaryEntry> UnrecognizedEntries { get; }

    public ImmutableDictionary<string,CodeSet> CodeSetsById { get; }
    public ImmutableDictionary<string,BusinessComponentDictionaryEntry> BusinessComponentsById { get; }
    public ImmutableDictionary<string,MessageComponentDictionaryEntry> MessageComponentsById { get; }
    public ImmutableDictionary<string,ChoiceComponentDictionaryEntry> ChoicesById { get; }
    public ImmutableDictionary<string,UserDefinedDictionaryEntry> UserDefinedEntriesById { get; }
    public ImmutableDictionary<string,ExternalSchemaDictionaryEntry> ExternalSchemasById { get; }
    public ImmutableDictionary<string,TextDictionaryEntry> TextsById { get; }
    public ImmutableDictionary<string,DateTimeDictionaryEntry> DateTimesById { get; }
    public ImmutableDictionary<string,DateDictionaryEntry> DatesById { get; }
    public ImmutableDictionary<string,IdentifierSetDictionaryEntry> IdentifierSetsById { get; }
    public ImmutableDictionary<string,IndicatorDictionaryEntry> IndicatorSetsById { get; }
    public ImmutableDictionary<string,QuantityDictionaryEntry> QuantitiesById { get; }
    public ImmutableDictionary<string,AmountDictionaryEntry> AmountsById { get; }
    public ImmutableDictionary<string,TimeDictionaryEntry> TimesById { get; }
    public ImmutableDictionary<string,RateDictionaryEntry> RatesById { get; }
    public ImmutableDictionary<string,YearMonthDictionaryEntry> YearMonthsById { get; }
    public ImmutableDictionary<string,YearDictionaryEntry> YearsById { get; }
    public ImmutableDictionary<string,BinaryDictionaryEntry> BinariesById { get; }
    public ImmutableDictionary<string,SchemaTypeDictionaryEntry> SchemaTypesById { get; }
    public ImmutableDictionary<string,MonthDictionaryEntry> MonthsById { get; }
    public ImmutableDictionary<string,UnrecognizedDictionaryEntry> UnrecognizedEntriesById { get; }
}

