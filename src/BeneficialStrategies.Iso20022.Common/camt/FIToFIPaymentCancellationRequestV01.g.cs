﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFIPaymentCancellationRequestV01.  ISO2002 ID# _YcuGuNE-Ed-BzquC8wXy7w_390093478.
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
/// The FIToFI Payment Cancellation Request message is sent by a case creator/case assigner to a case assignee.
/// This message is used to request the cancellation of an original payment instruction. The FIToFI Payment Cancellation Request message is exchanged between the instructing agent and the instructed agent to request the cancellation of a interbank payment message previously sent (such as FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit or FinancialInstitutionCreditTransfer).
/// Usage
/// The FIToFI Payment Cancellation Request message must be answered with a:
/// - Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation
/// - Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)
/// - Reject Investigation message when the case assignee is unable or not authorised to perform the requested cancellation
/// - Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.
/// A FIToFI Payment Cancellation Request message concerns one and only one original payment instruction at a time.
/// When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.
/// The processing of a FIToFI Payment Cancellation Request message case may lead to a Debit Authorisation Request message sent to the creditor by its account servicing institution.
/// The FIToFI Payment Cancellation Request message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original FIToFI Payment Cancellation Request message and the element ReopenCaseIndication is set to 'Yes' or 'true'.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The FIToFI Payment Cancellation Request message is sent by a case creator/case assigner to a case assignee.|This message is used to request the cancellation of an original payment instruction. The FIToFI Payment Cancellation Request message is exchanged between the instructing agent and the instructed agent to request the cancellation of a interbank payment message previously sent (such as FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit or FinancialInstitutionCreditTransfer).|Usage|The FIToFI Payment Cancellation Request message must be answered with a:|- Resolution Of Investigation message with a positive final outcome when the case assignee can perform the requested cancellation|- Resolution Of Investigation message with a negative final outcome when the case assignee may perform the requested cancellation but fails to do so (too late, irrevocable instruction.)|- Reject Investigation message when the case assignee is unable or not authorised to perform the requested cancellation|- Notification Of Case Assignment message to indicate whether the case assignee will take on the case himself or reassign the case to a subsequent party in the payment processing chain.|A FIToFI Payment Cancellation Request message concerns one and only one original payment instruction at a time.|When a case assignee successfully performs a cancellation, it must return the corresponding funds to the case assigner. It may provide some details about the return in the Resolution Of Investigation message.|The processing of a FIToFI Payment Cancellation Request message case may lead to a Debit Authorisation Request message sent to the creditor by its account servicing institution.|The FIToFI Payment Cancellation Request message may be used to escalate a case after an unsuccessful request to modify the payment. In this scenario, the case identification remains the same as in the original FIToFI Payment Cancellation Request message and the element ReopenCaseIndication is set to 'Yes' or 'true'.")]
public partial record FIToFIPaymentCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFIPmtCxlReq";
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_YcuGudE-Ed-BzquC8wXy7w_518526020")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment2 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_YcuGutE-Ed-BzquC8wXy7w_390093510")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public Case2? Case { get; init; }
    
    /// <summary>
    /// Provides details on the number of transactions and the control sum of the message.
    /// </summary>
    [IsoId("_YcuGu9E-Ed-BzquC8wXy7w_533303218")]
    [Description(@"Provides details on the number of transactions and the control sum of the message.")]
    [DataMember(Name="CtrlData")]
    [XmlElement(ElementName="CtrlData")]
    public ControlData1? ControlData { get; init; }
    
    /// <summary>
    /// Identifies the payment instruction to be cancelled.
    /// </summary>
    [IsoId("_YcuGvNE-Ed-BzquC8wXy7w_390093571")]
    [Description(@"Identifies the payment instruction to be cancelled.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required UnderlyingTransaction2 Underlying { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFIPaymentCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFIPaymentCancellationRequestV01Document ToDocument()
    {
        return new FIToFIPaymentCancellationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFIPaymentCancellationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FIToFIPaymentCancellationRequestV01Document : IOuterDocument<FIToFIPaymentCancellationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.056.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFIPaymentCancellationRequestV01"/> is required.
    /// </summary>
    public required FIToFIPaymentCancellationRequestV01 Message { get; init; }
}
