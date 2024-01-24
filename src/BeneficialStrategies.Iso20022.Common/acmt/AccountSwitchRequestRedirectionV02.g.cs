﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchRequestRedirectionV02.  ISO2002 ID# _7HT_g242EeiU9cctagi5ow.
//
namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.")]
public partial record AccountSwitchRequestRedirectionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqRdrctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchRequestRedirectionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchRequestRedirectionV02Document ToDocument()
    {
        return new AccountSwitchRequestRedirectionV02Document { Message = this };
    }
}

/// <summary>
/// The AccountSwitchRequestRedirection message is sent by the new account servicer to a central account switch servicer to set up the redirection of payment and collection transactions that are processed after completion of the account switch.  It is routed to the previous account servicer to signal that it should schedule the cancellation of all payment arrangements on the old account. This message may also be used by the new bank to amend the new account details, if the details previously provided were incorrect.
/// This is the outer document that contains <seealso cref="AccountSwitchRequestRedirectionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchRequestRedirectionV02Document : IOuterDocument<AccountSwitchRequestRedirectionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.030.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchRequestRedirectionV02"/> is required.
    /// </summary>
    public required AccountSwitchRequestRedirectionV02 Message { get; init; }
}
