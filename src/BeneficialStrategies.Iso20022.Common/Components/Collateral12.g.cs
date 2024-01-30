﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Collateral12.  ISO2002 ID# _zIwuD4FvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral that will be either delivered, returned or both.
/// </summary>
public partial record Collateral12
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call request.
    /// </summary>
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the margin call response.
    /// </summary>
    public IsoMax35Text? MarginCallResponseIdentification { get; init; } 
    /// <summary>
    /// Specifies the standard settlement instructions.
    /// </summary>
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    /// <summary>
    /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
    /// </summary>
    public IsoMax35Text? CollateralProposalResponseIdentification { get; init; } 
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    public SecuritiesCollateral5? SecuritiesCollateral { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    public CashCollateral3? CashCollateral { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    public OtherCollateral5? OtherCollateral { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
