﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementStatusAdviceV01.  ISO2002 ID# _DLtLcTncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is "Duplicate")|- provide a third party with a copy of a message for information (the sub-function of the message is "Copy")|- re-send to a third party a copy of a message for information (the sub-function of the message is "CopyDuplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"").")]
public partial record IntraBalanceMovementStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementStatusAdviceV01Document ToDocument()
    {
        return new IntraBalanceMovementStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is "Duplicate")|- provide a third party with a copy of a message for information (the sub-function of the message is "Copy")|- re-send to a third party a copy of a message for information (the sub-function of the message is "CopyDuplicate").
/// This is the outer document that contains <seealso cref="IntraBalanceMovementStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementStatusAdviceV01Document : IOuterDocument<IntraBalanceMovementStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.067.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementStatusAdviceV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementStatusAdviceV01 Message { get; init; }
}
