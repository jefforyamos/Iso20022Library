﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection32.  ISO2002 ID# _0lAqvAlIEeGATtfOBToyew_-1293179629.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
public partial record AmountAndDirection32
     : IIsoXmlSerilizable<AmountAndDirection32>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the net proceeds include interest accrued on the financial instrument.
    /// </summary>
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; } 
    /// <summary>
    /// Whether the net proceeds include stamp duty amount.
    /// </summary>
    public IsoYesNoIndicator? StampDutyIndicator { get; init; } 
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    
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
        if (AccruedInterestIndicator is IsoYesNoIndicator AccruedInterestIndicatorValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AccruedInterestIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (StampDutyIndicator is IsoYesNoIndicator StampDutyIndicatorValue)
        {
            writer.WriteStartElement(null, "StmpDtyInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(StampDutyIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Amount is IsoActiveCurrencyAndAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(AmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CreditDebitIndicator is CreditDebitCode CreditDebitIndicatorValue)
        {
            writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
            writer.WriteValue(CreditDebitIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OriginalCurrencyAndOrderedAmount is IsoActiveOrHistoricCurrencyAndAmount OriginalCurrencyAndOrderedAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlCcyAndOrdrdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalCurrencyAndOrderedAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms11 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueDate is DateAndDateTimeChoice_ ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            ValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AmountAndDirection32 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
