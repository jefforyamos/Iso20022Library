﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GeneralCollateral.  ISO2002 ID# _BqvK8-oaEeadseq5W5YLvQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType3Choice;

/// <summary>
/// Indicates that the repurchase agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
/// </summary>
public partial record GeneralCollateral : IRepurchaseAgreementType3Choice
{
    #nullable enable
    /// <summary>
    /// ISINs of allocated securities of general collateral where known.
    /// </summary>
    public FinancialInstrument59? FinancialInstrumentIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// List of eligible securities to be allocated where known.
    /// </summary>
    public IsoISINOct2015Identifier? EligibleFinancialInstrumentIdentification { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
