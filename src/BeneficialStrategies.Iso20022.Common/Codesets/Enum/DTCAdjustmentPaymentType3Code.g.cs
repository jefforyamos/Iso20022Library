﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCAdjustmentPaymentType3Code.  ISO2002 ID# _RYe2wJ6BEeW1p8WuttdPEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RYe2wJ6BEeW1p8WuttdPEw")]
[Description(@"Specifies the type of the payment adjustment.")]
[DerivedFrom(typeof(DTCAdjustmentPaymentTypeV2Code))]
public enum DTCAdjustmentPaymentType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FailSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dpHh8Z6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    FailSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MiscellaneousSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ecv-UZ6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    MiscellaneousSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepoSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_fUYw8Z6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    RepoSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockLoanSettlement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_gEcU4Z6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    StockLoanSettlement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReorganisationDepositPhaseOne".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_h8zksZ6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    ReorganisationDepositPhaseOne,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ReorgDepositPhaseTwo".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iOXOwZ6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    ReorgDepositPhaseTwo,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CustodyReorganizationDeposit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_lckQIZ6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    CustodyReorganizationDeposit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DynamicRateChange".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mp7bIZ6BEeW1p8WuttdPEw")]
    [Description(@"??")]
    DynamicRateChange,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCAdjustmentPaymentType3CodeMetadataExtensions
{
    private static readonly DTCAdjustmentPaymentType3CodeDropdownSource _dropdownSource = new DTCAdjustmentPaymentType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCAdjustmentPaymentType3CodeDropdownRow GetMetadata(this DTCAdjustmentPaymentType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

