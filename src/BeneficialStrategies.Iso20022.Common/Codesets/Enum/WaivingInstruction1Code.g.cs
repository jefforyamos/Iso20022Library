﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WaivingInstruction1Code.  ISO2002 ID# _Y9k9B9p-Ed-ak6NoX_4Aeg_-1179652008.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the form of the rebate when commission is waived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9k9B9p-Ed-ak6NoX_4Aeg_-1179652008")]
[Description(@"Specifies the form of the rebate when commission is waived.")]
[DerivedFrom(typeof(WaivingInstructionCode))]
public enum WaivingInstruction1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaiveInCash".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y9k9CNp-Ed-ak6NoX_4Aeg_1408944804")]
    [Description(@"??")]
    WaiveInCash,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaiveInUnits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Y9uuANp-Ed-ak6NoX_4Aeg_1408944916")]
    [Description(@"??")]
    WaiveInUnits,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WaivingInstruction1CodeMetadataExtensions
{
    private static readonly WaivingInstruction1CodeDropdownSource _dropdownSource = new WaivingInstruction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWaivingInstruction1CodeDropdownRow GetMetadata(this WaivingInstruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

