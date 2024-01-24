﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SubscriptionOrderConfirmationV04.  ISO2002 ID# _Aab6xzbLEead9bDRE_1DAQ.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The SubscriptionOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a SubscriptionOrder instruction.
/// Usage
/// The SubscriptionOrderConfirmation message is used to confirm the execution of one or more individual orders.
/// A SubscriptionOrder message containing more than one individual order may be responded to by more than one SubscriptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different. When a SubscriptionOrderConfirmation message contains fewer confirmations that originally instructed in the original SubscriptionOrder message, there is no specification indication in the confirmation for this. Reconciliation must be based on the references.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the SubscriptionOrder message in which the individual orders was conveyed may also be quoted in RelatedReference but this is not recommended.
/// A SubscriptionOrder must in all cases be responded to by a SubscriptionOrderConfirmation message and in no circumstances by a SubscriptionBulkOrderConfirmation message.
/// If the executing party needs to confirm one or more subscription orders for the same financial instrument, then a SubscriptionBulkOrderConfirmation message must be used.
/// When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SubscriptionOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a SubscriptionOrder instruction.|Usage|The SubscriptionOrderConfirmation message is used to confirm the execution of one or more individual orders.|A SubscriptionOrder message containing more than one individual order may be responded to by more than one SubscriptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different. When a SubscriptionOrderConfirmation message contains fewer confirmations that originally instructed in the original SubscriptionOrder message, there is no specification indication in the confirmation for this. Reconciliation must be based on the references.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the SubscriptionOrder message in which the individual orders was conveyed may also be quoted in RelatedReference but this is not recommended.||A SubscriptionOrder must in all cases be responded to by a SubscriptionOrderConfirmation message and in no circumstances by a SubscriptionBulkOrderConfirmation message.|If the executing party needs to confirm one or more subscription orders for the same financial instrument, then a SubscriptionBulkOrderConfirmation message must be used.|When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.")]
public partial record SubscriptionOrderConfirmationV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdrConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SubscriptionOrderConfirmationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SubscriptionOrderConfirmationV04Document ToDocument()
    {
        return new SubscriptionOrderConfirmationV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The SubscriptionOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of the execution of a SubscriptionOrder instruction.
/// Usage
/// The SubscriptionOrderConfirmation message is used to confirm the execution of one or more individual orders.
/// A SubscriptionOrder message containing more than one individual order may be responded to by more than one SubscriptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different. When a SubscriptionOrderConfirmation message contains fewer confirmations that originally instructed in the original SubscriptionOrder message, there is no specification indication in the confirmation for this. Reconciliation must be based on the references.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the SubscriptionOrder message in which the individual orders was conveyed may also be quoted in RelatedReference but this is not recommended.
/// A SubscriptionOrder must in all cases be responded to by a SubscriptionOrderConfirmation message and in no circumstances by a SubscriptionBulkOrderConfirmation message.
/// If the executing party needs to confirm one or more subscription orders for the same financial instrument, then a SubscriptionBulkOrderConfirmation message must be used.
/// When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.
/// This is the outer document that contains <seealso cref="SubscriptionOrderConfirmationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SubscriptionOrderConfirmationV04Document : IOuterDocument<SubscriptionOrderConfirmationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.012.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SubscriptionOrderConfirmationV04"/> is required.
    /// </summary>
    public required SubscriptionOrderConfirmationV04 Message { get; init; }
}
