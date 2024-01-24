﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CorporateActionNarrativeV07.  ISO2002 ID# _yg7BdxbHEeyroI8qKgB7Mg.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for such processes that cannot be handled using messages such as the CorporateActionNotification. It is not to be used for event narrative as that should be included in the CorporateActionNotification. Examples of when the CorporateActionNarrative message may be used include tax reclaims, restrictions, documentation requirements. This message should only be used when bilaterally agreed. This message is bi-directional.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for such processes that cannot be handled using messages such as the CorporateActionNotification. It is not to be used for event narrative as that should be included in the CorporateActionNotification. Examples of when the CorporateActionNarrative message may be used include tax reclaims, restrictions, documentation requirements. This message should only be used when bilaterally agreed. This message is bi-directional.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
public partial record CorporateActionNarrativeV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNrrtv";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CorporateActionNarrativeV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CorporateActionNarrativeV07Document ToDocument()
    {
        return new CorporateActionNarrativeV07Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The CorporateActionNarrative message is sent between an account servicer and an account owner or its designated agent to cater for such processes that cannot be handled using messages such as the CorporateActionNotification. It is not to be used for event narrative as that should be included in the CorporateActionNotification. Examples of when the CorporateActionNarrative message may be used include tax reclaims, restrictions, documentation requirements. This message should only be used when bilaterally agreed. This message is bi-directional.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// This is the outer document that contains <seealso cref="CorporateActionNarrativeV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CorporateActionNarrativeV07Document : IOuterDocument<CorporateActionNarrativeV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.038.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CorporateActionNarrativeV07"/> is required.
    /// </summary>
    public required CorporateActionNarrativeV07 Message { get; init; }
}
