﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelNonDeliverableForwardValuationV02.  ISO2002 ID# _MYoUotE8Ed-BzquC8wXy7w_-340131062.
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
/// The CancelNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the cancellation of the valuation of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CancelNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the cancellation of the valuation of a non deliverable trade previously confirmed by the sender.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.")]
public partial record CancelNonDeliverableForwardValuationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclNDFValtnV02";
    
    #nullable enable
    /// <summary>
    /// Provides references and date of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUo9E8Ed-BzquC8wXy7w_-745317673")]
    [Description(@"Provides references and date of the valuation of the non deliverable trade which is cancelled.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required TradeAgreement2 TradeInformation { get; init; }
    
    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUpNE8Ed-BzquC8wXy7w_200370128")]
    [Description(@"Specifies the trading side of the non deliverable trade which is cancelled.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    public TradePartyIdentification3? TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUpdE8Ed-BzquC8wXy7w_67383181")]
    [Description(@"Specifies the counterparty of the non deliverable trade which is cancelled.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    public TradePartyIdentification3? CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the amounts of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUptE8Ed-BzquC8wXy7w_-761938752")]
    [Description(@"Specifies the amounts of the valuation of the non deliverable trade which is cancelled.")]
    [DataMember(Name="TradAmts")]
    [XmlElement(ElementName="TradAmts")]
    public AmountsAndValueDate1? TradeAmounts { get; init; }
    
    /// <summary>
    /// Specifies the valuation rate of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUp9E8Ed-BzquC8wXy7w_-748089195")]
    [Description(@"Specifies the valuation rate of the valuation of the non deliverable trade which is cancelled.")]
    [DataMember(Name="ValtnRate")]
    [XmlElement(ElementName="ValtnRate")]
    public AgreedRate1? ValuationRate { get; init; }
    
    /// <summary>
    /// Specifies the valuation information of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUqNE8Ed-BzquC8wXy7w_-750859823")]
    [Description(@"Specifies the valuation information of the valuation of the non deliverable trade which is cancelled.")]
    [DataMember(Name="ValtnInf")]
    [XmlElement(ElementName="ValtnInf")]
    public ValuationData2? ValuationInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CancelNonDeliverableForwardValuationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelNonDeliverableForwardValuationV02Document ToDocument()
    {
        return new CancelNonDeliverableForwardValuationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CancelNonDeliverableForwardValuationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CancelNonDeliverableForwardValuationV02Document : IOuterDocument<CancelNonDeliverableForwardValuationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.006.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CancelNonDeliverableForwardValuationV02"/> is required.
    /// </summary>
    public required CancelNonDeliverableForwardValuationV02 Message { get; init; }
}
