﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionRight1Code.  ISO2002 ID# __vPcotojEeC60axPepSq7g_-921943396.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the option rights.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__vPcotojEeC60axPepSq7g_-921943396")]
[Description(@"Specifies the option rights.")]
[DerivedFrom(typeof(OptionRightCode))]
public enum OptionRight1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Exercise".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__vPco9ojEeC60axPepSq7g_-581695193")]
    [Description(@"??")]
    Exercise,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Assignment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__vPcpNojEeC60axPepSq7g_-1981917652")]
    [Description(@"??")]
    Assignment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Renouncement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__vPcpdojEeC60axPepSq7g_-1993016429")]
    [Description(@"??")]
    Renouncement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Expiration".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__vYmkNojEeC60axPepSq7g_-525867666")]
    [Description(@"??")]
    Expiration,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionRight1CodeMetadataExtensions
{
    private static readonly OptionRight1CodeDropdownSource _dropdownSource = new OptionRight1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionRight1CodeDropdownRow GetMetadata(this OptionRight1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

