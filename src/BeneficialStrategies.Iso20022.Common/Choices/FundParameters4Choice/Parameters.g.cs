﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Parameters.  ISO2002 ID# _KQCmF2omEeipaMTLlhaKMQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundParameters4Choice;

/// <summary>
/// Report parameters.
/// </summary>
public partial record Parameters : FundParameters4Choice_
{
    #nullable enable
    /// <summary>
    /// Financial instrument for which the report is requested.
    /// </summary>
    public FinancialInstrument71? FinancialInstrumentDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Fund management company for which the report is requested.
    /// </summary>
    public PartyIdentification139? FundManagementCompany { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the date on or after which the information required will have been last updated. Only the most recent versions of the data is required.
    /// </summary>
    public IsoISODate? DateFrom { get; init; } 
    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    public CountryCode? CountryOfDomicile { get; init; } 
    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    public CountryCode? RegisteredDistributionCountry { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
