﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionAdviceResponseV04.  ISO2002 ID# _0jwTEXMlEe2vXY6MoVq19w.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.")]
public partial record TransactionAdviceResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionAdviceResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionAdviceResponseV04Document ToDocument()
    {
        return new TransactionAdviceResponseV04Document { Message = this };
    }
}

/// <summary>
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// This is the outer document that contains <seealso cref="TransactionAdviceResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransactionAdviceResponseV04Document : IOuterDocument<TransactionAdviceResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.021.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionAdviceResponseV04"/> is required.
    /// </summary>
    public required TransactionAdviceResponseV04 Message { get; init; }
}
