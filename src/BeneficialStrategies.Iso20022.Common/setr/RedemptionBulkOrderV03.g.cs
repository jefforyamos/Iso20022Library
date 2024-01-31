﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderV03.  ISO2002 ID# _qYwV29E7Ed-BzquC8wXy7w_367657755.
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
/// An instructing party, for example, an investment manager or its authorised representative sends the RedemptionBulkOrder message to the executing party, for example, a transfer agent, to instruct a redemption from a financial instrument for two or more accounts.
/// Usage
/// The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are for the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.
/// This message will be typically used by a party collecting orders, that is, a concentrator, bulking these individual orders into one bulk order before sending it to an executing party.
/// For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for different financial instruments but for the same account, then the RedemptionOrder must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative sends the RedemptionBulkOrder message to the executing party, for example, a transfer agent, to instruct a redemption from a financial instrument for two or more accounts.|Usage|The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are for the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.|This message will be typically used by a party collecting orders, that is, a concentrator, bulking these individual orders into one bulk order before sending it to an executing party.|For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.|If there are redemption orders for different financial instruments but for the same account, then the RedemptionOrder must be used.")]
public partial record RedemptionBulkOrderV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedBlkOrdrV03";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_qYwV3NE7Ed-BzquC8wXy7w_-2023497525")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_qYwV3dE7Ed-BzquC8wXy7w_568061385")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_qY6G0NE7Ed-BzquC8wXy7w_565291860")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Common information related to all the orders.
    /// </summary>
    [IsoId("_qY6G0dE7Ed-BzquC8wXy7w_1784338680")]
    [Description(@"Common information related to all the orders.")]
    [DataMember(Name="BlkOrdrDtls")]
    [XmlElement(ElementName="BlkOrdrDtls")]
    [Required]
    public required RedemptionBulkOrder4 BulkOrderDetails { get; init; }
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_qY6G0tE7Ed-BzquC8wXy7w_1213604005")]
    [Description(@"Information about parties related to the transaction.")]
    [DataMember(Name="RltdPtyDtls")]
    [XmlElement(ElementName="RltdPtyDtls")]
    public required IReadOnlyCollection<Intermediary8> RelatedPartyDetails { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_qY6G09E7Ed-BzquC8wXy7w_1223759992")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_qY6G1NE7Ed-BzquC8wXy7w_1225608863")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderV03Document ToDocument()
    {
        return new RedemptionBulkOrderV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionBulkOrderV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionBulkOrderV03Document : IOuterDocument<RedemptionBulkOrderV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.001.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderV03"/> is required.
    /// </summary>
    public required RedemptionBulkOrderV03 Message { get; init; }
}
