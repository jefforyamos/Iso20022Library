﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionStateReportV01.  ISO2002 ID# _2zvMKQuAEeqVvtu9Ny8FDA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.079.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesFinancingReportingTransactionStateReport is sent by the trade repository (TR) to the other trade repository (TR) or the authority or made available to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingTransactionStateReport is sent by the trade repository (TR) to the other trade repository (TR) or the authority or made available to the  report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable, containing latest state of the transaction.")]
public partial record SecuritiesFinancingReportingTransactionStateReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.079.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxStatRpt";
    
    #nullable enable
    /// <summary>
    /// Information related to trade state reporting.
    /// </summary>
    [IsoId("_2zvMKwuAEeqVvtu9Ny8FDA")]
    [Description(@"Information related to trade state reporting.")]
    [DataMember(Name="TradData")]
    [XmlElement(ElementName="TradData")]
    [Required]
    public required TradeStateReport2Choice_ TradeData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2zvMLQuAEeqVvtu9Ny8FDA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionStateReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionStateReportV01Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionStateReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionStateReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingTransactionStateReportV01Document : IOuterDocument<SecuritiesFinancingReportingTransactionStateReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.079.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionStateReportV01"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingTransactionStateReportV01 Message { get; init; }
}
