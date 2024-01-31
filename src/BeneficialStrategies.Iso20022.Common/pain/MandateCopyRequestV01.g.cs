﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateCopyRequestV01.  ISO2002 ID# _fptHIG6qEeaUkthD_kt0tA.
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
/// This record is an implementation of the pain.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateCopyRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateCopyRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateCopyRequest message is used to request a copy of an existing mandate. If accepted, the mandate copy can be sent using the MandateAcceptanceReport message.
/// Usage
/// The MandateCopyRequest message can contain one or more copy requests.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateCopyRequest message can be used in domestic and cross-border scenarios.
/// 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateCopyRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.|The MandateCopyRequest message is forwarded by the agent of the initiator to the agent of the counterparty.|A MandateCopyRequest message is used to request a copy of an existing mandate. If accepted, the mandate copy can be sent using the MandateAcceptanceReport message.|Usage|The MandateCopyRequest message can contain one or more copy requests.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.|The MandateCopyRequest message can be used in domestic and cross-border scenarios.|")]
public partial record MandateCopyRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.017.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtCpyReq";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate copy request, but which are not part of the mandate.
    /// </summary>
    [IsoId("_9EgQ4G6tEeaUkthD_kt0tA")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the mandate copy request, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader47 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of information used to identify the mandate for which a copy is requested.
    /// </summary>
    [IsoId("_WQnekG6vEeaUkthD_kt0tA")]
    [Description(@"Set of information used to identify the mandate for which a copy is requested.")]
    [DataMember(Name="UndrlygCpyReqDtls")]
    [XmlElement(ElementName="UndrlygCpyReqDtls")]
    [Required]
    public required MandateCopy1 UnderlyingCopyRequestDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eHtPQW6yEeaUkthD_kt0tA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateCopyRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateCopyRequestV01Document ToDocument()
    {
        return new MandateCopyRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateCopyRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateCopyRequestV01Document : IOuterDocument<MandateCopyRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.017.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateCopyRequestV01"/> is required.
    /// </summary>
    public required MandateCopyRequestV01 Message { get; init; }
}
