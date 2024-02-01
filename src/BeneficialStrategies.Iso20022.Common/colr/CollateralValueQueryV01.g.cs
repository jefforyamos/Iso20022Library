﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralValueQueryV01.  ISO2002 ID# _5SjM8TooEemaN9GkhmGkfg.
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
/// This record is an implementation of the colr.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CollateralValueQuery message is sent by a system member (such as a directly connected party) to the system transaction administrator to query the current available value of securities for auto collateralisation for one specific or several cash accounts.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CollateralValueQuery message is sent by a system member (such as a directly connected party) to the system transaction administrator to query the current available value of securities for auto collateralisation for one specific or several cash accounts.")]
public partial record CollateralValueQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollValQry";
    
    #nullable enable
    /// <summary>
    /// Set of elements to identify the collateral value query message.
    /// </summary>
    [IsoId("_5SjM-TooEemaN9GkhmGkfg")]
    [Description(@"Set of elements to identify the collateral value query message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader3 MessageHeader { get; init; }
    
    /// <summary>
    /// Definition of the collateral query.
    /// </summary>
    [IsoId("_5SjM-zooEemaN9GkhmGkfg")]
    [Description(@"Definition of the collateral query.")]
    [DataMember(Name="CollValQryDef")]
    [XmlElement(ElementName="CollValQryDef")]
    public CollateralValueCriteriaDefinition3Choice_? CollateralValueQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5SjM_TooEemaN9GkhmGkfg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralValueQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralValueQueryV01Document ToDocument()
    {
        return new CollateralValueQueryV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralValueQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralValueQueryV01Document : IOuterDocument<CollateralValueQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralValueQueryV01"/> is required.
    /// </summary>
    public required CollateralValueQueryV01 Message { get; init; }
}
