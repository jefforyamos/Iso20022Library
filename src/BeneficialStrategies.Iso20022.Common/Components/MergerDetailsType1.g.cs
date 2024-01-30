﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MergerDetailsType1.  ISO2002 ID# _IY-XYFPaEeG1qPPaW9KJvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information about mergers.
/// </summary>
public partial record MergerDetailsType1
{
    #nullable enable
    
    /// <summary>
    /// Differentiation of different types of merger.
    /// 合併/株式交換/株式移転の区分.
    /// </summary>
    public MergerTypeCode? MergerType { get; init; } 
    /// <summary>
    /// Information about the counterparty in case of [sankaku] gappei: the scenario where a third party is involved as one of the counterparties in the merger but there is no security movement from the third party.
    /// </summary>
    public CounterpartyDetailsType1? CounterpartyDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Classification of the simplified merger regulatory condition of the parent company.
    /// 簡易区分.
    /// </summary>
    public MergerCode? SimplifiedMergerClassification { get; init; } 
    /// <summary>
    /// Classification of the short form merger regulatory condition of the subsidiary company.
    /// 略式区分.
    /// </summary>
    public MergerCode? ShortFormMergerClassification { get; init; } 
    /// <summary>
    /// Share unit quantity of the shares of the new company.
    /// 新設会社の単元株数.
    /// </summary>
    public IsoNumber? ShareUnitQuantityOfNewCompany { get; init; } 
    
    #nullable disable
}
