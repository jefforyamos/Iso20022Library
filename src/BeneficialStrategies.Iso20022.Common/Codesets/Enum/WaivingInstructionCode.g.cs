﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WaivingInstructionCode.  ISO2002 ID# _Y9uuAdp-Ed-ak6NoX_4Aeg_-1758874043.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the form of the rebate when commission is waived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9uuAdp-Ed-ak6NoX_4Aeg_-1758874043")]
[Description(@"Specifies the form of the rebate when commission is waived.")]
[Derivations(typeof(WaivingInstruction2Code),typeof(WaivingInstruction1Code))]
// External derivations that should be provided by the proper interface are: 
public enum WaivingInstructionCode
{
    /// <summary>
    /// Form of commission waived is cash.
    /// Encoded/decoded by serializers as "WICA".
    /// </summary>
    [EnumMember(Value = "WICA")]
    [IsoId("_Y9uuAtp-Ed-ak6NoX_4Aeg_165921005")]
    [Description(@"Form of commission waived is cash.")]
    WaiveInCash,
    
    /// <summary>
    /// Form of commission waived is additional units of a financial instrument.
    /// Encoded/decoded by serializers as "WIUN".
    /// </summary>
    [EnumMember(Value = "WIUN")]
    [IsoId("_Y9uuA9p-Ed-ak6NoX_4Aeg_633220258")]
    [Description(@"Form of commission waived is additional units of a financial instrument.")]
    WaiveInUnits,
    
    /// <summary>
    /// Another type of commission waiving.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Y9uuBNp-Ed-ak6NoX_4Aeg_-268156093")]
    [Description(@"Another type of commission waiving.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WaivingInstructionCodeMetadataExtensions
{
    private static readonly WaivingInstructionCodeDropdownSource _dropdownSource = new WaivingInstructionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWaivingInstructionCodeDropdownRow GetMetadata(this WaivingInstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


