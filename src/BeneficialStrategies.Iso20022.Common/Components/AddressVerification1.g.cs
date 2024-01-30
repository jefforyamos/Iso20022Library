﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AddressVerification1.  ISO2002 ID# _SqbqxgEcEeCQm6a_G2yO_w_1267025270.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric characters of the cardholder's address for verification.
/// </summary>
public partial record AddressVerification1
{
    #nullable enable
    
    /// <summary>
    /// Numeric characters from the cardholder's address excluding the postal code (that is street number).
    /// </summary>
    public IsoMax5NumericText? AddressDigits { get; init; } 
    /// <summary>
    /// Numeric characters from the cardholder's postal code.
    /// </summary>
    public IsoMax5NumericText? PostalCodeDigits { get; init; } 
    
    #nullable disable
}
