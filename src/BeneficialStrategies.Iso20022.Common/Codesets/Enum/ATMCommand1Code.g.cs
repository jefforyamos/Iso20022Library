﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMCommand1Code.  ISO2002 ID# _FHH00IqKEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of command to be performed by an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FHH00IqKEeSRT5rEzcAHEw")]
[Description(@"Type of command to be performed by an ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ATMBalance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LkXlEYqKEeSRT5rEzcAHEw")]
    [Description(@"??")]
    ATMBalance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ATMStatusUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LpbrQYqKEeSRT5rEzcAHEw")]
    [Description(@"??")]
    ATMStatusUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConfigurationUpdate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LuM2gYqKEeSRT5rEzcAHEw")]
    [Description(@"??")]
    ConfigurationUpdate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CountersInquiry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_L0KUkYqKEeSRT5rEzcAHEw")]
    [Description(@"??")]
    CountersInquiry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Disconnect".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_L47f0YqKEeSRT5rEzcAHEw")]
    [Description(@"??")]
    Disconnect,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SendMessage".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_L9_mAYqKEeSRT5rEzcAHEw")]
    [Description(@"??")]
    SendMessage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMCommand1CodeMetadataExtensions
{
    private static readonly ATMCommand1CodeDropdownSource _dropdownSource = new ATMCommand1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMCommand1CodeDropdownRow GetMetadata(this ATMCommand1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

