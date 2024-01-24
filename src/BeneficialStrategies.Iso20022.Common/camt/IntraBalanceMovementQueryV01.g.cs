﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementQueryV01.  ISO2002 ID# _DLtLYzncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The IntraBalanceMovementQuery message is sent from an account owner/requestor to a settlement infrastructure to query intra-balance movement instructions, along with their current status, based on a set of search criteria.
/// The message may also be used to: 
/// - re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// - provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// - re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The IntraBalanceMovementQuery message is sent from an account owner/requestor to a settlement infrastructure to query intra-balance movement instructions, along with their current status, based on a set of search criteria.|The message may also be used to: |- re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").|")]
public partial record IntraBalanceMovementQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementQueryV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementQueryV01Document ToDocument()
    {
        return new IntraBalanceMovementQueryV01Document { Message = this };
    }
}

/// <summary>
/// The IntraBalanceMovementQuery message is sent from an account owner/requestor to a settlement infrastructure to query intra-balance movement instructions, along with their current status, based on a set of search criteria.
/// The message may also be used to: 
/// - re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// - provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// - re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// This is the outer document that contains <seealso cref="IntraBalanceMovementQueryV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementQueryV01Document : IOuterDocument<IntraBalanceMovementQueryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.078.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementQueryV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementQueryV01 Message { get; init; }
}
