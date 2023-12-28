﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionRightCode.  ISO2002 ID# __vYmkdojEeC60axPepSq7g_-720567481.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the option rights.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__vYmkdojEeC60axPepSq7g_-720567481")]
[Description(@"Specifies the option rights.")]
public enum OptionRightCode
{
    /// <summary>
    /// Exercise option right.
    /// Encoded/decoded by serializers as "EXER".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("__vYmktojEeC60axPepSq7g_1129606095")]
    [Description(@"Exercise option right.")]
    Exercise,
    
    /// <summary>
    /// Option right assignment.
    /// Encoded/decoded by serializers as "ASGN".
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("__vYmk9ojEeC60axPepSq7g_1685806667")]
    [Description(@"Option right assignment.")]
    Assignment,
    
    /// <summary>
    /// The option right is renounced.
    /// Encoded/decoded by serializers as "RENO".
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("__vYmlNojEeC60axPepSq7g_-1347774066")]
    [Description(@"The option right is renounced.")]
    Renouncement,
    
    /// <summary>
    /// Option right expires.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("__vYmldojEeC60axPepSq7g_764314845")]
    [Description(@"Option right expires.")]
    Expiration,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionRightCodeMetadataExtensions
{
    private static readonly OptionRightCodeDropdownSource _dropdownSource = new OptionRightCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionRightCodeDropdownRow GetMetadata(this OptionRightCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


