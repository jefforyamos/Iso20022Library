﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TSEJASDECCorporateActionNotificationSubsetSD1V03.  ISO2002 ID# _HEsq4aKSEeOo48XfssNw8w.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.supl;


/// <summary>
/// This record is an implementation of the supl.012.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is an extension used by TSE/JASDEC and its community to provide supplementary data to the CorporateActionNotification 002, which is the restricted version that supports the coexistence of ISO messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This message is an extension used by TSE/JASDEC and its community to provide supplementary data to the CorporateActionNotification 002, which is the restricted version that supports the coexistence of ISO messages.")]
public partial record TSEJASDECCorporateActionNotificationSubsetSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.012.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TSEJASDECCorpActnNtfctnSubsetSD1";
    
    #nullable enable
    /// <summary>
    /// Extension to an identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_HEtR86KSEeOo48XfssNw8w")]
    [Description(@"Extension to an identification of a security by proprietary or domestic identification scheme.")]
    [DataMember(Name="OthrId")]
    [XmlElement(ElementName="OthrId")]
    public OtherIdentification2SD1? OtherIdentification { get; init; }
    
    /// <summary>
    /// Extension to provide additional information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_HEtR9aKSEeOo48XfssNw8w")]
    [Description(@"Extension to provide additional information about rates and amounts related to a corporate action option.")]
    [DataMember(Name="RateAndAmtDtls")]
    [XmlElement(ElementName="RateAndAmtDtls")]
    public DividendSD1? RateAndAmountDetails { get; init; }
    
    /// <summary>
    /// Extension to provide more information for the underlying security.
    /// </summary>
    [IsoId("_HEtR96KSEeOo48XfssNw8w")]
    [Description(@"Extension to provide more information for the underlying security.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributes23SD1? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Extension to provide information about the securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_HEtR-aKSEeOo48XfssNw8w")]
    [Description(@"Extension to provide information about the securities quantity linked to a corporate action.")]
    [DataMember(Name="SctiesQty")]
    [XmlElement(ElementName="SctiesQty")]
    public CorporateActionQuantity4SD2? SecuritiesQuantity { get; init; }
    
    /// <summary>
    /// Extension to specify additional information related to the type of dividend.
    /// </summary>
    [IsoId("_HEtR-6KSEeOo48XfssNw8w")]
    [Description(@"Extension to specify additional information related to the type of dividend.")]
    [DataMember(Name="DvddTp")]
    [XmlElement(ElementName="DvddTp")]
    public DividendTypeFormat4SD1? DividendType { get; init; }
    
    /// <summary>
    /// Extension to provide additional corporate action details information.
    /// </summary>
    [IsoId("_HEtR_aKSEeOo48XfssNw8w")]
    [Description(@"Extension to provide additional corporate action details information.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateAction6SD1? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Extension to provide information about the entity making the offer (when it is different from the issuing company).
    /// </summary>
    [IsoId("_HEtR_6KSEeOo48XfssNw8w")]
    [Description(@"Extension to provide information about the entity making the offer (when it is different from the issuing company).")]
    [DataMember(Name="Offerr")]
    [XmlElement(ElementName="Offerr")]
    public UpdatedAdditionalInformation6SD3? Offeror { get; init; }
    
    /// <summary>
    /// Extension to capture the new to old ratio with higher precision.
    /// </summary>
    [IsoId("_HEtSAaKSEeOo48XfssNw8w")]
    [Description(@"Extension to capture the new to old ratio with higher precision.")]
    [DataMember(Name="RateDtls")]
    [XmlElement(ElementName="RateDtls")]
    public CorporateActionRate19SD1? RateDetails { get; init; }
    
    /// <summary>
    /// Extension for the stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_HEtSA6KSEeOo48XfssNw8w")]
    [Description(@"Extension for the stage in the corporate action event life cycle.")]
    [DataMember(Name="EvtStag")]
    [XmlElement(ElementName="EvtStag")]
    public CorporateActionEventStageFormat4SD1? EventStage { get; init; }
    
    /// <summary>
    /// Extension for the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_HEtSBaKSEeOo48XfssNw8w")]
    [Description(@"Extension for the features that may apply to a corporate action option.")]
    [DataMember(Name="OptnFeatrs")]
    [XmlElement(ElementName="OptnFeatrs")]
    public OptionFeaturesFormat8SD1? OptionFeatures { get; init; }
    
    /// <summary>
    /// Extension to provide information on additional corporate action dates.
    /// </summary>
    [IsoId("_HEtSB6KSEeOo48XfssNw8w")]
    [Description(@"Extension to provide information on additional corporate action dates.")]
    [DataMember(Name="DtDtls")]
    [XmlElement(ElementName="DtDtls")]
    public CorporateActionDate21SD1? DateDetails { get; init; }
    
    /// <summary>
    /// Extension to provide breakdown details as used by custody banks for tax processing and asset valuation.
    /// </summary>
    [IsoId("_HEtSCaKSEeOo48XfssNw8w")]
    [Description(@"Extension to provide breakdown details as used by custody banks for tax processing and asset valuation.")]
    [DataMember(Name="GrssDvddRate")]
    [XmlElement(ElementName="GrssDvddRate")]
    public GrossDividendRateFormat6SD1? GrossDividendRate { get; init; }
    
    /// <summary>
    /// Extension to provide information about the dates related to securities movement.
    /// </summary>
    [IsoId("_HEtSC6KSEeOo48XfssNw8w")]
    [Description(@"Extension to provide information about the dates related to securities movement.")]
    [DataMember(Name="SctiesMvmntDtDtls")]
    [XmlElement(ElementName="SctiesMvmntDtDtls")]
    public SecurityDate8SD1? SecuritiesMovementDateDetails { get; init; }
    
    /// <summary>
    /// Extension to provide extra parameters of the securities of the counterparties in a merger or exchange offer.
    /// </summary>
    [IsoId("_HEtSDaKSEeOo48XfssNw8w")]
    [Description(@"Extension to provide extra parameters of the securities of the counterparties in a merger or exchange offer.")]
    [DataMember(Name="SctiesMvmntDtls")]
    [XmlElement(ElementName="SctiesMvmntDtls")]
    public SecuritiesOption22SD1? SecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Extension to provide the new name of a company following a name change.
    /// </summary>
    [IsoId("_HEtSD6KSEeOo48XfssNw8w")]
    [Description(@"Extension to provide the new name of a company following a name change.")]
    [DataMember(Name="NewCpnyNm")]
    [XmlElement(ElementName="NewCpnyNm")]
    public UpdatedAdditionalInformation6SD2? NewCompanyName { get; init; }
    
    /// <summary>
    /// Extension for the name of the Issuer Agent.
    /// </summary>
    [IsoId("_HEtSEaKSEeOo48XfssNw8w")]
    [Description(@"Extension for the name of the Issuer Agent.")]
    [DataMember(Name="IssrAgt")]
    [XmlElement(ElementName="IssrAgt")]
    public OrganisationIdentificationSD1? IssuerAgent { get; init; }
    
    /// <summary>
    /// Extension to provide additional taxation information related to the corporate action event.
    /// </summary>
    [IsoId("_HEtSE6KSEeOo48XfssNw8w")]
    [Description(@"Extension to provide additional taxation information related to the corporate action event.")]
    [DataMember(Name="TaxtnConds")]
    [XmlElement(ElementName="TaxtnConds")]
    public UpdatedAdditionalInformation5SD3? TaxationConditions { get; init; }
    
    /// <summary>
    /// Extension to provide additional narrative information in the local language.
    /// </summary>
    [IsoId("_HEtSFaKSEeOo48XfssNw8w")]
    [Description(@"Extension to provide additional narrative information in the local language.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative17SD1? AdditionalInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TSEJASDECCorporateActionNotificationSubsetSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TSEJASDECCorporateActionNotificationSubsetSD1V03Document ToDocument()
    {
        return new TSEJASDECCorporateActionNotificationSubsetSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TSEJASDECCorporateActionNotificationSubsetSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TSEJASDECCorporateActionNotificationSubsetSD1V03Document : IOuterDocument<TSEJASDECCorporateActionNotificationSubsetSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.012.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TSEJASDECCorporateActionNotificationSubsetSD1V03"/> is required.
    /// </summary>
    public required TSEJASDECCorporateActionNotificationSubsetSD1V03 Message { get; init; }
}
