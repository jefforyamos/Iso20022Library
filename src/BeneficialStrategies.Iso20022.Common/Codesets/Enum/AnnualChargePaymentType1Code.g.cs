﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AnnualChargePaymentType1Code.  ISO2002 ID# _gJ_qoGAPEeiNMJ262H2pWg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how a charge is to be deducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gJ_qoGAPEeiNMJ262H2pWg")]
[Description(@"Specifies how a charge is to be deducted.")]
[DerivedFrom(typeof(AnnualChargePaymentTypeCode))]
public enum AnnualChargePaymentType1Code
{
    /// <summary>
    /// Annual charge is deducted from the fund capital.
    /// Encoded/decoded by serializers as "CAPL".
    /// </summary>
    [EnumMember(Value = "CAPL")]
    [IsoId("_iTTggGAPEeiNMJ262H2pWg")]
    [Description(@"Annual charge is deducted from the fund capital.")]
    Capital = AnnualChargePaymentTypeCode.Capital, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Annual charge is deducted from the fund income.
    /// Encoded/decoded by serializers as "INCO".
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_iXy-8WAPEeiNMJ262H2pWg")]
    [Description(@"Annual charge is deducted from the fund income.")]
    Income = AnnualChargePaymentTypeCode.Income, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AnnualChargePaymentType1CodeMetadataExtensions
{
    private static readonly AnnualChargePaymentType1CodeDropdownSource _dropdownSource = new AnnualChargePaymentType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAnnualChargePaymentType1CodeDropdownRow GetMetadata(this AnnualChargePaymentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


