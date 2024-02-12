﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WaivingInstruction2Code.  ISO2002 ID# _Vg5axdp-Ed-ak6NoX_4Aeg_-689701583.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Form of commission waived is cash.
    /// Encoded/decoded by serializers as "WICA".
    /// </summary>
    [EnumMember(Value = "WICA")]
    [IsoId("_Vg5axtp-Ed-ak6NoX_4Aeg_-646298105")]
    [Description(@"Form of commission waived is cash.")]
    WaiveInCash = WaivingInstructionCode.WaiveInCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Form of commission waived is additional units of a financial instrument.
    /// Encoded/decoded by serializers as "WIUN".
    /// </summary>
    [EnumMember(Value = "WIUN")]
    [IsoId("_Vg5ax9p-Ed-ak6NoX_4Aeg_-633369743")]
    [Description(@"Form of commission waived is additional units of a financial instrument.")]
    WaiveInUnits = WaivingInstructionCode.WaiveInUnits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another type of commission waiving.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vg5ayNp-Ed-ak6NoX_4Aeg_-312488315")]
    [Description(@"Another type of commission waiving.")]
    Other = WaivingInstructionCode.Other, // same ordinal as derivation source for type conversions
    
}
