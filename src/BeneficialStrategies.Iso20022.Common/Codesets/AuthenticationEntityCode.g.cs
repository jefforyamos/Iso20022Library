﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationEntityCode.  ISO2002 ID# _TVyU7AEcEeCQm6a_G2yO_w_1327141076.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity or object in charge of verifying the cardholder authenticity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVyU7AEcEeCQm6a_G2yO_w_1327141076")]
[Description(@"Entity or object in charge of verifying the cardholder authenticity.")]
[Derivations(typeof(AuthenticationEntity1Code),typeof(AuthenticationEntity2Code))]
public enum AuthenticationEntityCode
{
    /// <summary>
    /// Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification.
    /// Encoded/decoded by serializers as &quot;ICCD&quot;.
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_TVyU7QEcEeCQm6a_G2yO_w_-682815782")]
    [Description(@"Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification.")]
    ICC,
    
    /// <summary>
    /// Authorisation agent of the issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_TVyU7gEcEeCQm6a_G2yO_w_-1994710956")]
    [Description(@"Authorisation agent of the issuer.")]
    AuthorisedAgent,
    
    /// <summary>
    /// Merchant (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TVyU7wEcEeCQm6a_G2yO_w_1584042948")]
    [Description(@"Merchant (for example signature verification by the attendant).")]
    Merchant,
    
    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_kbETQGjoEeSDR-pyia6Xtg")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer,
    
    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_m_2kMGjoEeSDR-pyia6Xtg")]
    [Description(@"Card issuer.")]
    Issuer,
    
    /// <summary>
    /// Secure application in the terminal.
    /// Encoded/decoded by serializers as &quot;TRML&quot;.
    /// </summary>
    [EnumMember(Value = "TRML")]
    [IsoId("_sEs-IGjoEeSDR-pyia6Xtg")]
    [Description(@"Secure application in the terminal.")]
    Terminal,
    
}
