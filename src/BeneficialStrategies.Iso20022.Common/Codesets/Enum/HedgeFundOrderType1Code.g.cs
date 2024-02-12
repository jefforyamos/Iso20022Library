﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HedgeFundOrderType1Code.  ISO2002 ID# _au-pN9p-Ed-ak6NoX_4Aeg_322824759.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_au-pN9p-Ed-ak6NoX_4Aeg_322824759")]
[Description(@"Specifies the type of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum HedgeFundOrderType1Code
{
    /// <summary>
    /// Investment fund order is for a limited partnership instrument.
    /// Encoded/decoded by serializers as "NUNI".
    /// </summary>
    [EnumMember(Value = "NUNI")]
    [IsoId("_au-pONp-Ed-ak6NoX_4Aeg_641436539")]
    [Description(@"Investment fund order is for a limited partnership instrument.")]
    NonUnitized = FundOrderTypeCode.NonUnitized, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order contains a side pocket component.
    /// Encoded/decoded by serializers as "SPCM".
    /// </summary>
    [EnumMember(Value = "SPCM")]
    [IsoId("_avIaMNp-Ed-ak6NoX_4Aeg_641436569")]
    [Description(@"Investment fund order contains a side pocket component.")]
    SidePocketComponent = FundOrderTypeCode.SidePocketComponent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as "BEDB".
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_avIaMdp-Ed-ak6NoX_4Aeg_259859281")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast = FundOrderTypeCode.BedAndBreakfast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a side pocket order.
    /// Encoded/decoded by serializers as "SPOR".
    /// </summary>
    [EnumMember(Value = "SPOR")]
    [IsoId("_avIaMtp-Ed-ak6NoX_4Aeg_641436600")]
    [Description(@"Investment fund order is a side pocket order.")]
    SidePocketOrder = FundOrderTypeCode.SidePocketOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is for a unitized instrument.
    /// Encoded/decoded by serializers as "UNIT".
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_avIaM9p-Ed-ak6NoX_4Aeg_641436692")]
    [Description(@"Investment fund order is for a unitized instrument.")]
    Unitized = FundOrderTypeCode.Unitized, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order specifies a top up.
    /// Encoded/decoded by serializers as "TOPU".
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_avIaNNp-Ed-ak6NoX_4Aeg_1021792701")]
    [Description(@"Investment fund order specifies a top up.")]
    TopUp = FundOrderTypeCode.TopUp, // same ordinal as derivation source for type conversions
    
}
