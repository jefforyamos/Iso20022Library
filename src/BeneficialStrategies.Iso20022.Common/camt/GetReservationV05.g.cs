﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetReservationV05.  ISO2002 ID# _jwlblxbvEeiyVv5j1vf1VQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// Scope
/// The GetReservation message is sent by a member to the transaction administrator.
/// It is used to request information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.
/// Usage
/// The member can request reservations information based on the following elements:
/// - identification of the system;
/// - identification of the account;
/// - status of the reservation (default and/or current);
/// - type of reservation.
/// This message will be replied to by a ReturnReservation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The GetReservation message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.|Usage|The member can request reservations information based on the following elements:|- identification of the system;|- identification of the account;|- status of the reservation (default and/or current);|- type of reservation.|This message will be replied to by a ReturnReservation message.")]
public partial record GetReservationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetRsvatn";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbmRbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader9 MessageHeader { get; init; }
    
    /// <summary>
    /// Definition of the reservation query.
    /// </summary>
    [IsoId("_jwlbmxbvEeiyVv5j1vf1VQ")]
    [Description(@"Definition of the reservation query.")]
    [DataMember(Name="RsvatnQryDef")]
    [XmlElement(ElementName="RsvatnQryDef")]
    public ReservationQuery3? ReservationQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbnRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetReservationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetReservationV05Document ToDocument()
    {
        return new GetReservationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="GetReservationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record GetReservationV05Document : IOuterDocument<GetReservationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.046.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetReservationV05"/> is required.
    /// </summary>
    public required GetReservationV05 Message { get; init; }
}
