﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetBusinessDayInformationV05.  ISO2002 ID# _jwlbbxbvEeiyVv5j1vf1VQ.
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
/// The GetBusinessDayInformation message is sent by a member to the transaction administrator.
/// It is used to request information on different types of administrative data linked to the system.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, not related to the transactions created in the system. The type of business day information available can vary depending on the system.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data of the system.
/// The member can request information based on the following elements:
/// - identification of the system
/// - currency within the system concerned
/// - status of the system
/// - period of availability of a given currency linked to the system concerned (in case the system handles more than one currency)
/// - closure information (dates when the system will be inactive and reasons for this inactivity)
/// - event indicator (types of event and precise timing of their occurrence within the system concerned)
/// This message will be replied to by a ReturnBusinessDayInformation message. Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The GetBusinessDayInformation message is sent by a member to the transaction administrator.|It is used to request information on different types of administrative data linked to the system.|Usage|The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, not related to the transactions created in the system. The type of business day information available can vary depending on the system.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data of the system.|The member can request information based on the following elements:|- identification of the system|- currency within the system concerned|- status of the system|- period of availability of a given currency linked to the system concerned (in case the system handles more than one currency)|- closure information (dates when the system will be inactive and reasons for this inactivity)|- event indicator (types of event and precise timing of their occurrence within the system concerned)|This message will be replied to by a ReturnBusinessDayInformation message. Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
public partial record GetBusinessDayInformationV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetBizDayInf";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbcRbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader9 MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the business day information query criteria.
    /// </summary>
    [IsoId("_jwlbcxbvEeiyVv5j1vf1VQ")]
    [Description(@"Defines the business day information query criteria.")]
    [DataMember(Name="BizDayInfQryDef")]
    [XmlElement(ElementName="BizDayInfQryDef")]
    public BusinessDayQuery2? BusinessDayInformationQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbdRbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetBusinessDayInformationV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetBusinessDayInformationV05Document ToDocument()
    {
        return new GetBusinessDayInformationV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="GetBusinessDayInformationV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record GetBusinessDayInformationV05Document : IOuterDocument<GetBusinessDayInformationV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.018.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetBusinessDayInformationV05"/> is required.
    /// </summary>
    public required GetBusinessDayInformationV05 Message { get; init; }
}
