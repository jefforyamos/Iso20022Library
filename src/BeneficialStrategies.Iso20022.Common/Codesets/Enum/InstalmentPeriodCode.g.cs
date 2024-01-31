﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstalmentPeriodCode.  ISO2002 ID# _ji4689uTEei2qvU6FBLZYA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instalment period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ji4689uTEei2qvU6FBLZYA")]
[Description(@"Instalment period.")]
[Derivations(typeof(InstalmentPeriod1Code))]
public enum InstalmentPeriodCode
{
    /// <summary>
    /// Monthly instalment period.
    /// Encoded/decoded by serializers as "MNTH".
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_ji469duTEei2qvU6FBLZYA")]
    [Description(@"Monthly instalment period.")]
    Monthly,
    
    /// <summary>
    /// Annual instalment period.
    /// Encoded/decoded by serializers as "ANNU".
    /// </summary>
    [EnumMember(Value = "ANNU")]
    [IsoId("_ji469NuTEei2qvU6FBLZYA")]
    [Description(@"Annual instalment period.")]
    Annual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstalmentPeriodCodeMetadataExtensions
{
    private static readonly InstalmentPeriodCodeDropdownSource _dropdownSource = new InstalmentPeriodCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstalmentPeriodCodeDropdownRow GetMetadata(this InstalmentPeriodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


