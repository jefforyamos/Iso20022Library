﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MergerCode.  ISO2002 ID# _tnAmA1OzEeGs_NnqHXQZkw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classification of the regulatory condition of a merger for the TSE/JASDEC extension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tnAmA1OzEeGs_NnqHXQZkw")]
[Description(@"Classification of the regulatory condition of a merger for the TSE/JASDEC extension.")]
public enum MergerCode
{
    /// <summary>
    /// The merger regulatory condition is unknown.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_98CTsFOzEeGs_NnqHXQZkw")]
    [Description(@"The merger regulatory condition is unknown.")]
    MergerClassificationIsUnknown,
    
    /// <summary>
    /// The merger regulatory condition is: no general shareholders meeting at discontinued company or subsidiary to be acquired.
    /// Encoded/decoded by serializers as "OMIT".
    /// </summary>
    [EnumMember(Value = "OMIT")]
    [IsoId("__x6QMFOzEeGs_NnqHXQZkw")]
    [Description(@"The merger regulatory condition is: no general shareholders meeting at discontinued company or subsidiary to be acquired.")]
    NoGeneralShareholdersMeeting,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MergerCodeMetadataExtensions
{
    private static readonly MergerCodeDropdownSource _dropdownSource = new MergerCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMergerCodeDropdownRow GetMetadata(this MergerCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


