﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralValueReportV01.  ISO2002 ID# _5SjM_zooEemaN9GkhmGkfg.
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
/// This record is an implementation of the colr.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CollateralValueReport message is sent by the system transaction administrator to a system member (such as a directly connected party) to provide further information the current available value of securities for auto collateralisation for one specific or several cash accounts.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CollateralValueReport message is sent by the system transaction administrator to a system member (such as a directly connected party) to provide further information the current available value of securities for auto collateralisation for one specific or several cash accounts.")]
public partial record CollateralValueReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollValRpt";
    
    #nullable enable
    /// <summary>
    /// Set of elements to identify the collateral value report message.
    /// </summary>
    [IsoId("_5Sj0ATooEemaN9GkhmGkfg")]
    [Description(@"Set of elements to identify the collateral value report message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader3 MessageHeader { get; init; }
    
    /// <summary>
    /// Report on collateral value information or operational error.
    /// </summary>
    [IsoId("_5Sj0AzooEemaN9GkhmGkfg")]
    [Description(@"Report on collateral value information or operational error.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    [Required]
    public required ICollateralValueReportOrError5Choice ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5Sj0BTooEemaN9GkhmGkfg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralValueReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralValueReportV01Document ToDocument()
    {
        return new CollateralValueReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralValueReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CollateralValueReportV01Document : IOuterDocument<CollateralValueReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralValueReportV01"/> is required.
    /// </summary>
    public required CollateralValueReportV01 Message { get; init; }
}
