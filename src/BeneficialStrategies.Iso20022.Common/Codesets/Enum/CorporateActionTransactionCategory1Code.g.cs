﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionTransactionCategory1Code.  ISO2002 ID# _11C9wDL3EeKU9IrkkToqcw_485268367.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11C9wDL3EeKU9IrkkToqcw_485268367")]
[Description(@"Specifies the transaction category to which the corporate action event type belongs to for reporting purposes.")]
[DerivedFrom(typeof(CorporateActionTransactionCategoryCode))]
public enum CorporateActionTransactionCategory1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11C9wTL3EeKU9IrkkToqcw_-892482550")]
    [Description(@"??")]
    CashDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnitInvestmentTrustSecurity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11C9wjL3EeKU9IrkkToqcw_-306535524")]
    [Description(@"??")]
    UnitInvestmentTrustSecurity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PassThrough".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11C9wzL3EeKU9IrkkToqcw_-725069114")]
    [Description(@"??")]
    PassThrough,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorporateBond".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11C9xDL3EeKU9IrkkToqcw_-1360100960")]
    [Description(@"??")]
    CorporateBond,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MunicipalBond".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11C9xTL3EeKU9IrkkToqcw_107047803")]
    [Description(@"??")]
    MunicipalBond,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockDistribution".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11C9xjL3EeKU9IrkkToqcw_-282080622")]
    [Description(@"??")]
    StockDistribution,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OptionalDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuwDL3EeKU9IrkkToqcw_1548842547")]
    [Description(@"??")]
    OptionalDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignRecordDateNotice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuwTL3EeKU9IrkkToqcw_2002929816")]
    [Description(@"??")]
    ForeignRecordDateNotice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DividendReinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuwjL3EeKU9IrkkToqcw_-1531272327")]
    [Description(@"??")]
    DividendReinvestment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxExemptDividendService".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuwzL3EeKU9IrkkToqcw_-64123564")]
    [Description(@"??")]
    TaxExemptDividendService,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectRegistrationService".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuxDL3EeKU9IrkkToqcw_-1252003185")]
    [Description(@"??")]
    DirectRegistrationService,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SpecialDistribution".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuxTL3EeKU9IrkkToqcw_-776602817")]
    [Description(@"??")]
    SpecialDistribution,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reorganisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11MuxjL3EeKU9IrkkToqcw_-787701594")]
    [Description(@"??")]
    Reorganisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RecapitalizationRecordDateNotice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11V4sDL3EeKU9IrkkToqcw_1201252015")]
    [Description(@"??")]
    RecapitalizationRecordDateNotice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LiquidationRecordDateNotice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11V4sTL3EeKU9IrkkToqcw_-1626566518")]
    [Description(@"??")]
    LiquidationRecordDateNotice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SalesOfAssetsRecordDateNotice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11V4sjL3EeKU9IrkkToqcw_1461623903")]
    [Description(@"??")]
    SalesOfAssetsRecordDateNotice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RedemptionsRecordDateNotice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_11V4szL3EeKU9IrkkToqcw_151444510")]
    [Description(@"??")]
    RedemptionsRecordDateNotice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionTransactionCategory1CodeMetadataExtensions
{
    private static readonly CorporateActionTransactionCategory1CodeDropdownSource _dropdownSource = new CorporateActionTransactionCategory1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionTransactionCategory1CodeDropdownRow GetMetadata(this CorporateActionTransactionCategory1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


