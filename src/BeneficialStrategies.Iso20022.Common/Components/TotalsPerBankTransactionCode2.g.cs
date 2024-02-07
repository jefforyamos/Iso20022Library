﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalsPerBankTransactionCode2.  ISO2002 ID# _RpY9tdp-Ed-ak6NoX_4Aeg_-609547730.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the total sum of entries per bank transaction code.
/// </summary>
public partial record TotalsPerBankTransactionCode2
     : IIsoXmlSerilizable<TotalsPerBankTransactionCode2>
{
    #nullable enable
    
    /// <summary>
    /// Number of individual entries for the bank transaction code.
    /// </summary>
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    public IsoDecimalNumber? Sum { get; init; } 
    /// <summary>
    /// Total amount that is the result of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; } 
    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the bank transaction code is related to booked or forecast items.
    /// </summary>
    public IsoTrueFalseIndicator? ForecastIndicator { get; init; } 
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.
    /// </summary>
    public CashBalanceAvailability2? Availability { get; init; } 
    
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
        if (NumberOfEntries is IsoMax15NumericText NumberOfEntriesValue)
        {
            writer.WriteStartElement(null, "NbOfNtries", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax15NumericText(NumberOfEntriesValue)); // data type Max15NumericText System.String
            writer.WriteEndElement();
        }
        if (Sum is IsoDecimalNumber SumValue)
        {
            writer.WriteStartElement(null, "Sum", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(SumValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (TotalNetEntryAmount is IsoDecimalNumber TotalNetEntryAmountValue)
        {
            writer.WriteStartElement(null, "TtlNetNtryAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(TotalNetEntryAmountValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (CreditDebitIndicator is CreditDebitCode CreditDebitIndicatorValue)
        {
            writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
            writer.WriteValue(CreditDebitIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ForecastIndicator is IsoTrueFalseIndicator ForecastIndicatorValue)
        {
            writer.WriteStartElement(null, "FcstInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ForecastIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BkTxCd", xmlNamespace );
        BankTransactionCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Availability is CashBalanceAvailability2 AvailabilityValue)
        {
            writer.WriteStartElement(null, "Avlbty", xmlNamespace );
            AvailabilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TotalsPerBankTransactionCode2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
