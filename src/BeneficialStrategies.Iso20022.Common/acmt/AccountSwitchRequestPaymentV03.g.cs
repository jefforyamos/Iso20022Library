﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountSwitchRequestPaymentV03.  ISO2002 ID# _Lv10x8P_Eemsic1bQcEtLA.
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
/// This record is an implementation of the acmt.034.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AccountSwitchRequestPayment message is sent by the old account servicer to the new account servicer after the completion of the account switch to request the transfer of funds for a payment that the previous account servicer has had to make from the old account (for example: the settlement of a card transaction that was authorised offline).")]
public partial record AccountSwitchRequestPaymentV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.034.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchReqPmt";
    
    #nullable enable
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_Lv10ycP_Eemsic1bQcEtLA")]
    [Description(@"Unique identification for the message.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Contains information about the details of the account switch and a response code to the original payment request.
    /// </summary>
    [IsoId("_Lv10y8P_Eemsic1bQcEtLA")]
    [Description(@"Contains information about the details of the account switch and a response code to the original payment request.")]
    [DataMember(Name="AcctSwtchDtls")]
    [XmlElement(ElementName="AcctSwtchDtls")]
    [Required]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; }
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_Lv10zcP_Eemsic1bQcEtLA")]
    [Description(@"Account held at the old account servicer being switched to the new account servicer.")]
    [DataMember(Name="OdAcct")]
    [XmlElement(ElementName="OdAcct")]
    [Required]
    public required CashAccount39 OldAccount { get; init; }
    
    /// <summary>
    /// Specific information relating to a request for payment, including details that enable the receiving account servicer to reconcile the payment to be received with the original payment request.
    /// </summary>
    [IsoId("_Lv10z8P_Eemsic1bQcEtLA")]
    [Description(@"Specific information relating to a request for payment, including details that enable the receiving account servicer to reconcile the payment to be received with the original payment request.")]
    [DataMember(Name="CdtInstr")]
    [XmlElement(ElementName="CdtInstr")]
    [Required]
    public required CreditTransferTransaction41 CreditInstruction { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Lv100cP_Eemsic1bQcEtLA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountSwitchRequestPaymentV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountSwitchRequestPaymentV03Document ToDocument()
    {
        return new AccountSwitchRequestPaymentV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountSwitchRequestPaymentV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountSwitchRequestPaymentV03Document : IOuterDocument<AccountSwitchRequestPaymentV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.034.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountSwitchRequestPaymentV03"/> is required.
    /// </summary>
    public required AccountSwitchRequestPaymentV03 Message { get; init; }
}
