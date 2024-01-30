﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DefaultFundContributionReportV02.  ISO2002 ID# _-hesiaMOEeCojJW5vEuTEQ_-1558125935.
//
namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// Scope
/// The DefaultFundContributionReport message is sent by the central counterparty (CCP) to a Clearing member to report on the calculation of the default fund contribution and the potential net excess or deficit.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// CCPs require participants to post assets in a clearing fund that can be used in the event of a default by a participant, to compensate non-defaulting participants for losses they suffer due to this default. The CCP evaluates each participant risk level based on their positions (monthly or daily) and calculate the excess of deficit of the default fund contribution. The DefaultFundContributionReport is usually sent on a monthly basis.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The DefaultFundContributionReport message is sent by the central counterparty (CCP) to a Clearing member to report on the calculation of the default fund contribution and the potential net excess or deficit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|CCPs require participants to post assets in a clearing fund that can be used in the event of a default by a participant, to compensate non-defaulting participants for losses they suffer due to this default. The CCP evaluates each participant risk level based on their positions (monthly or daily) and calculate the excess of deficit of the default fund contribution. The DefaultFundContributionReport is usually sent on a monthly basis.")]
public partial record DefaultFundContributionReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DfltFndCntrbtnRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides details about the report such as the report identification, the calculation date, the value date.
    /// </summary>
    [IsoId("_-hesiqMOEeCojJW5vEuTEQ_-2028070464")]
    [Description(@"Provides details about the report such as the report identification, the calculation date, the value date.")]
    [DataMember(Name="RptParams")]
    [XmlElement(ElementName="RptParams")]
    [Required]
    public required ReportParameters2 ReportParameters { get; init; }
    
    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_-hesi6MOEeCojJW5vEuTEQ_2103498306")]
    [Description(@"Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).")]
    [DataMember(Name="ClrMmb")]
    [XmlElement(ElementName="ClrMmb")]
    [Required]
    public required IPartyIdentification35Choice ClearingMember { get; init; }
    
    /// <summary>
    /// Provides details on the default fund report.
    /// </summary>
    [IsoId("_-hodgKMOEeCojJW5vEuTEQ_-78589152")]
    [Description(@"Provides details on the default fund report.")]
    [DataMember(Name="RptDtls")]
    [XmlElement(ElementName="RptDtls")]
    [Required]
    public required DefaultFundReport1 ReportDetails { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-hodgaMOEeCojJW5vEuTEQ_-1828123252")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DefaultFundContributionReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DefaultFundContributionReportV02Document ToDocument()
    {
        return new DefaultFundContributionReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DefaultFundContributionReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DefaultFundContributionReportV02Document : IOuterDocument<DefaultFundContributionReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DefaultFundContributionReportV02"/> is required.
    /// </summary>
    public required DefaultFundContributionReportV02 Message { get; init; }
}
