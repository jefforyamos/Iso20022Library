﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SwitchOrderV03.  ISO2002 ID# _8jfn8tE7Ed-BzquC8wXy7w_-1983893425.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the SwitchOrder message to the executing party, for example, a transfer agent, to instruct a switch transaction from a financial instrument or multiple financial instruments to a different specified financial instrument or instruments for a specified amount/quantity.
/// Usage
/// The SwitchOrder message is used to either:
/// - instruct one switch transaction comprising one or more redemption legs and one or more subscription legs, that is, a single switch transaction that can be a one to one, many to one, many to many or one to many switch transaction, or,
/// - instruct one or many switch transactions each comprising one redemption leg and one subscription leg, that is, multiple simple switch transactions.
/// The SwitchOrder message may be used to either:
/// - instruct a switch transaction for one investment account, or,
/// - instruct a switch transaction for separate accounts at the redemption and subscription leg levels.|The message caters for a switch from one financial instrument to another financial instrument (within the same fund family), many to one, many to many and one to many.|The message caters for switch transactions that result in an additional cash payment from the investor or a transaction that results in a net payment to the investor. Not all institutions or funds permit this type of switch and acceptance is therefore not automatic. |There is no limitation on the number of switch legs in a switch message. The number allowed is defined by the fund prospectus or by the service level agreement (SLA) in place between the two parties. However, if the SwitchOrderDetails sequence is present more than once, then the RedemptionLegDetails and SubscriptionLegDetails sequences may only be present once.|If SwitchOrderDetails\InvestmentAccount is used, then the InvestmentAccountDetails sequences in SubscriptionLegDetails and RedemptionLegDetails are not allowed. This functionality is to be used by institutions that set up two accounts per investor, rather than one investment account.|There is no switch driver type in the message to indicate whether the switch is buy or sell driven. A driver is not needed since it is possible to indicate the total subscription amount or the total redemption amount. Only one of these two amounts should be used. |The subscription quantity can be expressed in one of the following ways:|- Amount: the monetary value (either GROSS or NET) of the financial instrument to be subscribed to, eg, the subscription of EUR 1,000 of financial instrument ISIN LU1234567890 or |- Unit: the number of units of the financial instrument to be subscribed to, eg, the subscription of 10 units of financial instrument ISIN LU1234567890 or |- Percentage of the total redemption amount: when the switch transaction is redemption driven, it is the part of the redemption amount that must be switched to a specific financial instrument, for example, the subscription quantity of financial instrument ISIN LU1234567890 represents 50% of the redemption amount of the financial instrument ISIN LU4444444444.|The redemption quantity can be expressed in one of the following ways:|- Amount: the monetary value (either GROSS or NET) of the financial instrument to be redeemed, eg, the redemption of EUR 1,000 of financial instrument ISIN LU1234567890, or |- Unit: the number of units of financial instrument to be redeemed, eg, the redemption of 10 units of financial instrument ISIN LU1234567890, or|- Rate: the part of the portfolio to be redeemed, eg, the redemption of 10% of the holdings in financial instrument ISIN LU1234567890, or|- Percentage of the total subscription amount: when the switch transaction is subscription driven, it is the part of the subscription amount that must be the result of the redemption of a specific financial instrument, for example, the redemption quantity in financial instrument ABC represents 50% of the subscription amount of the financial instrument ISIN LU4444444444|.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the SwitchOrder message to the executing party, for example, a transfer agent, to instruct a switch transaction from a financial instrument or multiple financial instruments to a different specified financial instrument or instruments for a specified amount/quantity.|Usage|The SwitchOrder message is used to either:|- instruct one switch transaction comprising one or more redemption legs and one or more subscription legs, that is, a single switch transaction that can be a one to one, many to one, many to many or one to many switch transaction, or,|- instruct one or many switch transactions each comprising one redemption leg and one subscription leg, that is, multiple simple switch transactions.|The SwitchOrder message may be used to either:|- instruct a switch transaction for one investment account, or,|- instruct a switch transaction for separate accounts at the redemption and subscription leg levels.|The message caters for a switch from one financial instrument to another financial instrument (within the same fund family), many to one, many to many and one to many.|The message caters for switch transactions that result in an additional cash payment from the investor or a transaction that results in a net payment to the investor. Not all institutions or funds permit this type of switch and acceptance is therefore not automatic. |There is no limitation on the number of switch legs in a switch message. The number allowed is defined by the fund prospectus or by the service level agreement (SLA) in place between the two parties. However, if the SwitchOrderDetails sequence is present more than once, then the RedemptionLegDetails and SubscriptionLegDetails sequences may only be present once.|If SwitchOrderDetails\InvestmentAccount is used, then the InvestmentAccountDetails sequences in SubscriptionLegDetails and RedemptionLegDetails are not allowed. This functionality is to be used by institutions that set up two accounts per investor, rather than one investment account.|There is no switch driver type in the message to indicate whether the switch is buy or sell driven. A driver is not needed since it is possible to indicate the total subscription amount or the total redemption amount. Only one of these two amounts should be used. |The subscription quantity can be expressed in one of the following ways:|- Amount: the monetary value (either GROSS or NET) of the financial instrument to be subscribed to, eg, the subscription of EUR 1,000 of financial instrument ISIN LU1234567890 or |- Unit: the number of units of the financial instrument to be subscribed to, eg, the subscription of 10 units of financial instrument ISIN LU1234567890 or |- Percentage of the total redemption amount: when the switch transaction is redemption driven, it is the part of the redemption amount that must be switched to a specific financial instrument, for example, the subscription quantity of financial instrument ISIN LU1234567890 represents 50% of the redemption amount of the financial instrument ISIN LU4444444444.|The redemption quantity can be expressed in one of the following ways:|- Amount: the monetary value (either GROSS or NET) of the financial instrument to be redeemed, eg, the redemption of EUR 1,000 of financial instrument ISIN LU1234567890, or |- Unit: the number of units of financial instrument to be redeemed, eg, the redemption of 10 units of financial instrument ISIN LU1234567890, or|- Rate: the part of the portfolio to be redeemed, eg, the redemption of 10% of the holdings in financial instrument ISIN LU1234567890, or|- Percentage of the total subscription amount: when the switch transaction is subscription driven, it is the part of the subscription amount that must be the result of the redemption of a specific financial instrument, for example, the redemption quantity in financial instrument ABC represents 50% of the subscription amount of the financial instrument ISIN LU4444444444|.")]
public partial record SwitchOrderV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrV03";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_8jfn89E7Ed-BzquC8wXy7w_668566761")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_8jfn9NE7Ed-BzquC8wXy7w_-1478725370")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_8jfn9dE7Ed-BzquC8wXy7w_743595041")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_8jfn9tE7Ed-BzquC8wXy7w_1164299570")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    public SomeMessagePaginationRecord? MessagePagination { get; init; }
    
    /// <summary>
    /// Information related to the switch order.
    /// </summary>
    [IsoId("_8jpY8NE7Ed-BzquC8wXy7w_-2137463604")]
    [Description(@"Information related to the switch order.")]
    [DataMember(Name="SwtchOrdrDtls")]
    [XmlElement(ElementName="SwtchOrdrDtls")]
    [Required]
    public required SomeSwitchOrderDetailsRecord SwitchOrderDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_8jpY8dE7Ed-BzquC8wXy7w_954155400")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_8jpY8tE7Ed-BzquC8wXy7w_956001907")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SwitchOrderV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SwitchOrderV03Document ToDocument()
    {
        return new SwitchOrderV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SwitchOrderV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SwitchOrderV03Document : IOuterDocument<SwitchOrderV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.013.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SwitchOrderV03"/> is required.
    /// </summary>
    public required SwitchOrderV03 Message { get; init; }
}
