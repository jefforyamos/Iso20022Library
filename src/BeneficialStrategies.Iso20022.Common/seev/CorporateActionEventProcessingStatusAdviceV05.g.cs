﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionEventProcessingStatusAdviceV05.  ISO2002 ID# _Rc5o1zm_EeWENZE2jGFgGw.
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
/// This record is an implementation of the seev.032.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionEventProcessingStatusAdvice message to an account owner or its designated agent to report processing status of a corporate action event.|
/// The account servicer uses this message to provide a reason as to why a corporate action event has not been completed by the announced payment dates.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), 
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer sends the CorporateActionEventProcessingStatusAdvice message to an account owner or its designated agent to report processing status of a corporate action event.||The account servicer uses this message to provide a reason as to why a corporate action event has not been completed by the announced payment dates.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), |using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionEventProcessingStatusAdviceV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.032.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnEvtPrcgStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_Rc5o3Tm_EeWENZE2jGFgGw")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    public DocumentIdentification9? NotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_Rc5o3zm_EeWENZE2jGFgGw")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification33? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_Rc5o4Tm_EeWENZE2jGFgGw")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation91 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information about the status of a corporate action.
    /// </summary>
    [IsoId("_Rc5o4zm_EeWENZE2jGFgGw")]
    [Description(@"Information about the status of a corporate action.")]
    [DataMember(Name="EvtPrcgSts")]
    [XmlElement(ElementName="EvtPrcgSts")]
    [Required]
    public required IEventProcessingStatus3Choice EventProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_Rc5o5Tm_EeWENZE2jGFgGw")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative10? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Rc5o5zm_EeWENZE2jGFgGw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionEventProcessingStatusAdviceV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionEventProcessingStatusAdviceV05Document ToDocument()
    {
        return new CorporateActionEventProcessingStatusAdviceV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionEventProcessingStatusAdviceV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionEventProcessingStatusAdviceV05Document : IOuterDocument<CorporateActionEventProcessingStatusAdviceV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.032.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionEventProcessingStatusAdviceV05"/> is required.
    /// </summary>
    public required CorporateActionEventProcessingStatusAdviceV05 Message { get; init; }
}
