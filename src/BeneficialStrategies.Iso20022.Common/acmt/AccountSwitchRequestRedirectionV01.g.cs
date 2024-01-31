﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchRequestRedirectionV01.  ISO2002 ID# _e20_UhMMEeSTk5fcu7tr9w.
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
/// The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.")]
public partial record AccountSwitchRequestRedirectionV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqRdrctn";
    
    #nullable enable
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_QD6AUa5kEee17eDA_q0a9g")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_RRa8Ua5kEee17eDA_q0a9g")]
    [Description(@"Contains information about the details of the account switch.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Account servicer holding the account to which the switch will be made for example the acquiring account servicer.
    /// </summary>
    [IsoId("_vZp4cBMMEeSTk5fcu7tr9w")]
    [Description(@"Account servicer holding the account to which the switch will be made for example the acquiring account servicer.")]
    [DataMember(Name="NewAcct")]
    [XmlElement(ElementName="NewAcct")]
    [Required]
    public required CashAccount36 NewAccount { get; init; }
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_ydI3kBMMEeSTk5fcu7tr9w")]
    [Description(@"Account held at the old account servicer being switched to the new account servicer.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required CashAccount36 OldAccount { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_lcrIMA8EEeeJ4ZumUkzG4Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchRequestRedirectionV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchRequestRedirectionV01Document ToDocument()
    {
        return new AccountSwitchRequestRedirectionV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchRequestRedirectionV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchRequestRedirectionV01Document : IOuterDocument<AccountSwitchRequestRedirectionV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.030.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchRequestRedirectionV01"/> is required.
    /// </summary>
    public required AccountSwitchRequestRedirectionV01 Message { get; init; }
}
