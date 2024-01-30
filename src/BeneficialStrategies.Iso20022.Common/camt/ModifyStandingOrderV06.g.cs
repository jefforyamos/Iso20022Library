﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ModifyStandingOrderV06.  ISO2002 ID# _jwlb3RbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ModifyStandingOrder message is sent by a member to the transaction administrator.
/// It is used to request a change in the features of a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.
/// Usage
/// There should be one standing order per (direct) member and per business day. The ModifyStandingOrder message must not be used to request a transfer of funds between accounts during the working day. The liquidity transfer messages must be used for this purpose. There is no need to have a standing order to empty the settlement account at the end of the day and transfer the funds to the current account. For liquidity savings purposes, systems will effect the necessary transfers automatically when and where relevant.
/// The ModifyStandingOrder message first identifies the standing order to be modified and then provide the details of the new standing order. The elements that can be modified are:
/// - amount
/// - account to be credited
/// - account to be debited
/// - account owner (for on behalf scenario)
/// - frequency of payment
/// - daytime or overnight processing
/// - dates when the standing order begins and ceases to be effective
/// Based on the criteria received within the ModifyStandingOrder message, the transaction administrator will execute or reject the requested modifications.
/// The transaction administrator may send a Receipt message as a reply to the Modify Standing Order request. To verify the outcome of the request, the member may submit a GetStandingOrder message with the appropriate search criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ModifyStandingOrder message is sent by a member to the transaction administrator.|It is used to request a change in the features of a permanent order for the transfer of funds between two accounts belonging to the same member and being held at the transaction administrator.|Usage|There should be one standing order per (direct) member and per business day. The ModifyStandingOrder message must not be used to request a transfer of funds between accounts during the working day. The liquidity transfer messages must be used for this purpose. There is no need to have a standing order to empty the settlement account at the end of the day and transfer the funds to the current account. For liquidity savings purposes, systems will effect the necessary transfers automatically when and where relevant.|The ModifyStandingOrder message first identifies the standing order to be modified and then provide the details of the new standing order. The elements that can be modified are:|- amount|- account to be credited|- account to be debited|- account owner (for on behalf scenario)|- frequency of payment|- daytime or overnight processing|- dates when the standing order begins and ceases to be effective|Based on the criteria received within the ModifyStandingOrder message, the transaction administrator will execute or reject the requested modifications.|The transaction administrator may send a Receipt message as a reply to the Modify Standing Order request. To verify the outcome of the request, the member may submit a GetStandingOrder message with the appropriate search criteria.")]
public partial record ModifyStandingOrderV06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyStgOrdr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb4RbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader1 MessageHeader { get; init; }
    
    /// <summary>
    /// Identifies the standing order.
    /// </summary>
    [IsoId("_jwlb4xbvEeiyVv5j1vf1VQ")]
    [Description(@"Identifies the standing order.")]
    [DataMember(Name="StgOrdrId")]
    [XmlElement(ElementName="StgOrdrId")]
    [Required]
    public required StandingOrderIdentification4 StandingOrderIdentification { get; init; }
    
    /// <summary>
    /// New set of values for the standing order.
    /// </summary>
    [IsoId("_jwlb5RbvEeiyVv5j1vf1VQ")]
    [Description(@"New set of values for the standing order.")]
    [DataMember(Name="NewStgOrdrValSet")]
    [XmlElement(ElementName="NewStgOrdrValSet")]
    [Required]
    public required StandingOrder7 NewStandingOrderValueSet { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb5xbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ModifyStandingOrderV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ModifyStandingOrderV06Document ToDocument()
    {
        return new ModifyStandingOrderV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ModifyStandingOrderV06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ModifyStandingOrderV06Document : IOuterDocument<ModifyStandingOrderV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.024.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ModifyStandingOrderV06"/> is required.
    /// </summary>
    public required ModifyStandingOrderV06 Message { get; init; }
}
