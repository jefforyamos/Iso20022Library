﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionNarrativeV05.  ISO2002 ID# _BBQdl7T-EeiTob_PrFFUxA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// Scope
/// The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for tax reclaims, restrictions, documentation requirements. This message is bi-directional.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for tax reclaims, restrictions, documentation requirements. This message is bi-directional.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionNarrativeV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNrrtv";
    
    #nullable enable
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_BBQdmbT-EeiTob_PrFFUxA")]
    [Description(@"General information about the safekeeping account and the account owner.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    public IAccountIdentification42Choice? AccountDetails { get; init; }
    
    /// <summary>
    /// Provides information about the securitised right for entitlement.
    /// </summary>
    [IsoId("_BBQdm7T-EeiTob_PrFFUxA")]
    [Description(@"Provides information about the securitised right for entitlement.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public SecurityIdentification19? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_BBQdnbT-EeiTob_PrFFUxA")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation92 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_BBQdn7T-EeiTob_PrFFUxA")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    [Required]
    public required UpdatedAdditionalInformation8 AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BBQdobT-EeiTob_PrFFUxA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionNarrativeV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionNarrativeV05Document ToDocument()
    {
        return new CorporateActionNarrativeV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionNarrativeV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionNarrativeV05Document : IOuterDocument<CorporateActionNarrativeV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.038.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionNarrativeV05"/> is required.
    /// </summary>
    public required CorporateActionNarrativeV05 Message { get; init; }
}
