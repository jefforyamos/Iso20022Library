﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction6SD1.  ISO2002 ID# _yeONwFPNEeG1_c7AazzqRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for mergers.
/// </summary>
public partial record CorporateAction6SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Provides additional information about mergers.
    /// </summary>
    public MergerDetailsType1? MergerDetails { get; init; } 
    /// <summary>
    /// Agreement of the target company.
    /// TargetCompanyAgreement should only be used for corporate action event type code TEND. It is not necessary for corporate action event type code BIDS. 
    ///  対象会社の同意の有無
    /// 公開買付のときのみ。（自己株買付のときは無し）.
    /// </summary>
    public TargetCompanyAgreementCode? TargetCompanyAgreement { get; init; } 
    /// <summary>
    /// Total number of new shares to be issued.
    /// 発行新株式数.
    /// </summary>
    public IFinancialInstrumentQuantity15Choice? TotalNumberOfNewSharesIssued { get; init; } 
    
    #nullable disable
}
