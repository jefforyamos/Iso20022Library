﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UndertakingNameCode.  ISO2002 ID# _aIyKoHyjEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the named type of the undertaking.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIyKoHyjEeGWJuGCfvwOsQ")]
[Description(@"Specifies the named type of the undertaking.")]
[Derivations(typeof(UndertakingName1Code))]
// External derivations that should be provided by the proper interface are: 
public enum UndertakingNameCode
{
    /// <summary>
    /// Undertaking is a demand guarantee.
    /// Encoded/decoded by serializers as "DGAR".
    /// </summary>
    [EnumMember(Value = "DGAR")]
    [IsoId("_nL0jIHyjEeGWJuGCfvwOsQ")]
    [Description(@"Undertaking is a demand guarantee.")]
    DemandGuarantee,
    
    /// <summary>
    /// Undertaking is a standby letter of credit.
    /// Encoded/decoded by serializers as "STBY".
    /// </summary>
    [EnumMember(Value = "STBY")]
    [IsoId("_tZls8HyjEeGWJuGCfvwOsQ")]
    [Description(@"Undertaking is a standby letter of credit.")]
    StandbyLetterOfCredit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UndertakingNameCodeMetadataExtensions
{
    private static readonly UndertakingNameCodeDropdownSource _dropdownSource = new UndertakingNameCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUndertakingNameCodeDropdownRow GetMetadata(this UndertakingNameCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


