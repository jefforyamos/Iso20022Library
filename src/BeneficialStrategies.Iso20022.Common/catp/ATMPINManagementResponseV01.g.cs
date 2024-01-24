﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMPINManagementResponseV01.  ISO2002 ID# _qemjoIrBEeSgLpgNvMAP2g.
//
namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// The ATMPINManagementResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the cardholder PIN operation requested in the ATMPINManagementRequest.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ATMPINManagementResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the cardholder PIN operation requested in the ATMPINManagementRequest.")]
public partial record ATMPINManagementResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMPINMgmtRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_yhjGYIrBEeSgLpgNvMAP2g")]
    [Description(@"Information related to the protocol management on a segment of the path from the ATM to the acquirer.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_8O7xsIrBEeSgLpgNvMAP2g")]
    [Description(@"Encrypted body of the message.")]
    [DataMember(Name="PrtctdATMPINMgmtRspn")]
    [XmlElement(ElementName="PrtctdATMPINMgmtRspn")]
    public SomeProtectedATMPINManagementResponseRecord? ProtectedATMPINManagementResponse { get; init; }
    
    /// <summary>
    /// Information related to the response of an ATM PIN Management from an ATM manager.
    /// </summary>
    [IsoId("_F2W-8IrCEeSgLpgNvMAP2g")]
    [Description(@"Information related to the response of an ATM PIN Management from an ATM manager.")]
    [DataMember(Name="ATMPINMgmtRspn")]
    [XmlElement(ElementName="ATMPINMgmtRspn")]
    public SomeATMPINManagementResponseRecord? ATMPINManagementResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_JoPVIIrCEeSgLpgNvMAP2g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ATMPINManagementResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMPINManagementResponseV01Document ToDocument()
    {
        return new ATMPINManagementResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ATMPINManagementResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ATMPINManagementResponseV01Document : IOuterDocument<ATMPINManagementResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ATMPINManagementResponseV01"/> is required.
    /// </summary>
    public required ATMPINManagementResponseV01 Message { get; init; }
}
