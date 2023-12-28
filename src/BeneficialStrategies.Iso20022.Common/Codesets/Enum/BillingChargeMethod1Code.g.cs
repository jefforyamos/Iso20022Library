﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BillingChargeMethod1Code.  ISO2002 ID# _6Ukd9pqlEeGSON8vddiWzQ_1265216021.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how the billing charge is calculated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Ukd9pqlEeGSON8vddiWzQ_1265216021")]
[Description(@"Defines how the billing charge is calculated.")]
[DerivedFrom(typeof(BillingChargeMethodCode))]
public enum BillingChargeMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnitPriced".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6Ukd95qlEeGSON8vddiWzQ_-840350178")]
    [Description(@"??")]
    UnitPriced,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StampDuty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6Ukd-JqlEeGSON8vddiWzQ_1610748129")]
    [Description(@"??")]
    StampDuty,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BaseCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO8JqlEeGSON8vddiWzQ_-1217070404")]
    [Description(@"??")]
    BaseCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DiscountPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO8ZqlEeGSON8vddiWzQ_2064835398")]
    [Description(@"??")]
    DiscountPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FlatCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO8pqlEeGSON8vddiWzQ_2053736621")]
    [Description(@"??")]
    FlatCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ListPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO85qlEeGSON8vddiWzQ_361556424")]
    [Description(@"??")]
    ListPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumCharge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO9JqlEeGSON8vddiWzQ_1828705187")]
    [Description(@"??")]
    MinimumCharge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MaximumReduction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO9ZqlEeGSON8vddiWzQ_815643693")]
    [Description(@"??")]
    MaximumReduction,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO9pqlEeGSON8vddiWzQ_804544916")]
    [Description(@"??")]
    Tier1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO95qlEeGSON8vddiWzQ_-766551424")]
    [Description(@"??")]
    Tier2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6UuO-JqlEeGSON8vddiWzQ_1601332259")]
    [Description(@"??")]
    Tier3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier4".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y4JqlEeGSON8vddiWzQ_337586552")]
    [Description(@"??")]
    Tier4,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier5".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y4ZqlEeGSON8vddiWzQ_446377247")]
    [Description(@"??")]
    Tier5,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier6".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y4pqlEeGSON8vddiWzQ_-1049352499")]
    [Description(@"??")]
    Tier6,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier7".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y45qlEeGSON8vddiWzQ_-654755907")]
    [Description(@"??")]
    Tier7,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier8".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y5JqlEeGSON8vddiWzQ_897527195")]
    [Description(@"??")]
    Tier8,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tier9".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y5ZqlEeGSON8vddiWzQ_1233780089")]
    [Description(@"??")]
    Tier9,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThresholdPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y5pqlEeGSON8vddiWzQ_1855677988")]
    [Description(@"??")]
    ThresholdPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ZonePrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y55qlEeGSON8vddiWzQ_-972140545")]
    [Description(@"??")]
    ZonePrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BalanceBased".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6U3Y6JqlEeGSON8vddiWzQ_11808999")]
    [Description(@"??")]
    BalanceBased,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BillingChargeMethod1CodeMetadataExtensions
{
    private static readonly BillingChargeMethod1CodeDropdownSource _dropdownSource = new BillingChargeMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBillingChargeMethod1CodeDropdownRow GetMetadata(this BillingChargeMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


