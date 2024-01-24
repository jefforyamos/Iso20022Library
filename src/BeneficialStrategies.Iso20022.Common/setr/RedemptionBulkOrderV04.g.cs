﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderV04.  ISO2002 ID# _AaSJATbLEead9bDRE_1DAQ.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The RedemptionBulkOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct a redemption from a financial instrument for two or more accounts.
/// Usage
/// The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are for the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.
/// This message will be typically used by a party collecting orders, that is, a concentrator, bulking these individual orders into one bulk order before sending it to an executing party.
/// For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for different financial instruments but for the same account, then the RedemptionOrder must be used.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RedemptionBulkOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct a redemption from a financial instrument for two or more accounts.|Usage|The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are for the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.|This message will be typically used by a party collecting orders, that is, a concentrator, bulking these individual orders into one bulk order before sending it to an executing party.|For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.|If there are redemption orders for different financial instruments but for the same account, then the RedemptionOrder must be used.")]
public partial record RedemptionBulkOrderV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedBlkOrdr";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderV04Document ToDocument()
    {
        return new RedemptionBulkOrderV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The RedemptionBulkOrder message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to instruct a redemption from a financial instrument for two or more accounts.
/// Usage
/// The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, that is, account owners, but are for the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.
/// This message will be typically used by a party collecting orders, that is, a concentrator, bulking these individual orders into one bulk order before sending it to an executing party.
/// For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for different financial instruments but for the same account, then the RedemptionOrder must be used.
/// This is the outer document that contains <seealso cref="RedemptionBulkOrderV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionBulkOrderV04Document : IOuterDocument<RedemptionBulkOrderV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderV04"/> is required.
    /// </summary>
    public required RedemptionBulkOrderV04 Message { get; init; }
}
