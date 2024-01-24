﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RemittanceLocationAdviceV01.  ISO2002 ID# _10RAoKMDEeKl_NvHIICqIw.
//
namespace BeneficialStrategies.Iso20022.remt;

/// <summary>
/// The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment.")]
public partial record RemittanceLocationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RmtLctnAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RemittanceLocationAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RemittanceLocationAdviceV01Document ToDocument()
    {
        return new RemittanceLocationAdviceV01Document { Message = this };
    }
}

/// <summary>
/// The RemittanceLocationAdvice message allows the originator of the message to identify where the remittance advice is located for a related payment.
/// This is the outer document that contains <seealso cref="RemittanceLocationAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RemittanceLocationAdviceV01Document : IOuterDocument<RemittanceLocationAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:remt.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RemittanceLocationAdviceV01"/> is required.
    /// </summary>
    public required RemittanceLocationAdviceV01 Message { get; init; }
}
