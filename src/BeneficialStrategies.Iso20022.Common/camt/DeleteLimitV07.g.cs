﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DeleteLimitV07.  ISO2002 ID# _jwlbTxbvEeiyVv5j1vf1VQ.
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
/// This record is an implementation of the camt.012.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DeleteLimit message is sent by a member to the transaction administrator.
/// It is used to request the deletion of one particular, several or all limits set by the member and managed by the transaction administrator.
/// The DeleteLimit message may delete several types of current limits (risk or liquidity management limit), based on a multiple requests.
/// Usage
/// The member will submit a DeleteLimit message identifying which limit(s) it wants to delete (current limit risk/liquidity limit concepts have been merged) based on following criteria:
/// - type of limit(s) (current/default)
/// - value of the limit(s) (default and/or current limit(s))
/// - identification of the counterparty (bilateral limit)
/// Based on the criteria received within the DeleteLimit message, the transaction administrator will execute or reject the requested modifications.
/// The transaction administrator may send a Receipt message as a reply to the DeleteLimit request.
/// To verify the outcome of the request, the member may submit a GetLimit message with the appropriate search criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The DeleteLimit message is sent by a member to the transaction administrator.|It is used to request the deletion of one particular, several or all limits set by the member and managed by the transaction administrator.|The DeleteLimit message may delete several types of current limits (risk or liquidity management limit), based on a multiple requests.|Usage|The member will submit a DeleteLimit message identifying which limit(s) it wants to delete (current limit risk/liquidity limit concepts have been merged) based on following criteria:|- type of limit(s) (current/default)|- value of the limit(s) (default and/or current limit(s))|- identification of the counterparty (bilateral limit)|Based on the criteria received within the DeleteLimit message, the transaction administrator will execute or reject the requested modifications.|The transaction administrator may send a Receipt message as a reply to the DeleteLimit request.|To verify the outcome of the request, the member may submit a GetLimit message with the appropriate search criteria.")]
public partial record DeleteLimitV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.012.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DelLmt";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbURbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader1 MessageHeader { get; init; }
    
    /// <summary>
    /// Identifies one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [IsoId("_jwlbUxbvEeiyVv5j1vf1VQ")]
    [Description(@"Identifies one particular limit set by the member and managed by the transaction administrator.")]
    [DataMember(Name="LmtDtls")]
    [XmlElement(ElementName="LmtDtls")]
    [Required]
    public required LimitStructure2Choice_ LimitDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbVRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DeleteLimitV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DeleteLimitV07Document ToDocument()
    {
        return new DeleteLimitV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DeleteLimitV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DeleteLimitV07Document : IOuterDocument<DeleteLimitV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.012.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DeleteLimitV07"/> is required.
    /// </summary>
    public required DeleteLimitV07 Message { get; init; }
}
