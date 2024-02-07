﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndLookback2.  ISO2002 ID# _KwT9gRIlEeyLzJfz3xPQNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the pricing expressed as a rate type or a rate name complemented with lookback and crystallization days.
/// </summary>
public partial record RateTypeAndLookback2
     : IIsoXmlSerilizable<RateTypeAndLookback2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the rate type as an index type or by its name.
    /// </summary>
    public required BenchmarkCurveName13Choice_ Type { get; init; } 
    /// <summary>
    /// Number of days prior to the current day to source the rate.
    /// </summary>
    public IsoMax3NumericText? LookBackDays { get; init; } 
    /// <summary>
    /// Identifies the penultimate accrual date of the transaction to the final (repurchase) date. Crystallising the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day.
    /// </summary>
    public CrystallisationDay1? CrystallisationDate { get; init; } 
    /// <summary>
    /// Specifies the tenor of the interest rate index (when the interest rate is calculated).
    /// </summary>
    public InterestRateIndexTenor2Code? Tenor { get; init; } 
    /// <summary>
    /// Rate Index currency.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LookBackDays is IsoMax3NumericText LookBackDaysValue)
        {
            writer.WriteStartElement(null, "LookBckDays", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(LookBackDaysValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (CrystallisationDate is CrystallisationDay1 CrystallisationDateValue)
        {
            writer.WriteStartElement(null, "CrstllstnDt", xmlNamespace );
            CrystallisationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Tenor is InterestRateIndexTenor2Code TenorValue)
        {
            writer.WriteStartElement(null, "Tnr", xmlNamespace );
            writer.WriteValue(TenorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Currency is ActiveOrHistoricCurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static RateTypeAndLookback2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
