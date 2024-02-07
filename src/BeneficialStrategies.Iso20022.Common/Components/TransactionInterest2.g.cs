﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionInterest2.  ISO2002 ID# _SSzuINp-Ed-ak6NoX_4Aeg_-309357356.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide transaction specific interest information that applies to the underlying transaction.
/// </summary>
public partial record TransactionInterest2
     : IIsoXmlSerilizable<TransactionInterest2>
{
    #nullable enable
    
    /// <summary>
    /// Amount of interest included in the entry amount.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the interest amount included in the entry is credit or debit amount.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    public InterestType1Choice_? Type { get; init; } 
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    public Rate3? Rate { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    public DateTimePeriodDetails? FromToDate { get; init; } 
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    public IsoMax35Text? Reason { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (Type is InterestType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Rate is Rate3 RateValue)
        {
            writer.WriteStartElement(null, "Rate", xmlNamespace );
            RateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FromToDate is DateTimePeriodDetails FromToDateValue)
        {
            writer.WriteStartElement(null, "FrToDt", xmlNamespace );
            FromToDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Reason is IsoMax35Text ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static TransactionInterest2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
