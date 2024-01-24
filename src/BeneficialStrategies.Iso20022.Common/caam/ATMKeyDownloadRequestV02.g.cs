﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMKeyDownloadRequestV02.  ISO2002 ID# _jHkLIa45EeWRfYPBaeOY8w.
//
namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.")]
public partial record ATMKeyDownloadRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMKeyDownloadRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMKeyDownloadRequestV02Document ToDocument()
    {
        return new ATMKeyDownloadRequestV02Document { Message = this };
    }
}

/// <summary>
/// The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.
/// This is the outer document that contains <seealso cref="ATMKeyDownloadRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMKeyDownloadRequestV02Document : IOuterDocument<ATMKeyDownloadRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.003.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMKeyDownloadRequestV02"/> is required.
    /// </summary>
    public required ATMKeyDownloadRequestV02 Message { get; init; }
}
