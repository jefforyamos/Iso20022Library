﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateAmendmentRequestV01.  ISO2002 ID# _GX7CXtEvEd-BzquC8wXy7w_-355407990.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pain;


/// <summary>
/// This record is an implementation of the pain.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAmendmentRequest message is sent by the initiator of the request to his agent and/or counterparty. The initiator can both be the debtor or the creditor (or where appropriate the debtor agent).
/// The MandateAmendmentRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateAmendmentRequest message is used to request the amendment of specific information in an existing mandate. |The MandateAmendmentRequest message must reflect the new data of the element(s) to be amended and at a minimum a unique reference to the existing mandate. If accepted, this MandateAmendmentRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered as a valid amendment on an existing mandate, agreed upon by all parties. The amended mandate will from then on be considered the valid mandate.
/// Usage
/// The MandateAmendmentRequest message can contain only one request to amend one specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateAmendmentRequest message can be used in domestic and cross-border scenarios.
/// If all elements in the existing Mandate need to be amended or the underlying contract is different, then the MandateAmendmentRequest message should not be used. The existing Mandate has to be cancelled and a new Mandate has to be initiated.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateAmendmentRequest message is sent by the initiator of the request to his agent and/or counterparty. The initiator can both be the debtor or the creditor (or where appropriate the debtor agent).|The MandateAmendmentRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|A MandateAmendmentRequest message is used to request the amendment of specific information in an existing mandate. |The MandateAmendmentRequest message must reflect the new data of the element(s) to be amended and at a minimum a unique reference to the existing mandate. If accepted, this MandateAmendmentRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered as a valid amendment on an existing mandate, agreed upon by all parties. The amended mandate will from then on be considered the valid mandate.|Usage|The MandateAmendmentRequest message can contain only one request to amend one specific mandate.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateAmendmentRequest message can be used in domestic and cross-border scenarios.|If all elements in the existing Mandate need to be amended or the underlying contract is different, then the MandateAmendmentRequest message should not be used. The existing Mandate has to be cancelled and a new Mandate has to be initiated.")]
public partial record MandateAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAmdmntReq";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_GX7CX9EvEd-BzquC8wXy7w_65717989")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader31 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to provide details on the amendment request.
    /// </summary>
    [IsoId("_GYEMQNEvEd-BzquC8wXy7w_-389718479")]
    [Description(@"Set of elements used to provide details on the amendment request.")]
    [DataMember(Name="UndrlygAmdmntDtls")]
    [XmlElement(ElementName="UndrlygAmdmntDtls")]
    [Required]
    public required MandateAmendment1 UnderlyingAmendmentDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateAmendmentRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateAmendmentRequestV01Document ToDocument()
    {
        return new MandateAmendmentRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateAmendmentRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateAmendmentRequestV01Document : IOuterDocument<MandateAmendmentRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateAmendmentRequestV01"/> is required.
    /// </summary>
    public required MandateAmendmentRequestV01 Message { get; init; }
}
