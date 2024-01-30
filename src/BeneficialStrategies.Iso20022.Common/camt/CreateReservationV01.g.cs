﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreateReservationV01.  ISO2002 ID# _P8tokckHEem3UrxZgQhVAw.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The CreateReservation message is used to create one particular reservation by the member and managed by the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateReservation message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CreateReservation message is used to create one particular reservation by the member and managed by the transaction administrator.|Usage|Based on the criteria defined in the CreateReservation message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
public partial record CreateReservationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretRsvatn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_P8tol8kHEem3UrxZgQhVAw")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader1 MessageHeader { get; init; }
    
    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_P8tomckHEem3UrxZgQhVAw")]
    [Description(@"Identification of the default reservation.")]
    [DataMember(Name="RsvatnId")]
    [XmlElement(ElementName="RsvatnId")]
    [Required]
    public required ReservationIdentification2 ReservationIdentification { get; init; }
    
    /// <summary>
    /// New reservation values.
    /// </summary>
    [IsoId("_P8tom8kHEem3UrxZgQhVAw")]
    [Description(@"New reservation values.")]
    [DataMember(Name="ValSet")]
    [XmlElement(ElementName="ValSet")]
    [Required]
    public required Reservation4 ValueSet { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8tonckHEem3UrxZgQhVAw")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreateReservationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreateReservationV01Document ToDocument()
    {
        return new CreateReservationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CreateReservationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreateReservationV01Document : IOuterDocument<CreateReservationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.103.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreateReservationV01"/> is required.
    /// </summary>
    public required CreateReservationV01 Message { get; init; }
}
