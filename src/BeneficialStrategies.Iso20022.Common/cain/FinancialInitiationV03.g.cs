﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInitiationV03.  ISO2002 ID# _Sii_4YELEeu6D49Gi-ZPwQ.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The FinancialInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction or to inform about the completion of an authorisation. It allows the approved transaction amount to be billed or posted on the cardholder's account. It can also be sent by an issuer to an acquirer or agent to advise that an authorisation has been successfully completed for the final amount and requests the clearing of the transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction or to inform about the completion of an authorisation. It allows the approved transaction amount to be billed or posted on the cardholder's account. It can also be sent by an issuer to an acquirer or agent to advise that an authorisation has been successfully completed for the final amount and requests the clearing of the transaction.")]
public partial record FinancialInitiationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_Sii_44ELEeu6D49Gi-ZPwQ")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the financial initiation.
    /// </summary>
    [IsoId("_Sii_5YELEeu6D49Gi-ZPwQ")]
    [Description(@"Information related to the financial initiation.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required SomeBodyRecord Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_Sii_54ELEeu6D49Gi-ZPwQ")]
    [Description(@"Trailer of the message containing a MAC")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInitiationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInitiationV03Document ToDocument()
    {
        return new FinancialInitiationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInitiationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInitiationV03Document : IOuterDocument<FinancialInitiationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.003.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInitiationV03"/> is required.
    /// </summary>
    public required FinancialInitiationV03 Message { get; init; }
}
