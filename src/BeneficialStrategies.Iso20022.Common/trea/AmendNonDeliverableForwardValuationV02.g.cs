﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AmendNonDeliverableForwardValuationV02.  ISO2002 ID# _JckzONE8Ed-BzquC8wXy7w_-1127631553.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.trea;


/// <summary>
/// Scope
/// The AmendNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the amendment of the valuation of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message is sent from a participant to a central settlement system to advise of the update of a previously sent notification and it contains a "Related Reference" to link it to the previous notification.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AmendNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the amendment of the valuation of a non deliverable trade previously confirmed by the sender.|Usage|The message is sent from a participant to a central settlement system to advise of the update of a previously sent notification and it contains a ""Related Reference"" to link it to the previous notification.")]
public partial record AmendNonDeliverableForwardValuationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdNDFValtnV02";
    
    #nullable enable
    /// <summary>
    /// Provides references and date of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JckzOdE8Ed-BzquC8wXy7w_-1108779628")]
    [Description(@"Provides references and date of the valuation of the non deliverable trade which is amended.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required TradeAgreement2 TradeInformation { get; init; }
    
    /// <summary>
    /// Specifies the trading side of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JckzOtE8Ed-BzquC8wXy7w_-1401408196")]
    [Description(@"Specifies the trading side of the valuation of the non deliverable trade which is amended.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    [Required]
    public required TradePartyIdentification3 TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the counterparty of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JckzO9E8Ed-BzquC8wXy7w_-2032175429")]
    [Description(@"Specifies the counterparty of the valuation of the non deliverable trade which is amended.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    [Required]
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the amounts of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JcukMNE8Ed-BzquC8wXy7w_-2028607038")]
    [Description(@"Specifies the amounts of the valuation of the non deliverable trade which is amended.")]
    [DataMember(Name="TradAmts")]
    [XmlElement(ElementName="TradAmts")]
    [Required]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }
    
    /// <summary>
    /// Specifies the valuation rate of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JcukMdE8Ed-BzquC8wXy7w_-1317493499")]
    [Description(@"Specifies the valuation rate of the valuation of the non deliverable trade which is amended.")]
    [DataMember(Name="ValtnRate")]
    [XmlElement(ElementName="ValtnRate")]
    [Required]
    public required AgreedRate1 ValuationRate { get; init; }
    
    /// <summary>
    /// Specifies the valuation information of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JcukMtE8Ed-BzquC8wXy7w_-1709991694")]
    [Description(@"Specifies the valuation information of the valuation of the non deliverable trade which is amended.")]
    [DataMember(Name="ValtnInf")]
    [XmlElement(ElementName="ValtnInf")]
    [Required]
    public required ValuationData2 ValuationInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AmendNonDeliverableForwardValuationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AmendNonDeliverableForwardValuationV02Document ToDocument()
    {
        return new AmendNonDeliverableForwardValuationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AmendNonDeliverableForwardValuationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AmendNonDeliverableForwardValuationV02Document : IOuterDocument<AmendNonDeliverableForwardValuationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AmendNonDeliverableForwardValuationV02"/> is required.
    /// </summary>
    public required AmendNonDeliverableForwardValuationV02 Message { get; init; }
}
