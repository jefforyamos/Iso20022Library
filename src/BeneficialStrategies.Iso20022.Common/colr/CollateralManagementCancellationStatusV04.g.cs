﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralManagementCancellationStatusV04.  ISO2002 ID# _cjxa8YFrEeWtPe6Crjmeug.
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
/// This record is an implementation of the colr.006.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralManagementCancellationStatus message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager.
/// This message is used to provide the status of accepted or rejected for the CollateralManagementCancellationRequest message previously received.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The CollateralManagementCancellationStatus message can be sent to provide a status for a previously received CollateralManagementCancellationRequest message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CollateralManagementCancellationStatus message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager.|This message is used to provide the status of accepted or rejected for the CollateralManagementCancellationRequest message previously received.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralManagementCancellationStatus message can be sent to provide a status for a previously received CollateralManagementCancellationRequest message.")]
public partial record CollateralManagementCancellationStatusV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.006.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollMgmtCxlSts";
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_cjxa84FrEeWtPe6Crjmeug")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoMax35Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides reference to the previous received message.
    /// </summary>
    [IsoId("_cjxa9YFrEeWtPe6Crjmeug")]
    [Description(@"Provides reference to the previous received message.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    [Required]
    public required Reference16 Reference { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_cjxa94FrEeWtPe6Crjmeug")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation4 Obligation { get; init; }
    
    /// <summary>
    /// Provides status details of the collateral cancellation message.
    /// </summary>
    [IsoId("_cjxa-YFrEeWtPe6Crjmeug")]
    [Description(@"Provides status details of the collateral cancellation message.")]
    [DataMember(Name="CxlSts")]
    [XmlElement(ElementName="CxlSts")]
    [Required]
    public required CollateralCancellationStatus1 CancellationStatus { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_cjxa-4FrEeWtPe6Crjmeug")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralManagementCancellationStatusV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralManagementCancellationStatusV04Document ToDocument()
    {
        return new CollateralManagementCancellationStatusV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralManagementCancellationStatusV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralManagementCancellationStatusV04Document : IOuterDocument<CollateralManagementCancellationStatusV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.006.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralManagementCancellationStatusV04"/> is required.
    /// </summary>
    public required CollateralManagementCancellationStatusV04 Message { get; init; }
}
