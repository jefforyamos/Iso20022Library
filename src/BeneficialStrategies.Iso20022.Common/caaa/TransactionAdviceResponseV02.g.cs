﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransactionAdviceResponseV02.  ISO2002 ID# __d4GQS1yEeuZtpnZJ4v-5Q.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.")]
public partial record TransactionAdviceResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TxAdvcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransactionAdviceResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransactionAdviceResponseV02Document ToDocument()
    {
        return new TransactionAdviceResponseV02Document { Message = this };
    }
}

/// <summary>
/// The TransactionAdviceResponse message is sent by the POI to acknowledge the Acquirer (or its agent) about the notification of the transaction advice.
/// This is the outer document that contains <seealso cref="TransactionAdviceResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransactionAdviceResponseV02Document : IOuterDocument<TransactionAdviceResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.021.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransactionAdviceResponseV02"/> is required.
    /// </summary>
    public required TransactionAdviceResponseV02 Message { get; init; }
}
