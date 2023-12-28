﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RegistrationProcessingStatusCode.  ISO2002 ID# _ZbFYY9p-Ed-ak6NoX_4Aeg_-770609526.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the registration processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZbFYY9p-Ed-ak6NoX_4Aeg_-770609526")]
[Description(@"Specifies the status of the registration processing.")]
[Derivations(typeof(RegistrationProcessingStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum RegistrationProcessingStatusCode
{
    /// <summary>
    /// Registration has been acknowledged/accepted by the issuer/registrar.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZbFYZNp-Ed-ak6NoX_4Aeg_-713352141")]
    [Description(@"Registration has been acknowledged/accepted by the issuer/registrar.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Registration has been rejected by the issuer/registrar.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZbFYZdp-Ed-ak6NoX_4Aeg_-712428249")]
    [Description(@"Registration has been rejected by the issuer/registrar.")]
    Rejected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RegistrationProcessingStatusCodeMetadataExtensions
{
    private static readonly RegistrationProcessingStatusCodeDropdownSource _dropdownSource = new RegistrationProcessingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRegistrationProcessingStatusCodeDropdownRow GetMetadata(this RegistrationProcessingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


