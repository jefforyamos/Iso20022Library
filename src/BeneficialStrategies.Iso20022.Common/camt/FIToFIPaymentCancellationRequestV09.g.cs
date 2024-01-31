﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFIPaymentCancellationRequestV09.  ISO2002 ID# _LwAM7cP_Eemsic1bQcEtLA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// Scope
/// The FIToFIPaymentCancellationRequest message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the cancellation of an original payment instruction. The FIToFIPaymentCancellationRequest message is exchanged between the instructing agent and the instructed agent to request the cancellation of a interbank payment message previously sent (such as FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit or FinancialInstitutionCreditTransfer).
/// The FIToFIPaymentCancellationRequest message supports both the request for cancellation (the instructed agent - or assignee - has not yet processed and forwarded the payment instruction) as well as the request for refund (payment has been fully processed already by the instructed agent - or assignee).
/// Usage
/// The FIToFIPaymentCancellationRequest message must be answered with a:
/// - ResolutionOfInvestigation message with a positive final outcome when the case assignee can perform the requested cancellation;
/// - ResolutionOfInvestigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction);
/// - RejectInvestigation message when the case assignee is unable or not authorised to perform the requested cancellation;
/// - NotificationOfCaseAssignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// A FIToFIPaymentCancellationRequest message concerns one and only one original payment instruction at a time.
/// When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the ResolutionOfInvestigation message.
/// The processing of a FIToFIPaymentCancellationRequest message case may lead to a DebitAuthorisationRequest message sent to the creditor by its account servicing institution.
/// The FIToFIPaymentCancellationRequest message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original FIToFIPaymentCancellationRequest message and the element ReopenCaseIndication is set to 'Yes' or 'true'.
/// The FIToFIPaymentCancellationRequest message has the following main characteristics: the case creator assigns a unique case identification and the reason code for the cancellation request. This information will be passed unchanged to all subsequent case assignee(s). 
/// For the FIToFIPaymentCancellationRequest message the case has been made optional, as the message might be used outside of a case management environment where the case identification is not relevant.
/// Moreover, the case identification may be present at different levels:
/// - One unique case is defined per cancellation request message: If multiple underlying groups or transactions are present in the message and the case assignee has already forwarded the transaction for which the cancellation is requested, the case cannot be forwarded to the next party in the chain (see rule on uniqueness of the case) and the case creator will have to issue individual cancellation requests for each underlying individual transaction. In response to this cancellation request, the case must also be present at the message level in the Resolution of Investigation message;
/// - One case per original group or transaction present in the cancellation request: For each group or transaction, a unique case has been assigned. This means, when a payment instruction has already been forwarded by the case assignee, the cancellation request may be forwarded to next party in the payment chain, with the unique case assigned to the transaction. When the group can only be cancelled partially, new cancellation requests need however to be issued for the individual transactions within the group for which the cancellation request has not been successful. In response to this cancellation request, the case must be present in the cancellation details identifying the original group or transaction in the Resolution of Investigation message;
/// - No case used in cancellation request message.
/// Cancellation of a cover payment:|The cancellation of a payment instruction for which cover is provided by a separate instruction always results in the cancellation of the whole transaction, including the cover. The case assignee performing the cancellation must initiate the return of funds to the case creator. The case assigner must not request the cancellation of the cover separately.
/// Cancellation request initiators:|The cancellation of a payment instruction can be initiated by either the debtor/creditor or any subsequent agent in the payment instruction processing chain.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FIToFIPaymentCancellationRequest message is sent by a case creator/case assigner to a case assignee.|This message is used to request the cancellation of an original payment instruction. The FIToFIPaymentCancellationRequest message is exchanged between the instructing agent and the instructed agent to request the cancellation of a interbank payment message previously sent (such as FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit or FinancialInstitutionCreditTransfer).||The FIToFIPaymentCancellationRequest message supports both the request for cancellation (the instructed agent - or assignee - has not yet processed and forwarded the payment instruction) as well as the request for refund (payment has been fully processed already by the instructed agent - or assignee).||Usage|The FIToFIPaymentCancellationRequest message must be answered with a:|- ResolutionOfInvestigation message with a positive final outcome when the case assignee can perform the requested cancellation;|- ResolutionOfInvestigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction);|- RejectInvestigation message when the case assignee is unable or not authorised to perform the requested cancellation;|- NotificationOfCaseAssignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|A FIToFIPaymentCancellationRequest message concerns one and only one original payment instruction at a time.|When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the ResolutionOfInvestigation message.|The processing of a FIToFIPaymentCancellationRequest message case may lead to a DebitAuthorisationRequest message sent to the creditor by its account servicing institution.|The FIToFIPaymentCancellationRequest message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original FIToFIPaymentCancellationRequest message and the element ReopenCaseIndication is set to 'Yes' or 'true'.|The FIToFIPaymentCancellationRequest message has the following main characteristics: the case creator assigns a unique case identification and the reason code for the cancellation request. This information will be passed unchanged to all subsequent case assignee(s). |For the FIToFIPaymentCancellationRequest message the case has been made optional, as the message might be used outside of a case management environment where the case identification is not relevant.|Moreover, the case identification may be present at different levels:|- One unique case is defined per cancellation request message: If multiple underlying groups or transactions are present in the message and the case assignee has already forwarded the transaction for which the cancellation is requested, the case cannot be forwarded to the next party in the chain (see rule on uniqueness of the case) and the case creator will have to issue individual cancellation requests for each underlying individual transaction. In response to this cancellation request, the case must also be present at the message level in the Resolution of Investigation message;|- One case per original group or transaction present in the cancellation request: For each group or transaction, a unique case has been assigned. This means, when a payment instruction has already been forwarded by the case assignee, the cancellation request may be forwarded to next party in the payment chain, with the unique case assigned to the transaction. When the group can only be cancelled partially, new cancellation requests need however to be issued for the individual transactions within the group for which the cancellation request has not been successful. In response to this cancellation request, the case must be present in the cancellation details identifying the original group or transaction in the Resolution of Investigation message;|- No case used in cancellation request message.|Cancellation of a cover payment:|The cancellation of a payment instruction for which cover is provided by a separate instruction always results in the cancellation of the whole transaction, including the cover. The case assignee performing the cancellation must initiate the return of funds to the case creator. The case assigner must not request the cancellation of the cover separately.|Cancellation request initiators:|The cancellation of a payment instruction can be initiated by either the debtor/creditor or any subsequent agent in the payment instruction processing chain.")]
public partial record FIToFIPaymentCancellationRequestV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFIPmtCxlReq";
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_LwAM-8P_Eemsic1bQcEtLA")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment5 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_LwAM_cP_Eemsic1bQcEtLA")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public Case5? Case { get; init; }
    
    /// <summary>
    /// Provides details on the number of transactions and the control sum of the message.
    /// </summary>
    [IsoId("_LwAM_8P_Eemsic1bQcEtLA")]
    [Description(@"Provides details on the number of transactions and the control sum of the message.")]
    [DataMember(Name="CtrlData")]
    [XmlElement(ElementName="CtrlData")]
    public ControlData1? ControlData { get; init; }
    
    /// <summary>
    /// Identifies the payment instruction to be cancelled.
    /// </summary>
    [IsoId("_LwANAcP_Eemsic1bQcEtLA")]
    [Description(@"Identifies the payment instruction to be cancelled.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required UnderlyingTransaction26 Underlying { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LwANA8P_Eemsic1bQcEtLA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFIPaymentCancellationRequestV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFIPaymentCancellationRequestV09Document ToDocument()
    {
        return new FIToFIPaymentCancellationRequestV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFIPaymentCancellationRequestV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FIToFIPaymentCancellationRequestV09Document : IOuterDocument<FIToFIPaymentCancellationRequestV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.056.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFIPaymentCancellationRequestV09"/> is required.
    /// </summary>
    public required FIToFIPaymentCancellationRequestV09 Message { get; init; }
}
