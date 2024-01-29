﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountAdditionalInformationRequestV01.  ISO2002 ID# _mso-iNE9Ed-BzquC8wXy7w_-37995631.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// Scope
/// The AccountAdditionalInformationRequest message is sent from a financial institution to an organisation as part of maintenance process. This message is sent in response to a request message from the organisation, if the business content is valid, but additional information is required.
/// Usage
/// This message should only be sent if additional information is required as part of the account maintenance process.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AccountAdditionalInformationRequest message is sent from a financial institution to an organisation as part of maintenance process. This message is sent in response to a request message from the organisation, if the business content is valid, but additional information is required.|Usage|This message should only be sent if additional information is required as part of the account maintenance process.")]
public partial record AccountAdditionalInformationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctAddtlInfReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_mso-idE9Ed-BzquC8wXy7w_1354481909")]
    [Description(@"Set of elements for the identification of the message and related references.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required SomeReferencesRecord References { get; init; }
    
    /// <summary>
    /// Identifier for an organisation.
    /// </summary>
    [IsoId("_msyIcNE9Ed-BzquC8wXy7w_844276535")]
    [Description(@"Identifier for an organisation.")]
    [DataMember(Name="OrgId")]
    [XmlElement(ElementName="OrgId")]
    [Required]
    public required SomeOrganisationIdentificationRecord OrganisationIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_msyIcdE9Ed-BzquC8wXy7w_-1890306852")]
    [Description(@"Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.")]
    [DataMember(Name="AcctSvcrId")]
    [XmlElement(ElementName="AcctSvcrId")]
    [Required]
    public required SomeAccountServicerIdentificationRecord AccountServicerIdentification { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_msyIctE9Ed-BzquC8wXy7w_-672125053")]
    [Description(@"Unique and unambiguous identification of the account between the account owner and the account servicer.")]
    [DataMember(Name="AcctId")]
    [XmlElement(ElementName="AcctId")]
    [Required]
    public required SomeAccountIdentificationRecord AccountIdentification { get; init; }
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_msyIc9E9Ed-BzquC8wXy7w_-516297795")]
    [Description(@"Contains the signature with its components, namely signed info, signature value, key info and the object.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public SomeDigitalSignatureRecord? DigitalSignature { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountAdditionalInformationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountAdditionalInformationRequestV01Document ToDocument()
    {
        return new AccountAdditionalInformationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountAdditionalInformationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountAdditionalInformationRequestV01Document : IOuterDocument<AccountAdditionalInformationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountAdditionalInformationRequestV01"/> is required.
    /// </summary>
    public required AccountAdditionalInformationRequestV01 Message { get; init; }
}