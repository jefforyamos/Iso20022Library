﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedSecuritiesTransactionDetailsSD5.  ISO2002 ID# _SNzve52IEeW-bsa36JFb9A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated securities transactions.
/// </summary>
public partial record CorporateActionUnallocatedSecuritiesTransactionDetailsSD5
     : IIsoXmlSerilizable<CorporateActionUnallocatedSecuritiesTransactionDetailsSD5>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType3Code? ReasonCode { get; init; } 
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    public DTCUnallocatedAdjustmentReason2Code? UnallocatedReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    
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
        if (ReasonCode is DTCAdjustmentPaymentType3Code ReasonCodeValue)
        {
            writer.WriteStartElement(null, "RsnCd", xmlNamespace );
            writer.WriteValue(ReasonCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (TransactionQuantity is FinancialInstrumentQuantity15Choice_ TransactionQuantityValue)
        {
            writer.WriteStartElement(null, "TxQty", xmlNamespace );
            TransactionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnallocatedReasonCode is DTCUnallocatedAdjustmentReason2Code UnallocatedReasonCodeValue)
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
        if (EarliestPaymentDate is DateFormat28Choice_ EarliestPaymentDateValue)
        {
            writer.WriteStartElement(null, "EarlstPmtDt", xmlNamespace );
            EarliestPaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionUnallocatedSecuritiesTransactionDetailsSD5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
