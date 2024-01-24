﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InterestPaymentResponseV04.  ISO2002 ID# _CRyfgYFsEeWtPe6Crjmeug.
//
namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// Scope
/// The InterestPaymentResponse message is sent by either;
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// This is a response to the InterestPaymentRequest message and the amount of interest requested or advised can be accepted or rejected.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// The InterestPaymentResponse message is sent in response to the InterestPaymentRequest in order to accept or reject the amount of interest requested or advised. A rejection reason and information can be provide if the InterestPaymentRequest is being rejected.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The InterestPaymentResponse message is sent by either;|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager|This is a response to the InterestPaymentRequest message and the amount of interest requested or advised can be accepted or rejected.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The InterestPaymentResponse message is sent in response to the InterestPaymentRequest in order to accept or reject the amount of interest requested or advised. A rejection reason and information can be provide if the InterestPaymentRequest is being rejected.")]
public partial record InterestPaymentResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntrstPmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InterestPaymentResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InterestPaymentResponseV04Document ToDocument()
    {
        return new InterestPaymentResponseV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The InterestPaymentResponse message is sent by either;
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// This is a response to the InterestPaymentRequest message and the amount of interest requested or advised can be accepted or rejected.
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// Usage
/// The InterestPaymentResponse message is sent in response to the InterestPaymentRequest in order to accept or reject the amount of interest requested or advised. A rejection reason and information can be provide if the InterestPaymentRequest is being rejected.
/// This is the outer document that contains <seealso cref="InterestPaymentResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InterestPaymentResponseV04Document : IOuterDocument<InterestPaymentResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.014.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InterestPaymentResponseV04"/> is required.
    /// </summary>
    public required InterestPaymentResponseV04 Message { get; init; }
}
