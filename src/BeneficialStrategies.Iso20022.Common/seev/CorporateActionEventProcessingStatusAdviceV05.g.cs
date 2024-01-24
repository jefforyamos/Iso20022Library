﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionEventProcessingStatusAdviceV05.  ISO2002 ID# _Rc5o1zm_EeWENZE2jGFgGw.
//
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
public partial record CorporateActionEventProcessingStatusAdviceV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnEvtPrcgStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionEventProcessingStatusAdviceV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionEventProcessingStatusAdviceV05Document ToDocument()
    {
        return new CorporateActionEventProcessingStatusAdviceV05Document { Message = this };
    }
}

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
/// This is the outer document that contains <seealso cref="CorporateActionEventProcessingStatusAdviceV05"/>.
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
