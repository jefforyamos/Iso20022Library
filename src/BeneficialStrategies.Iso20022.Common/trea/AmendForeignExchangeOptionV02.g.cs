﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AmendForeignExchangeOptionV02.  ISO2002 ID# _HQD4WNE8Ed-BzquC8wXy7w_-1614590929.
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
/// This record is an implementation of the trea.010.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the amendment of a foreign currency option contract.
/// Usage
/// The message contains a Related Reference to link it to the previously sent notification and may contain an reason for amendment.
/// This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AmendForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the amendment of a foreign currency option contract.|Usage|The message contains a Related Reference to link it to the previously sent notification and may contain an reason for amendment.|This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.")]
public partial record AmendForeignExchangeOptionV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.010.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdFXOptnV02";
    
    #nullable enable
    /// <summary>
    /// Provides reference and date of the foreign exchange option trade which is amended.
    /// </summary>
    [IsoId("_HQD4WdE8Ed-BzquC8wXy7w_-277529666")]
    [Description(@"Provides reference and date of the foreign exchange option trade which is amended.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required TradeAgreement2 TradeInformation { get; init; }
    
    /// <summary>
    /// Specifies the trading side of the currency option trade which is amended.
    /// </summary>
    [IsoId("_HQD4WtE8Ed-BzquC8wXy7w_-515469288")]
    [Description(@"Specifies the trading side of the currency option trade which is amended.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    [Required]
    public required TradePartyIdentification4 TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the counterparty of the currency option trade which is amended.
    /// </summary>
    [IsoId("_HQD4W9E8Ed-BzquC8wXy7w_296306803")]
    [Description(@"Specifies the counterparty of the currency option trade which is amended.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    [Required]
    public required TradePartyIdentification4 CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the parameters of the currency option which is bought by the trading side.
    /// </summary>
    [IsoId("_HQNCQNE8Ed-BzquC8wXy7w_1463318138")]
    [Description(@"Specifies the parameters of the currency option which is bought by the trading side.")]
    [DataMember(Name="Optn")]
    [XmlElement(ElementName="Optn")]
    [Required]
    public required Option3 Option { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AmendForeignExchangeOptionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AmendForeignExchangeOptionV02Document ToDocument()
    {
        return new AmendForeignExchangeOptionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AmendForeignExchangeOptionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AmendForeignExchangeOptionV02Document : IOuterDocument<AmendForeignExchangeOptionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.010.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AmendForeignExchangeOptionV02"/> is required.
    /// </summary>
    public required AmendForeignExchangeOptionV02 Message { get; init; }
}
