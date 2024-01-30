﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation2.  ISO2002 ID# _QY60W9p-Ed-ak6NoX_4Aeg_-2085094481.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
public partial record AdditionalBalanceInformation2
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required ISubBalanceQuantity1Choice Quantity { get; init; } 
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    public required SecuritiesBalanceType2Code SubBalanceType { get; init; } 
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    public required IsoExtended350Code ExtendedSubBalanceType { get; init; } 
    
    #nullable disable
}
