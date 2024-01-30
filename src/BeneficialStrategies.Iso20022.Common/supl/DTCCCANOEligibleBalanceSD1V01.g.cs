﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOEligibleBalanceSD1V01.  ISO2002 ID# _1NtQ8TL3EeKU9IrkkToqcw_-768253967.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.")]
public partial record DTCCCANOEligibleBalanceSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOElgblBalSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Extension block for the information to be extended as account balance.
    /// </summary>
    [IsoId("_1NtQ8jL3EeKU9IrkkToqcw_-169736027")]
    [Description(@"Extension block for the information to be extended as account balance.")]
    [DataMember(Name="AcctBal")]
    [XmlElement(ElementName="AcctBal")]
    public AccountBalanceExtensionSD1? AccountBalance { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOEligibleBalanceSD1V01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOEligibleBalanceSD1V01Document ToDocument()
    {
        return new DTCCCANOEligibleBalanceSD1V01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOEligibleBalanceSD1V01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOEligibleBalanceSD1V01Document : IOuterDocument<DTCCCANOEligibleBalanceSD1V01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOEligibleBalanceSD1V01"/> is required.
    /// </summary>
    public required DTCCCANOEligibleBalanceSD1V01 Message { get; init; }
}
