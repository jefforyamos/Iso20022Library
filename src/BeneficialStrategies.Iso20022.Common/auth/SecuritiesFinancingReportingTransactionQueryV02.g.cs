﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesFinancingReportingTransactionQueryV02.  ISO2002 ID# _vY6mgcKvEeuzU9S_IANlog.
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
/// The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The SecuritiesFinancingReportingTransactionQuery message is sent by the authority to the trade repositories, to query data based on the search criteria for the  transactions as defined by the system user.")]
public partial record SecuritiesFinancingReportingTransactionQueryV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgTxQry";
    
    #nullable enable
    /// <summary>
    /// Set of information identifying the authority that requests the query report.
    /// </summary>
    [IsoId("_vY6mg8KvEeuzU9S_IANlog")]
    [Description(@"Set of information identifying the authority that requests the query report.")]
    [DataMember(Name="RqstngAuthrty")]
    [XmlElement(ElementName="RqstngAuthrty")]
    [Required]
    public required IPartyIdentification121Choice RequestingAuthority { get; init; }
    
    /// <summary>
    /// Criteria for defining recurrent and ad-hoc queries.
    /// </summary>
    [IsoId("_vY6mhcKvEeuzU9S_IANlog")]
    [Description(@"Criteria for defining recurrent and ad-hoc queries.")]
    [DataMember(Name="TradQryData")]
    [XmlElement(ElementName="TradQryData")]
    [Required]
    public required ITradeReportQuery13Choice TradeQueryData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vY6mh8KvEeuzU9S_IANlog")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesFinancingReportingTransactionQueryV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesFinancingReportingTransactionQueryV02Document ToDocument()
    {
        return new SecuritiesFinancingReportingTransactionQueryV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesFinancingReportingTransactionQueryV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesFinancingReportingTransactionQueryV02Document : IOuterDocument<SecuritiesFinancingReportingTransactionQueryV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.094.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesFinancingReportingTransactionQueryV02"/> is required.
    /// </summary>
    public required SecuritiesFinancingReportingTransactionQueryV02 Message { get; init; }
}
