﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchNotifyAccountSwitchCompleteV01.  ISO2002 ID# _Vh8wEhMLEeSTk5fcu7tr9w.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchNotifyAccountSwitchComplete message is sent by the new account servicer to a central account switch servicer to signal that it has completed the account switch. 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchNotifyAccountSwitchComplete message is sent by the new account servicer to a central account switch servicer to signal that it has completed the account switch. ")]
public partial record AccountSwitchNotifyAccountSwitchCompleteV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchNtfyAcctSwtchCmplt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_sQzJUa5jEee17eDA_q0a9g")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the account switch.
    /// Usage: This element is used to communicate confirmation of the account switch.
    /// </summary>
    [IsoId("_vdOCAa5jEee17eDA_q0a9g")]
    [Description(@"Contains information about the account switch.||Usage: This element is used to communicate confirmation of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required SomeAccountSwitchDetailsRecord AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CksAMA8FEeeJ4ZumUkzG4Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchNotifyAccountSwitchCompleteV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchNotifyAccountSwitchCompleteV01Document ToDocument()
    {
        return new AccountSwitchNotifyAccountSwitchCompleteV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchNotifyAccountSwitchCompleteV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchNotifyAccountSwitchCompleteV01Document : IOuterDocument<AccountSwitchNotifyAccountSwitchCompleteV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.033.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchNotifyAccountSwitchCompleteV01"/> is required.
    /// </summary>
    public required AccountSwitchNotifyAccountSwitchCompleteV01 Message { get; init; }
}