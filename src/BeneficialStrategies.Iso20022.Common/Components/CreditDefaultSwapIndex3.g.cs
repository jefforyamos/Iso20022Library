﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditDefaultSwapIndex3.  ISO2002 ID# _p6MhkSe1Eei12pGEsJIAeQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting derivatives on a credit default swap index.
/// </summary>
public partial record CreditDefaultSwapIndex3
     : IIsoXmlSerilizable<CreditDefaultSwapIndex3>
{
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying index.
    /// </summary>
    public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; } 
    /// <summary>
    /// To be populated for derivatives on a CDS index with the standardized name of the index.
    /// </summary>
    public IsoMax25Text? UnderlyingIndexName { get; init; } 
    /// <summary>
    /// Series number of the composition of the index if applicable.
    /// </summary>
    public IsoNumber? Series { get; init; } 
    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// All months when the roll is expected as established by the index provider for a given year. Field should be repeated for each month in the roll.
    /// </summary>
    public SimpleValueList<IsoRestrictedMonthExact2Number> RollMonth { get; init; } = [];
    /// <summary>
    /// To be populated in the case of a CDS Index or a derivative CDS Index with the next roll date of the index as established by the index provider.
    /// </summary>
    public IsoISODate? NextRollDate { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (UnderlyingIndexIdentification is IsoISINOct2015Identifier UnderlyingIndexIdentificationValue)
        {
            writer.WriteStartElement(null, "UndrlygIndxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(UnderlyingIndexIdentificationValue)); // data type ISINOct2015Identifier System.String
            writer.WriteEndElement();
        }
        if (UnderlyingIndexName is IsoMax25Text UnderlyingIndexNameValue)
        {
            writer.WriteStartElement(null, "UndrlygIndxNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax25Text(UnderlyingIndexNameValue)); // data type Max25Text System.String
            writer.WriteEndElement();
        }
        if (Series is IsoNumber SeriesValue)
        {
            writer.WriteStartElement(null, "Srs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(SeriesValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (Version is IsoNumber VersionValue)
        {
            writer.WriteStartElement(null, "Vrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(VersionValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RollMnth", xmlNamespace );
        RollMonth.Serialize(writer, xmlNamespace, "RestrictedMonthExact2Number", SerializationFormatter.IsoRestrictedMonthExact2Number );
        writer.WriteEndElement();
        if (NextRollDate is IsoISODate NextRollDateValue)
        {
            writer.WriteStartElement(null, "NxtRollDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(NextRollDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "NtnlCcy", xmlNamespace );
        writer.WriteValue(NotionalCurrency.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static CreditDefaultSwapIndex3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
