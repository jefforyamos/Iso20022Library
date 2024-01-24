﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NovationStatusCode.  ISO2002 ID# _QF-sEMETEea7jLfvGi1PDw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the novation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QF-sEMETEea7jLfvGi1PDw")]
[Description(@"Specifies the status of the novation.")]
[Derivations(typeof(NovationStatus1Code))]
public enum NovationStatusCode
{
    /// <summary>
    /// Transaction is a novation.
    /// Encoded/decoded by serializers as "NOVA".
    /// </summary>
    [EnumMember(Value = "NOVA")]
    [IsoId("_Zd1zUMETEea7jLfvGi1PDw")]
    [Description(@"Transaction is a novation.")]
    Novation,
    
    /// <summary>
    /// Transaction is not a novation.
    /// Encoded/decoded by serializers as "NONO".
    /// </summary>
    [EnumMember(Value = "NONO")]
    [IsoId("_Z1DZcMETEea7jLfvGi1PDw")]
    [Description(@"Transaction is not a novation.")]
    NoNovation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NovationStatusCodeMetadataExtensions
{
    private static readonly NovationStatusCodeDropdownSource _dropdownSource = new NovationStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INovationStatusCodeDropdownRow GetMetadata(this NovationStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


