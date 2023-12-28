﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionPayoutTypeCode.  ISO2002 ID# _paSd4abDEeSxuMLA5o46jQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of payout that will result from an in-the-money option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_paSd4abDEeSxuMLA5o46jQ")]
[Description(@"Indicates the type of payout that will result from an in-the-money option.")]
public enum OptionPayoutTypeCode
{
    /// <summary>
    /// Indicates the type of vanilla option.
    /// Encoded/decoded by serializers as "VANI".
    /// </summary>
    [EnumMember(Value = "VANI")]
    [IsoId("_dV968KbEEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of vanilla option.")]
    Vanilla,
    
    /// <summary>
    /// Indicates the type of capped option.
    /// Encoded/decoded by serializers as "CAPP".
    /// </summary>
    [EnumMember(Value = "CAPP")]
    [IsoId("_dhVdcKbEEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of capped option.")]
    Capped,
    
    /// <summary>
    /// Indicates the type of binaryoption.
    /// Encoded/decoded by serializers as "BINA".
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_dlwqcKbEEeSxuMLA5o46jQ")]
    [Description(@"Indicates the type of binaryoption.")]
    Binary,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionPayoutTypeCodeMetadataExtensions
{
    private static readonly OptionPayoutTypeCodeDropdownSource _dropdownSource = new OptionPayoutTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionPayoutTypeCodeDropdownRow GetMetadata(this OptionPayoutTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

