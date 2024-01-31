﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NetReportV02.  ISO2002 ID# _kBNA9QM-Ee2nqoJcXIhTdw.
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
/// This record is an implementation of the camt.088.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.")]
public partial record NetReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.088.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetRpt";
    
    #nullable enable
    /// <summary>
    /// Specifies the meta data associated with the net report.
    /// </summary>
    [IsoId("_kBNA-QM-Ee2nqoJcXIhTdw")]
    [Description(@"Specifies the meta data associated with the net report.")]
    [DataMember(Name="NetRptData")]
    [XmlElement(ElementName="NetRptData")]
    [Required]
    public required NetReportData2 NetReportData { get; init; }
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_kBNA-wM-Ee2nqoJcXIhTdw")]
    [Description(@"Describes the participant receiving the net report.")]
    [DataMember(Name="NetSvcPtcptId")]
    [XmlElement(ElementName="NetSvcPtcptId")]
    [Required]
    public required IPartyIdentification242Choice NetServiceParticipantIdentification { get; init; }
    
    /// <summary>
    /// Describes the counterparty participant involved in (all of) the obligations of the report.
    /// </summary>
    [IsoId("_kBNA_QM-Ee2nqoJcXIhTdw")]
    [Description(@"Describes the counterparty participant involved in (all of) the obligations of the report.")]
    [DataMember(Name="NetSvcCtrPtyId")]
    [XmlElement(ElementName="NetSvcCtrPtyId")]
    public IPartyIdentification242Choice? NetServiceCounterpartyIdentification { get; init; }
    
    /// <summary>
    /// Provides the amount, direct parties or netting groups involved in the obligation.
    /// </summary>
    [IsoId("_kBNA_wM-Ee2nqoJcXIhTdw")]
    [Description(@"Provides the amount, direct parties or netting groups involved in the obligation.")]
    [DataMember(Name="NetOblgtn")]
    [XmlElement(ElementName="NetOblgtn")]
    [Required]
    public required NetObligation2 NetObligation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kBNBAQM-Ee2nqoJcXIhTdw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NetReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NetReportV02Document ToDocument()
    {
        return new NetReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NetReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record NetReportV02Document : IOuterDocument<NetReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.088.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NetReportV02"/> is required.
    /// </summary>
    public required NetReportV02 Message { get; init; }
}
