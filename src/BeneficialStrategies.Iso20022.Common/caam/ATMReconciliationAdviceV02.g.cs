﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMReconciliationAdviceV02.  ISO2002 ID# _HD6BMa47EeWRfYPBaeOY8w.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The ATMReconciliationAdvice message is sent by an ATM to an acquirer or its agent to send all the counters of the ATM. It can be sent by an operator function or as a response of a command sent by an agent or a server.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMReconciliationAdvice message is sent by an ATM to an acquirer or its agent to send all the counters of the ATM. It can be sent by an operator function or as a response of a command sent by an agent or a server.")]
public partial record ATMReconciliationAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMRcncltnAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMReconciliationAdviceV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMReconciliationAdviceV02Document ToDocument()
    {
        return new ATMReconciliationAdviceV02Document { Message = this };
    }
}

/// <summary>
/// The ATMReconciliationAdvice message is sent by an ATM to an acquirer or its agent to send all the counters of the ATM. It can be sent by an operator function or as a response of a command sent by an agent or a server.
/// This is the outer document that contains <seealso cref="ATMReconciliationAdviceV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMReconciliationAdviceV02Document : IOuterDocument<ATMReconciliationAdviceV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.009.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMReconciliationAdviceV02"/> is required.
    /// </summary>
    public required ATMReconciliationAdviceV02 Message { get; init; }
}
