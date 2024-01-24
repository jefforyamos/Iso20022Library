﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementPendingReportV01.  ISO2002 ID# _DLtLGzncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This IntraBalanceMovementPendingReport message is sent from a settlement infrastructure to an account owner/request to report the intra-balance movement instructions, previously sent by the account owner, that have a pending status.
/// The message may also be used to: 
/// -	re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// -	provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// -	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This IntraBalanceMovementPendingReport message is sent from a settlement infrastructure to an account owner/request to report the intra-balance movement instructions, previously sent by the account owner, that have a pending status.||The message may also be used to: |-	re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |-	provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |-	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").")]
public partial record IntraBalanceMovementPendingReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntPdgRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementPendingReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementPendingReportV01Document ToDocument()
    {
        return new IntraBalanceMovementPendingReportV01Document { Message = this };
    }
}

/// <summary>
/// This IntraBalanceMovementPendingReport message is sent from a settlement infrastructure to an account owner/request to report the intra-balance movement instructions, previously sent by the account owner, that have a pending status.
/// The message may also be used to: 
/// -	re-send a message sent by the account owner to the account servicer (the sub-function of the message is "Duplicate") 
/// -	provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy") 
/// -	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is "Copy Duplicate").
/// This is the outer document that contains <seealso cref="IntraBalanceMovementPendingReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementPendingReportV01Document : IOuterDocument<IntraBalanceMovementPendingReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.085.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementPendingReportV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementPendingReportV01 Message { get; init; }
}
