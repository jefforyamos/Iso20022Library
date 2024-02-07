﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedCashTransactionDetailsSD6.  ISO2002 ID# _O8s7cMMPEee-Vv_OVx0uAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated cash transactions.
/// </summary>
public partial record CorporateActionUnallocatedCashTransactionDetailsSD6
     : IIsoXmlSerilizable<CorporateActionUnallocatedCashTransactionDetailsSD6>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; init; } 
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    public DateFormat48Choice_? EarliestPaymentDate { get; init; } 
    
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
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (ReasonCode is DTCAdjustmentPaymentType5Code ReasonCodeValue)
        {
            writer.WriteStartElement(null, "RsnCd", xmlNamespace );
            writer.WriteValue(ReasonCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionAmount is IsoRestrictedFINActiveCurrencyAndAmount TransactionAmountValue)
        {
            writer.WriteStartElement(null, "TxAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAndAmount(TransactionAmountValue)); // data type RestrictedFINActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (UnallocatedReasonCode is DTCUnallocatedAdjustmentReason4Code UnallocatedReasonCodeValue)
        {
            writer.WriteStartElement(null, "UallctdRsnCd", xmlNamespace );
            writer.WriteValue(UnallocatedReasonCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ContraParticipantNumber is IsoMax8Text ContraParticipantNumberValue)
        {
            writer.WriteStartElement(null, "ContraPtcptNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax8Text(ContraParticipantNumberValue)); // data type Max8Text System.String
            writer.WriteEndElement();
        }
        if (EarliestPaymentDate is DateFormat48Choice_ EarliestPaymentDateValue)
        {
            writer.WriteStartElement(null, "EarlstPmtDt", xmlNamespace );
            EarliestPaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionUnallocatedCashTransactionDetailsSD6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
