﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMarginMarginUpdate5.  ISO2002 ID# _h3QwYcg2EeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the collateral margin data.
/// </summary>
[DataContract]
[XmlType]
public partial record CollateralMarginMarginUpdate5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [DataMember]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    [DataMember]
    public required IsoISODateTime ReportingDateTime { get; init; } 
    /// <summary>
    /// Date for which the information contained in the report is provided.
    /// </summary>
    [DataMember]
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Data specific to counterparties of the reported transaction.
    /// </summary>
    [DataMember]
    public Counterparty39? Counterparty { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [DataMember]
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [DataMember]
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    [DataMember]
    public ReceivedMarginOrCollateral4? ReceivedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
