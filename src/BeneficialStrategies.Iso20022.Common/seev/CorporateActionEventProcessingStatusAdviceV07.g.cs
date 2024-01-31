﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionEventProcessingStatusAdviceV07.  ISO2002 ID# _hptDkeXjEemEj48jhmlA0Q.
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
public partial record CorporateActionEventProcessingStatusAdviceV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnEvtPrcgStsAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_hptDmeXjEemEj48jhmlA0Q")]
    [Description(@"Identification of a previously sent notification document.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    public DocumentIdentification9? NotificationIdentification { get; init; }
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_hptDm-XjEemEj48jhmlA0Q")]
    [Description(@"Identification of other documents as well as the document number.")]
    [DataMember(Name="OthrDocId")]
    [XmlElement(ElementName="OthrDocId")]
    public DocumentIdentification33? OtherDocumentIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_hptDneXjEemEj48jhmlA0Q")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionGeneralInformation137 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information about the status of a corporate action.
    /// </summary>
    [IsoId("_hptDn-XjEemEj48jhmlA0Q")]
    [Description(@"Information about the status of a corporate action.")]
    [DataMember(Name="EvtPrcgSts")]
    [XmlElement(ElementName="EvtPrcgSts")]
    [Required]
    public required IEventProcessingStatus5Choice EventProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_hptDoeXjEemEj48jhmlA0Q")]
    [Description(@"Provides additional information.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionNarrative10? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_hptDo-XjEemEj48jhmlA0Q")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionEventProcessingStatusAdviceV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionEventProcessingStatusAdviceV07Document ToDocument()
    {
        return new CorporateActionEventProcessingStatusAdviceV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CorporateActionEventProcessingStatusAdviceV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionEventProcessingStatusAdviceV07Document : IOuterDocument<CorporateActionEventProcessingStatusAdviceV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.032.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionEventProcessingStatusAdviceV07"/> is required.
    /// </summary>
    public required CorporateActionEventProcessingStatusAdviceV07 Message { get; init; }
}
