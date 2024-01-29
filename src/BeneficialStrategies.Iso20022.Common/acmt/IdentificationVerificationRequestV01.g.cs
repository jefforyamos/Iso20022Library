﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IdentificationVerificationRequestV01.  ISO2002 ID# _sRylWGtdEeCY4-KZ9JEyUQ_-1959332273.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The IdentificationVerificationRequest message is sent by an assigner to an assignee. It is used to request the verification of party and/or account identification information.
/// Usage
/// The IdentificationVerificationRequest message is sent before the sending of one or several transactions messages.
/// The IdentificationVerificationRequest message can contain one or more verification requests.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The IdentificationVerificationRequest message is sent by an assigner to an assignee. It is used to request the verification of party and/or account identification information.|Usage|The IdentificationVerificationRequest message is sent before the sending of one or several transactions messages.|The IdentificationVerificationRequest message can contain one or more verification requests.")]
public partial record IdentificationVerificationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdVrfctnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the identification assignment.
    /// </summary>
    [IsoId("_sRylWWtdEeCY4-KZ9JEyUQ_-1079532632")]
    [Description(@"Identifies the identification assignment.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Information concerning the identification data that is requested to be verified.
    /// </summary>
    [IsoId("_sRylWmtdEeCY4-KZ9JEyUQ_731202779")]
    [Description(@"Information concerning the identification data that is requested to be verified.")]
    [DataMember(Name="Vrfctn")]
    [XmlElement(ElementName="Vrfctn")]
    [Required]
    public required SomeVerificationRecord Verification { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IdentificationVerificationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IdentificationVerificationRequestV01Document ToDocument()
    {
        return new IdentificationVerificationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IdentificationVerificationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IdentificationVerificationRequestV01Document : IOuterDocument<IdentificationVerificationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IdentificationVerificationRequestV01"/> is required.
    /// </summary>
    public required IdentificationVerificationRequestV01 Message { get; init; }
}