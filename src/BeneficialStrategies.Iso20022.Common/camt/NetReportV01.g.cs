﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NetReportV01.  ISO2002 ID# _2YFYQJUlEeaYkf5FCqYMeA.
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
/// This record is an implementation of the camt.088.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.")]
public partial record NetReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.088.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetRpt";
    
    #nullable enable
    /// <summary>
    /// Specifies the meta data associated with the net report.
    /// </summary>
    [IsoId("_bs5gUJUrEeaYkf5FCqYMeA")]
    [Description(@"Specifies the meta data associated with the net report.")]
    [DataMember(Name="NetRptData")]
    [XmlElement(ElementName="NetRptData")]
    [Required]
    public required NetReportData1 NetReportData { get; init; }
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_TX-x4JUtEeaYkf5FCqYMeA")]
    [Description(@"Describes the participant receiving the net report.")]
    [DataMember(Name="NetSvcPtcptId")]
    [XmlElement(ElementName="NetSvcPtcptId")]
    [Required]
    public required PartyIdentification73Choice_ NetServiceParticipantIdentification { get; init; }
    
    /// <summary>
    /// Describes the counterparty participant involved in (all of) the obligations of the report.
    /// </summary>
    [IsoId("_98aukJU0EeaYkf5FCqYMeA")]
    [Description(@"Describes the counterparty participant involved in (all of) the obligations of the report.")]
    [DataMember(Name="NetSvcCtrPtyId")]
    [XmlElement(ElementName="NetSvcCtrPtyId")]
    public PartyIdentification73Choice_? NetServiceCounterpartyIdentification { get; init; }
    
    /// <summary>
    /// Provides the amount, direct parties or netting groups involved in the obligation.
    /// </summary>
    [IsoId("_0OAIgJU0EeaYkf5FCqYMeA")]
    [Description(@"Provides the amount, direct parties or netting groups involved in the obligation.")]
    [DataMember(Name="NetOblgtn")]
    [XmlElement(ElementName="NetOblgtn")]
    [Required]
    public required NetObligation1 NetObligation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RA5FEJU1EeaYkf5FCqYMeA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NetReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NetReportV01Document ToDocument()
    {
        return new NetReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NetReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NetReportV01Document : IOuterDocument<NetReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.088.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NetReportV01"/> is required.
    /// </summary>
    public required NetReportV01 Message { get; init; }
}
