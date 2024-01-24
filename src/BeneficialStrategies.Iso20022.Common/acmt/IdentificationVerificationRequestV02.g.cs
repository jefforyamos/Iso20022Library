﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IdentificationVerificationRequestV02.  ISO2002 ID# _sZX_5FkyEeGeoaLUQk__nA_-973563434.
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
public partial record IdentificationVerificationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdVrfctnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the identification assignment.
    /// </summary>
    [IsoId("_sZhw4FkyEeGeoaLUQk__nA_798485555")]
    [Description(@"Identifies the identification assignment.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Information concerning the identification data that is requested to be verified.
    /// </summary>
    [IsoId("_sZhw4VkyEeGeoaLUQk__nA_-198586798")]
    [Description(@"Information concerning the identification data that is requested to be verified.")]
    [DataMember(Name="Vrfctn")]
    [XmlElement(ElementName="Vrfctn")]
    [Required]
    public required SomeVerificationRecord Verification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sZhw4lkyEeGeoaLUQk__nA_-298368566")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IdentificationVerificationRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IdentificationVerificationRequestV02Document ToDocument()
    {
        return new IdentificationVerificationRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IdentificationVerificationRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IdentificationVerificationRequestV02Document : IOuterDocument<IdentificationVerificationRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IdentificationVerificationRequestV02"/> is required.
    /// </summary>
    public required IdentificationVerificationRequestV02 Message { get; init; }
}
