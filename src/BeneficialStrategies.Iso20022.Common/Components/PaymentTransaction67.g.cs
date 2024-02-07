﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction67.  ISO2002 ID# _lNbPFzq3EeWZFYSPlduMhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record PaymentTransaction67
     : IIsoXmlSerilizable<PaymentTransaction67>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    public IsoMax35Text? CancellationStatusIdentification { get; init; } 
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    public Case3? ResolvedCase { get; init; } 
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalClearingSystemReference { get; init; } 
    /// <summary>
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; } 
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    public CancellationStatusReason2? CancellationStatusReasonInformation { get; init; } 
    /// <summary>
    /// Reference of a return or a reversal transaction that is initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    public ResolutionInformation1? ResolutionRelatedInformation { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
    /// <summary>
    /// Party who assigns the case.|Usage: This is also the agent that instructs the next party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    public Party12Choice_? Assigner { get; init; } 
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the agent that is instructed by the previous party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    public Party12Choice_? Assignee { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference22? OriginalTransactionReference { get; init; } 
    
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
        if (ResolvedCase is Case3 ResolvedCaseValue)
        {
            writer.WriteStartElement(null, "RslvdCase", xmlNamespace );
            ResolvedCaseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalGroupInformation is OriginalGroupInformation3 OriginalGroupInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlGrpInf", xmlNamespace );
            OriginalGroupInformationValue.Serialize(writer, xmlNamespace);
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
        if (OriginalTransactionIdentification is IsoMax35Text OriginalTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalClearingSystemReference is IsoMax35Text OriginalClearingSystemReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlClrSysRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalClearingSystemReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionCancellationStatus is CancellationIndividualStatus1Code TransactionCancellationStatusValue)
        {
            writer.WriteStartElement(null, "TxCxlSts", xmlNamespace );
            writer.WriteValue(TransactionCancellationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CancellationStatusReasonInformation is CancellationStatusReason2 CancellationStatusReasonInformationValue)
        {
            writer.WriteStartElement(null, "CxlStsRsnInf", xmlNamespace );
            CancellationStatusReasonInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResolutionRelatedInformation is ResolutionInformation1 ResolutionRelatedInformationValue)
        {
            writer.WriteStartElement(null, "RsltnRltdInf", xmlNamespace );
            ResolutionRelatedInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalInterbankSettlementAmount is IsoActiveOrHistoricCurrencyAndAmount OriginalInterbankSettlementAmountValue)
        {
            writer.WriteStartElement(null, "OrgnlIntrBkSttlmAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(OriginalInterbankSettlementAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (OriginalInterbankSettlementDate is IsoISODate OriginalInterbankSettlementDateValue)
        {
            writer.WriteStartElement(null, "OrgnlIntrBkSttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OriginalInterbankSettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Assigner is Party12Choice_ AssignerValue)
        {
            writer.WriteStartElement(null, "Assgnr", xmlNamespace );
            AssignerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Assignee is Party12Choice_ AssigneeValue)
        {
            writer.WriteStartElement(null, "Assgne", xmlNamespace );
            AssigneeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalTransactionReference is OriginalTransactionReference22 OriginalTransactionReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlTxRef", xmlNamespace );
            OriginalTransactionReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PaymentTransaction67 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
