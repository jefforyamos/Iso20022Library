﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchNotifyAccountSwitchCompleteV02.  ISO2002 ID# _7HK1q242EeiU9cctagi5ow.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.acmt;


/// <summary>
/// The AccountSwitchNotifyAccountSwitchComplete message is sent by the new account servicer to a central account switch servicer to signal that it has completed the account switch. 
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchNotifyAccountSwitchComplete message is sent by the new account servicer to a central account switch servicer to signal that it has completed the account switch. ")]
public partial record AccountSwitchNotifyAccountSwitchCompleteV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchNtfyAcctSwtchCmplt";
    
    #nullable enable
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HK1rW42EeiU9cctagi5ow")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the account switch.
    /// Usage: This element is used to communicate confirmation of the account switch.
    /// </summary>
    [IsoId("_7HK1r242EeiU9cctagi5ow")]
    [Description(@"Contains information about the account switch.||Usage: This element is used to communicate confirmation of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HK1sW42EeiU9cctagi5ow")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchNotifyAccountSwitchCompleteV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchNotifyAccountSwitchCompleteV02Document ToDocument()
    {
        return new AccountSwitchNotifyAccountSwitchCompleteV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchNotifyAccountSwitchCompleteV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchNotifyAccountSwitchCompleteV02Document : IOuterDocument<AccountSwitchNotifyAccountSwitchCompleteV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.033.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchNotifyAccountSwitchCompleteV02"/> is required.
    /// </summary>
    public required AccountSwitchNotifyAccountSwitchCompleteV02 Message { get; init; }
}
