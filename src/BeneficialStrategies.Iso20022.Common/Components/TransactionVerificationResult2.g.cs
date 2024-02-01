﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionVerificationResult2.  ISO2002 ID# _8MCksR2xEeKyZ4l838zwaQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the verifications performed by the issuer to deliver or decline the authorisation.
/// </summary>
public partial record TransactionVerificationResult2
{
    #nullable enable
    
    /// <summary>
    /// Result of an e-commerce authentication process.
    /// </summary>
    public IsoMax500Text? ElectronicCommerceAuthenticationResult { get; init; } 
    /// <summary>
    /// Result of the printed card security code (CSC) validation.
    /// </summary>
    public CSCResult1Code? CSCResult { get; init; } 
    /// <summary>
    /// Result of the cardholder verification address checks on the street number and the postal code.
    /// </summary>
    public CardholderAddressVerificationResult1Code[] CardholderAddressVerificationResult { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    public IsoMax70Text[] DeclinedProductCode { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
