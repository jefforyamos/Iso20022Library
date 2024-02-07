﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction139.  ISO2002 ID# _dwTQ-9cZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record PaymentTransaction139
     : IIsoXmlSerilizable<PaymentTransaction139>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    public IsoMax35Text? CancellationStatusIdentification { get; init; } 
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    public Case5? ResolvedCase { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? UETR { get; init; } 
    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    public CancellationStatusReason4? CancellationStatusReasonInformation { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    public DateAndDateTime2Choice_? OriginalRequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    public IsoISODate? OriginalRequestedCollectionDate { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference35? OriginalTransactionReference { get; init; } 
    
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
        if (CancellationStatusIdentification is IsoMax35Text CancellationStatusIdentificationValue)
        {
            writer.WriteStartElement(null, "CxlStsId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationStatusIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ResolvedCase is Case5 ResolvedCaseValue)
        {
            writer.WriteStartElement(null, "RslvdCase", xmlNamespace );
            ResolvedCaseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalInstructionIdentification is IsoMax35Text OriginalInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalEndToEndIdentification is IsoMax35Text OriginalEndToEndIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlEndToEndId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalEndToEndIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (UETR is IsoUUIDv4Identifier UETRValue)
        {
            writer.WriteStartElement(null, "UETR", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoUUIDv4Identifier(UETRValue)); // data type UUIDv4Identifier System.String
            writer.WriteEndElement();
        }
        if (TransactionCancellationStatus is CancellationIndividualStatus1Code TransactionCancellationStatusValue)
        {
            writer.WriteStartElement(null, "TxCxlSts", xmlNamespace );
            writer.WriteValue(TransactionCancellationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CancellationStatusReasonInformation is CancellationStatusReason4 CancellationStatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "CxlStsRsnInf", xmlNamespace );
            CancellationStatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalInstructedAmount is IsoActiveOrHistoricCurrencyAndAmount OriginalInstructedAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlInstdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalInstructedAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OriginalRequestedExecutionDate is DateAndDateTime2Choice_ OriginalRequestedExecutionDateValue)
        {
            writer.WriteStartElement(null, "OrgnlReqdExctnDt", xmlNamespace );
            OriginalRequestedExecutionDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalRequestedCollectionDate is IsoISODate OriginalRequestedCollectionDateValue)
        {
            writer.WriteStartElement(null, "OrgnlReqdColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OriginalRequestedCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (OriginalTransactionReference is OriginalTransactionReference35 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransaction139 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
