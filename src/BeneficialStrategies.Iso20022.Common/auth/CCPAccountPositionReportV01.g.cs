﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPAccountPositionReportV01.  ISO2002 ID# _1-TtoeUREem3X-64-NKdqg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.068.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPAccountPositionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the positions of the clearing members of the central counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPAccountPositionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the positions of the clearing members of the central counterparty.")]
public partial record CCPAccountPositionReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.068.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPAcctPosRpt";
    
    #nullable enable
    /// <summary>
    /// Position accounts of a central counterparty containing a portfolio of financial instruments.
    /// </summary>
    [IsoId("_1-TtqeUREem3X-64-NKdqg")]
    [Description(@"Position accounts of a central counterparty containing a portfolio of financial instruments.")]
    [DataMember(Name="Prtfl")]
    [XmlElement(ElementName="Prtfl")]
    [Required]
    public required PositionAccount2 Portfolio { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1-Ttq-UREem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPAccountPositionReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPAccountPositionReportV01Document ToDocument()
    {
        return new CCPAccountPositionReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPAccountPositionReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPAccountPositionReportV01Document : IOuterDocument<CCPAccountPositionReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.068.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPAccountPositionReportV01"/> is required.
    /// </summary>
    public required CCPAccountPositionReportV01 Message { get; init; }
}
