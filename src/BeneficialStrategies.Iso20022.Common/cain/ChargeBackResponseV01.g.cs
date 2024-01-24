﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ChargeBackResponseV01.  ISO2002 ID# _yC2YlFZgEeen1vB4iz5SyA.
//
namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// The ChargeBackResponse message is sent by an acquirer or an agent to an issuer in response to an ChargeBackInitiation message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ChargeBackResponse message is sent by an acquirer or an agent to an issuer in response to an ChargeBackInitiation message.")]
public partial record ChargeBackResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ChrgBckRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ChargeBackResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ChargeBackResponseV01Document ToDocument()
    {
        return new ChargeBackResponseV01Document { Message = this };
    }
}

/// <summary>
/// The ChargeBackResponse message is sent by an acquirer or an agent to an issuer in response to an ChargeBackInitiation message.
/// This is the outer document that contains <seealso cref="ChargeBackResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ChargeBackResponseV01Document : IOuterDocument<ChargeBackResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.028.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ChargeBackResponseV01"/> is required.
    /// </summary>
    public required ChargeBackResponseV01 Message { get; init; }
}
