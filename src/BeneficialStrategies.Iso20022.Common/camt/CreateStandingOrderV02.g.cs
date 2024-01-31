﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreateStandingOrderV02.  ISO2002 ID# _ThMwvdb6Eeq_l4BJLVUF2Q.
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
/// This record is an implementation of the camt.102.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateStandingOrder message is sent by a member to the transaction administrator.
/// It is used to create a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateStandingOrder message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CreateStandingOrder message is sent by a member to the transaction administrator.|It is used to create a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.|Usage|Based on the criteria defined in the CreateStandingOrder message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
public partial record CreateStandingOrderV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.102.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretStgOrdr";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThMww9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader1 MessageHeader { get; init; }
    
    /// <summary>
    /// Identifies the standing order.
    /// </summary>
    [IsoId("_ThMwxdb6Eeq_l4BJLVUF2Q")]
    [Description(@"Identifies the standing order.")]
    [DataMember(Name="StgOrdrId")]
    [XmlElement(ElementName="StgOrdrId")]
    [Required]
    public required StandingOrderIdentification6 StandingOrderIdentification { get; init; }
    
    /// <summary>
    /// Set of values for the standing order.
    /// </summary>
    [IsoId("_ThMwx9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Set of values for the standing order.")]
    [DataMember(Name="ValSet")]
    [XmlElement(ElementName="ValSet")]
    [Required]
    public required StandingOrder8 ValueSet { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThMwydb6Eeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreateStandingOrderV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreateStandingOrderV02Document ToDocument()
    {
        return new CreateStandingOrderV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CreateStandingOrderV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreateStandingOrderV02Document : IOuterDocument<CreateStandingOrderV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.102.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreateStandingOrderV02"/> is required.
    /// </summary>
    public required CreateStandingOrderV02 Message { get; init; }
}
