﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMRejectV02.  ISO2002 ID# _EnCvca42EeWpsoxRhdX-8A.
//
namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// The ATMReject message is sent by any entity to reject a received message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMReject message is sent by any entity to reject a received message.")]
public partial record ATMRejectV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMRjct";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMRejectV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMRejectV02Document ToDocument()
    {
        return new ATMRejectV02Document { Message = this };
    }
}

/// <summary>
/// The ATMReject message is sent by any entity to reject a received message.
/// This is the outer document that contains <seealso cref="ATMRejectV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMRejectV02Document : IOuterDocument<ATMRejectV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMRejectV02"/> is required.
    /// </summary>
    public required ATMRejectV02 Message { get; init; }
}
