﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommissionType9Code.  ISO2002 ID# __1f1pNojEeC60axPepSq7g_1349927182.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1f1pNojEeC60axPepSq7g_1349927182")]
[Description(@"Type of service for which the commission is asked or paid.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClientDirected".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1f1pdojEeC60axPepSq7g_1512056713")]
    [Description(@"??")]
    ClientDirected,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StepOut".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1f1ptojEeC60axPepSq7g_-1258842287")]
    [Description(@"??")]
    StepOut,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SoftDollar".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmoNojEeC60axPepSq7g_1775834527")]
    [Description(@"??")]
    SoftDollar,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PercentageOfPrincipal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmodojEeC60axPepSq7g_873266936")]
    [Description(@"??")]
    PercentageOfPrincipal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FlatFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmotojEeC60axPepSq7g_1287212868")]
    [Description(@"??")]
    FlatFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmo9ojEeC60axPepSq7g_1438210713")]
    [Description(@"??")]
    PerUnit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PercentageCommissionWaivedAsCashDiscount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmpNojEeC60axPepSq7g_-1332688287")]
    [Description(@"??")]
    PercentageCommissionWaivedAsCashDiscount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PercentageCommissionWaivedAsAdditionalUnits".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmpdojEeC60axPepSq7g_366205654")]
    [Description(@"??")]
    PercentageCommissionWaivedAsAdditionalUnits,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BrokerageRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1pmptojEeC60axPepSq7g_970428610")]
    [Description(@"??")]
    BrokerageRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DifferentialOrDeferredPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1ywkNojEeC60axPepSq7g_1148547282")]
    [Description(@"??")]
    DifferentialOrDeferredPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PointsPerBondOrContract".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__1ywkdojEeC60axPepSq7g_278267935")]
    [Description(@"??")]
    PointsPerBondOrContract,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommissionType9CodeMetadataExtensions
{
    private static readonly CommissionType9CodeDropdownSource _dropdownSource = new CommissionType9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommissionType9CodeDropdownRow GetMetadata(this CommissionType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

