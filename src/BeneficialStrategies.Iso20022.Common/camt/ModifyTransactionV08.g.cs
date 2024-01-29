﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ModifyTransactionV08.  ISO2002 ID# _jwlb6RbvEeiyVv5j1vf1VQ.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ModifyTransaction message is sent by a member to the transaction administrator.
/// It is used to request one modification in one payment instruction held at the transaction administrator and sent by the member, debiting or crediting its account at the transaction administrator.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).
/// Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// For this reason, at any time during the operating hours of the system, the member can request modifications to the features of transient transactions.
/// The member will submit a message requesting modifications in one or more of the following criteria:
/// - instruction given, related to the processing of the transaction
/// - type of payment instructed
/// - priority of payment period in which the payment instruction should be processed (processing validity time)
/// The ModifyTransaction message will contain the new values that the member wants to see applied to the features of the transaction identified in the message.
/// Based on the criteria received within the ModifyTransaction message, the transaction administrator will execute or reject the requested modifications.
/// The transaction administrator may send a Receipt message as a reply to the ModifyTransaction request.
/// To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ModifyTransaction message is sent by a member to the transaction administrator.|It is used to request one modification in one payment instruction held at the transaction administrator and sent by the member, debiting or crediting its account at the transaction administrator.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).|Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|For this reason, at any time during the operating hours of the system, the member can request modifications to the features of transient transactions.|The member will submit a message requesting modifications in one or more of the following criteria:|- instruction given, related to the processing of the transaction|- type of payment instructed|- priority of payment period in which the payment instruction should be processed (processing validity time)|The ModifyTransaction message will contain the new values that the member wants to see applied to the features of the transaction identified in the message.|Based on the criteria received within the ModifyTransaction message, the transaction administrator will execute or reject the requested modifications.|The transaction administrator may send a Receipt message as a reply to the ModifyTransaction request.|To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.")]
public partial record ModifyTransactionV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyTx";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb6xbvEeiyVv5j1vf1VQ")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Identifies the list of modifications to be executed.
    /// </summary>
    [IsoId("_jwlb7RbvEeiyVv5j1vf1VQ")]
    [Description(@"Identifies the list of modifications to be executed.")]
    [DataMember(Name="Mod")]
    [XmlElement(ElementName="Mod")]
    [Required]
    public required SomeModificationRecord Modification { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb7xbvEeiyVv5j1vf1VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ModifyTransactionV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ModifyTransactionV08Document ToDocument()
    {
        return new ModifyTransactionV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ModifyTransactionV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ModifyTransactionV08Document : IOuterDocument<ModifyTransactionV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.007.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ModifyTransactionV08"/> is required.
    /// </summary>
    public required ModifyTransactionV08 Message { get; init; }
}