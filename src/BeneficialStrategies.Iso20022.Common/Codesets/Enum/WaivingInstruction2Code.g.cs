﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WaivingInstruction2Code.  ISO2002 ID# _Vg5axdp-Ed-ak6NoX_4Aeg_-689701583.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the form of the rebate when commission is waived.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vg5axdp-Ed-ak6NoX_4Aeg_-689701583")]
[Description(@"Specifies the form of the rebate when commission is waived.")]
[DerivedFrom(typeof(WaivingInstructionCode))]
public enum WaivingInstruction2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaiveInCash".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vg5axtp-Ed-ak6NoX_4Aeg_-646298105")]
    [Description(@"??")]
    WaiveInCash,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WaiveInUnits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vg5ax9p-Ed-ak6NoX_4Aeg_-633369743")]
    [Description(@"??")]
    WaiveInUnits,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vg5ayNp-Ed-ak6NoX_4Aeg_-312488315")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WaivingInstruction2CodeMetadataExtensions
{
    private static readonly WaivingInstruction2CodeDropdownSource _dropdownSource = new WaivingInstruction2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWaivingInstruction2CodeDropdownRow GetMetadata(this WaivingInstruction2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


