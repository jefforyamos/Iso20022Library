﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelForeignExchangeOptionV02.  ISO2002 ID# _KP1cKNE8Ed-BzquC8wXy7w_-352671200.
//
namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// Scope
/// The CancelForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the cancellation of a foreign currency option contract.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CancelForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the cancellation of a foreign currency option contract.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.|This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.")]
public partial record CancelForeignExchangeOptionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclFXOptnV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CancelForeignExchangeOptionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelForeignExchangeOptionV02Document ToDocument()
    {
        return new CancelForeignExchangeOptionV02Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The CancelForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the cancellation of a foreign currency option contract.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.
/// This is the outer document that contains <seealso cref="CancelForeignExchangeOptionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CancelForeignExchangeOptionV02Document : IOuterDocument<CancelForeignExchangeOptionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.011.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CancelForeignExchangeOptionV02"/> is required.
    /// </summary>
    public required CancelForeignExchangeOptionV02 Message { get; init; }
}
