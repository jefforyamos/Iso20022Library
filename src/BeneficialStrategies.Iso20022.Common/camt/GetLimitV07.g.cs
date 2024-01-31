﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetLimitV07.  ISO2002 ID# _jwlbhxbvEeiyVv5j1vf1VQ.
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
/// The GetLimit message is used to request information on the details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The GetLimit message is used to request information on the details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator.")]
public partial record GetLimitV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetLmt";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbiRbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader9 MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the limit query criteria.
    /// </summary>
    [IsoId("_jwlbixbvEeiyVv5j1vf1VQ")]
    [Description(@"Defines the limit query criteria.")]
    [DataMember(Name="LmtQryDef")]
    [XmlElement(ElementName="LmtQryDef")]
    public LimitQuery4? LimitQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbjRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetLimitV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetLimitV07Document ToDocument()
    {
        return new GetLimitV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="GetLimitV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record GetLimitV07Document : IOuterDocument<GetLimitV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.009.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetLimitV07"/> is required.
    /// </summary>
    public required GetLimitV07 Message { get; init; }
}
