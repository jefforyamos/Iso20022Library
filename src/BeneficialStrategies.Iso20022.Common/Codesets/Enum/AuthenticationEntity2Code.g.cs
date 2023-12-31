﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationEntity2Code.  ISO2002 ID# _arLtkWjoEeSDR-pyia6Xtg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity or device that has performed the verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_arLtkWjoEeSDR-pyia6Xtg")]
[Description(@"Entity or device that has performed the verification.")]
[DerivedFrom(typeof(AuthenticationEntityCode))]
public enum AuthenticationEntity2Code
{
    /// <summary>
    /// Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification.
    /// Encoded/decoded by serializers as "ICC".
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_a4ZqMWjoEeSDR-pyia6Xtg")]
    [Description(@"Application in the chip card (Integrated Circuit Card), for instance an offline PIN verification.")]
    ICC,
    
    /// <summary>
    /// Authorisation agent of the issuer.
    /// Encoded/decoded by serializers as "AuthorisedAgent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_a4ZqM2joEeSDR-pyia6Xtg")]
    [Description(@"Authorisation agent of the issuer.")]
    AuthorisedAgent,
    
    /// <summary>
    /// Merchant (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as "Merchant".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_a4ZqNWjoEeSDR-pyia6Xtg")]
    [Description(@"Merchant (for example signature verification by the attendant).")]
    Merchant,
    
    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_xWp_8WjoEeSDR-pyia6Xtg")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer,
    
    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as "Issuer".
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_xlWjQWjoEeSDR-pyia6Xtg")]
    [Description(@"Card issuer.")]
    Issuer,
    
    /// <summary>
    /// Secure application in the terminal.
    /// Encoded/decoded by serializers as "Terminal".
    /// </summary>
    [EnumMember(Value = "TRML")]
    [IsoId("_xytCwWjoEeSDR-pyia6Xtg")]
    [Description(@"Secure application in the terminal.")]
    Terminal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationEntity2CodeMetadataExtensions
{
    private static readonly AuthenticationEntity2CodeDropdownSource _dropdownSource = new AuthenticationEntity2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationEntity2CodeDropdownRow GetMetadata(this AuthenticationEntity2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


