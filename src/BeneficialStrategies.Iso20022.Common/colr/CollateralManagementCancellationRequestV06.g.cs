﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralManagementCancellationRequestV06.  ISO2002 ID# _yXxLsSW0EeyT3chuyX0PgA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.colr;


/// <summary>
/// This record is an implementation of the colr.005.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralManagementCancellationRequest message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager,
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// This message is used to request the cancellation of a previously sent MarginCallRequest message, MarginCallResponse message, CollateralProposal message, CollateralProposalResponse message, MarginCallDisputeNotification message or a CollateralSubstitutionRequest message.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// The CollateralManagementCancellationRequest message is used to request the cancellation of a collateral message. When requesting the cancellation of a message there must be a cancellation reason specified.
/// When the CollateralManagementCancellationRequest message is used to cancel a collateral message the reference of the original message must be specified. The rejection or acceptance of a CollateralManagementCancellationRequest message is made using a CollateralManagementCancellationStatus message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CollateralManagementCancellationRequest message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager,|- the collateral giver or its collateral manager to the collateral taker or its collateral manager|This message is used to request the cancellation of a previously sent MarginCallRequest message, MarginCallResponse message, CollateralProposal message, CollateralProposalResponse message, MarginCallDisputeNotification message or a CollateralSubstitutionRequest message.|The message definition is intended for use with the ISO20022 Business Application Header.|Usage|The CollateralManagementCancellationRequest message is used to request the cancellation of a collateral message. When requesting the cancellation of a message there must be a cancellation reason specified.|When the CollateralManagementCancellationRequest message is used to cancel a collateral message the reference of the original message must be specified. The rejection or acceptance of a CollateralManagementCancellationRequest message is made using a CollateralManagementCancellationStatus message.")]
public partial record CollateralManagementCancellationRequestV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.005.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollMgmtCxlReq";
    
    #nullable enable
    /// <summary>
    /// Reference to the message advised to be cancelled.
    /// </summary>
    [IsoId("_yXxLuyW0EeyT3chuyX0PgA")]
    [Description(@"Reference to the message advised to be cancelled.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    [Required]
    public required Reference3Choice_ Reference { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_yXxLvSW0EeyT3chuyX0PgA")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation8 Obligation { get; init; }
    
    /// <summary>
    /// It is used to detail the reason for the cancellation of a previously sent request.
    /// </summary>
    [IsoId("_yXxLvyW0EeyT3chuyX0PgA")]
    [Description(@"It is used to detail the reason for the cancellation of a previously sent request.")]
    [DataMember(Name="CxlRsn")]
    [XmlElement(ElementName="CxlRsn")]
    [Required]
    public required CollateralCancellationReason1 CancellationReason { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXxLwSW0EeyT3chuyX0PgA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralManagementCancellationRequestV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralManagementCancellationRequestV06Document ToDocument()
    {
        return new CollateralManagementCancellationRequestV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralManagementCancellationRequestV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralManagementCancellationRequestV06Document : IOuterDocument<CollateralManagementCancellationRequestV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.005.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralManagementCancellationRequestV06"/> is required.
    /// </summary>
    public required CollateralManagementCancellationRequestV06 Message { get; init; }
}
