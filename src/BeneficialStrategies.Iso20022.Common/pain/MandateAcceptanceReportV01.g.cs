﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateAcceptanceReportV01.  ISO2002 ID# _GX7CUtEvEd-BzquC8wXy7w_2092980503.
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
/// This record is an implementation of the pain.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).
/// A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. |Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.
/// Usage
/// The MandateAcceptanceReport message can contain only one confirmation of acceptance of rejection of one specific MandateRequest message.
/// The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.
/// The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).|A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. |Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.|Usage|The MandateAcceptanceReport message can contain only one confirmation of acceptance of rejection of one specific MandateRequest message.|The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.|The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.")]
public partial record MandateAcceptanceReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAccptncRpt";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.
    /// </summary>
    [IsoId("_GX7CU9EvEd-BzquC8wXy7w_-1730068754")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader31 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to provide information on the acception or rejection of the mandate request.
    /// </summary>
    [IsoId("_GX7CVNEvEd-BzquC8wXy7w_1787356156")]
    [Description(@"Set of elements used to provide information on the acception or rejection of the mandate request.")]
    [DataMember(Name="UndrlygAccptncDtls")]
    [XmlElement(ElementName="UndrlygAccptncDtls")]
    [Required]
    public required MandateAcceptance1 UnderlyingAcceptanceDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateAcceptanceReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateAcceptanceReportV01Document ToDocument()
    {
        return new MandateAcceptanceReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateAcceptanceReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateAcceptanceReportV01Document : IOuterDocument<MandateAcceptanceReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateAcceptanceReportV01"/> is required.
    /// </summary>
    public required MandateAcceptanceReportV01 Message { get; init; }
}
