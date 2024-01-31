﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationRequestV09.  ISO2002 ID# _j7RWsS4_EeunNvJlR_vCbg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.
/// If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.|If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.")]
public partial record AcceptorReconciliationRequestV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnReq";
    
    #nullable enable
    /// <summary>
    /// Reconciliation request message management information.
    /// </summary>
    [IsoId("_j7RWtS4_EeunNvJlR_vCbg")]
    [Description(@"Reconciliation request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the reconciliation request.
    /// </summary>
    [IsoId("_j7RWty4_EeunNvJlR_vCbg")]
    [Description(@"Information related to the reconciliation request.")]
    [DataMember(Name="RcncltnReq")]
    [XmlElement(ElementName="RcncltnReq")]
    [Required]
    public required AcceptorReconciliationRequest9 ReconciliationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_j7RWuS4_EeunNvJlR_vCbg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType27? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorReconciliationRequestV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationRequestV09Document ToDocument()
    {
        return new AcceptorReconciliationRequestV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorReconciliationRequestV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorReconciliationRequestV09Document : IOuterDocument<AcceptorReconciliationRequestV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.009.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorReconciliationRequestV09"/> is required.
    /// </summary>
    public required AcceptorReconciliationRequestV09 Message { get; init; }
}
