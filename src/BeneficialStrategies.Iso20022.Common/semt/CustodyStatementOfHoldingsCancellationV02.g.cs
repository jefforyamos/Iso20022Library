﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustodyStatementOfHoldingsCancellationV02.  ISO2002 ID# _Mb_vvNFSEd-BzquC8wXy7w_-145472728.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account servicer, for example, a transfer agent, sends the CustodyStatementOfHoldingsCancellation message to the account owner, for example, an investment manager or its authorised representative to cancel a previously sent CustodyStatementOfHoldings message.
/// Usage
/// The CustodyStatementOfHoldingsCancellation message is used to cancel a previously sent CustodyStatementOfHoldings message. This message must contain the reference of the message to be cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account servicer, for example, a transfer agent, sends the CustodyStatementOfHoldingsCancellation message to the account owner, for example, an investment manager or its authorised representative to cancel a previously sent CustodyStatementOfHoldings message.|Usage|The CustodyStatementOfHoldingsCancellation message is used to cancel a previously sent CustodyStatementOfHoldings message. This message must contain the reference of the message to be cancelled.|This message may also contain details of the message to be cancelled, but this is not recommended.")]
public partial record CustodyStatementOfHoldingsCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtdyStmtOfHldgsCxlV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustodyStatementOfHoldingsCancellationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustodyStatementOfHoldingsCancellationV02Document ToDocument()
    {
        return new CustodyStatementOfHoldingsCancellationV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// An account servicer, for example, a transfer agent, sends the CustodyStatementOfHoldingsCancellation message to the account owner, for example, an investment manager or its authorised representative to cancel a previously sent CustodyStatementOfHoldings message.
/// Usage
/// The CustodyStatementOfHoldingsCancellation message is used to cancel a previously sent CustodyStatementOfHoldings message. This message must contain the reference of the message to be cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// This is the outer document that contains <seealso cref="CustodyStatementOfHoldingsCancellationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CustodyStatementOfHoldingsCancellationV02Document : IOuterDocument<CustodyStatementOfHoldingsCancellationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustodyStatementOfHoldingsCancellationV02"/> is required.
    /// </summary>
    public required CustodyStatementOfHoldingsCancellationV02 Message { get; init; }
}
