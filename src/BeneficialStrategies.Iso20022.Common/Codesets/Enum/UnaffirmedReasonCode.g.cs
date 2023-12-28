﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnaffirmedReasonCode.  ISO2002 ID# __qxMVNojEeC60axPepSq7g_1753446814.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__qxMVNojEeC60axPepSq7g_1753446814")]
[Description(@"Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.")]
[Derivations(typeof(UnaffirmedReason1Code))]
// External derivations that should be provided by the proper interface are: 
public enum UnaffirmedReasonCode
{
    /// <summary>
    /// Specifies the reason the counterparty has not affirmed.
    /// Encoded/decoded by serializers as "NAFF".
    /// </summary>
    [EnumMember(Value = "NAFF")]
    [IsoId("__q6WQNojEeC60axPepSq7g_1606974359")]
    [Description(@"Specifies the reason the counterparty has not affirmed.")]
    CounterpartyNotAffirmed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnaffirmedReasonCodeMetadataExtensions
{
    private static readonly UnaffirmedReasonCodeDropdownSource _dropdownSource = new UnaffirmedReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnaffirmedReasonCodeDropdownRow GetMetadata(this UnaffirmedReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


