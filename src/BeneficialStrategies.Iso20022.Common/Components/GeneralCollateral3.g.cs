﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralCollateral3.  ISO2002 ID# _M0GsEeoaEeadseq5W5YLvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Repurchase agreement where the agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
/// </summary>
[DataContract]
[XmlType]
public partial record GeneralCollateral3
{
    #nullable enable
    
    /// <summary>
    /// ISINs of allocated securities of general collateral where known.
    /// </summary>
    [DataMember]
    public ValueList<FinancialInstrument59> FinancialInstrumentIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// List of eligible securities to be allocated where known.
    /// </summary>
    [DataMember]
    public ValueList<IsoISINOct2015Identifier> EligibleFinancialInstrumentIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
