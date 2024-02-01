﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _0nw0g8KwEeuM4pgP8Vixbg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PositionSetReport3Choice;

/// <summary>
/// Detailed aggregated position set report between a pair of counterparties.
/// </summary>
public partial record Report : PositionSetReport3Choice_
{
    #nullable enable
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    public required IsoISODate ReferenceDate { get; init; } 
    /// <summary>
    /// Report containing aggregation of loan and collateral exposures between counterparties by Securities Financing Transaction type, for a limited number of fields.
    /// </summary>
    public PositionSet16? GeneralInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Aggregation of data for all transactions pertaining to the loan side, by Securities Financing Transaction type.
    /// </summary>
    public PositionSet17? Loan { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Aggregation of data for all submissions pertaining to the collateral side, by Securities Financing Transaction type.
    /// </summary>
    public PositionSet18? Collateral { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Aggregation of data related to margin reported for cleared Securities Financing Transactions at the level of each pair of entities and portfolio code.
    /// </summary>
    public PositionSet20? Margin { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Aggregation of data on collateral reuse transactions, at entity level.
    /// </summary>
    public PositionSet19? Reuse { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
