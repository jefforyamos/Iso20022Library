﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionMultipleOrderV02.  ISO2002 ID# _1eWxQNE7Ed-BzquC8wXy7w_1537721740.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// Scope
/// The SubscriptionMultipleOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to instruct the executing party to subscribe to one or more financial instruments, for the same account.
/// Usage
/// The SubscriptionMultipleOrder message is used for multiple orders. It may also be used for single orders, ie, a message containing one order for one financial instrument and related to one investment account. For a single subscription order, the SubscriptionMultipleOrder message, not the SubscriptionBulkOrder message, must be used.
/// If there are subscription orders for the same financial instrument but for different accounts, then the SubscriptionBulkOrder message must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SubscriptionMultipleOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to instruct the executing party to subscribe to one or more financial instruments, for the same account.|Usage|The SubscriptionMultipleOrder message is used for multiple orders. It may also be used for single orders, ie, a message containing one order for one financial instrument and related to one investment account. For a single subscription order, the SubscriptionMultipleOrder message, not the SubscriptionBulkOrder message, must be used.|If there are subscription orders for the same financial instrument but for different accounts, then the SubscriptionBulkOrder message must be used.")]
public partial record SubscriptionMultipleOrderV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.010.001.02";
    
    #nullable enable
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_1eWxQdE7Ed-BzquC8wXy7w_2124617993")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_1eWxQtE7Ed-BzquC8wXy7w_-2096470603")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_1eWxQ9E7Ed-BzquC8wXy7w_2058121645")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_1eWxRNE7Ed-BzquC8wXy7w_-926146084")]
    [Description(@"General information related to the order.")]
    [DataMember(Name="MltplOrdrDtls")]
    [XmlElement(ElementName="MltplOrdrDtls")]
    [Required]
    public required SubscriptionMultipleOrder2 MultipleOrderDetails { get; init; }
    
    /// <summary>
    /// Information related to the intermediary.
    /// </summary>
    [IsoId("_1eWxRdE7Ed-BzquC8wXy7w_1257163700")]
    [Description(@"Information related to the intermediary.")]
    [DataMember(Name="IntrmyDtls")]
    [XmlElement(ElementName="IntrmyDtls")]
    public required IReadOnlyCollection<Intermediary4> IntermediaryDetails { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_1eWxRtE7Ed-BzquC8wXy7w_-816960596")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1eWxR9E7Ed-BzquC8wXy7w_581032056")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionMultipleOrderV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionMultipleOrderV02Document ToDocument()
    {
        return new SubscriptionMultipleOrderV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SubscriptionMultipleOrderV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionMultipleOrderV02Document : IOuterDocument<SubscriptionMultipleOrderV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.010.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionMultipleOrderV02"/> is required.
    /// </summary>
    public required SubscriptionMultipleOrderV02 Message { get; init; }
}
