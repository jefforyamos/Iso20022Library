﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ModifyReservationV05.  ISO2002 ID# _jwlb0xbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope|The ModifyReservation message is used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator.|Usage|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.|If there is enough liquidity available, the requested amount will be reserved. In case the requested amount exceeds the available liquidity, only the available liquidity will be reserved. The difference will not be blocked at a later point, even if the account balance of the member reaches the level of the initial reservation request.|The reservation can be effected directly by the member, who has the possibility to: |- reset the reserved liquidity to zero|- change the reservation amount during the day with immediate effect|- input a default reservation amount for the following day(s); valid until a new reservation amount is requested|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ModifyReservation message is used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator.|Usage|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.|If there is enough liquidity available, the requested amount will be reserved. In case the requested amount exceeds the available liquidity, only the available liquidity will be reserved. The difference will not be blocked at a later point, even if the account balance of the member reaches the level of the initial reservation request.|The reservation can be effected directly by the member, who has the possibility to: |- reset the reserved liquidity to zero|- change the reservation amount during the day with immediate effect|- input a default reservation amount for the following day(s); valid until a new reservation amount is requested|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.")]
public partial record ModifyReservationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyRsvatn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb1RbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_jwlb1xbvEeiyVv5j1vf1VQ")]
    [Description(@"Identification of the default reservation.")]
    [DataMember(Name="RsvatnId")]
    [XmlElement(ElementName="RsvatnId")]
    [Required]
    public required SomeReservationIdentificationRecord ReservationIdentification { get; init; }
    
    /// <summary>
    /// New reservation values.
    /// </summary>
    [IsoId("_jwlb2RbvEeiyVv5j1vf1VQ")]
    [Description(@"New reservation values.")]
    [DataMember(Name="NewRsvatnValSet")]
    [XmlElement(ElementName="NewRsvatnValSet")]
    [Required]
    public required SomeNewReservationValueSetRecord NewReservationValueSet { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb2xbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ModifyReservationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ModifyReservationV05Document ToDocument()
    {
        return new ModifyReservationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ModifyReservationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ModifyReservationV05Document : IOuterDocument<ModifyReservationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.048.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ModifyReservationV05"/> is required.
    /// </summary>
    public required ModifyReservationV05 Message { get; init; }
}
