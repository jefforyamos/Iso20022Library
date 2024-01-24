﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementModificationQueryV01.  ISO2002 ID# _DLtKyzncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The IntraBalanceMovementModificationQuery message is sent from an account owner/requestor to a settlement infrastructure to query for the status of intra-balance movement modification instruction(s) based on a set of search criteria or business attributes.
/// The message may also be used to: 
/// - re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// - provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// - re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The IntraBalanceMovementModificationQuery message is sent from an account owner/requestor to a settlement infrastructure to query for the status of intra-balance movement modification instruction(s) based on a set of search criteria or business attributes.|The message may also be used to: |- re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").")]
public partial record IntraBalanceMovementModificationQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntModQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementModificationQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementModificationQueryV01Document ToDocument()
    {
        return new IntraBalanceMovementModificationQueryV01Document { Message = this };
    }
}

/// <summary>
/// The IntraBalanceMovementModificationQuery message is sent from an account owner/requestor to a settlement infrastructure to query for the status of intra-balance movement modification instruction(s) based on a set of search criteria or business attributes.
/// The message may also be used to: 
/// - re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// - provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// - re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// This is the outer document that contains <seealso cref="IntraBalanceMovementModificationQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementModificationQueryV01Document : IOuterDocument<IntraBalanceMovementModificationQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.080.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementModificationQueryV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementModificationQueryV01 Message { get; init; }
}
