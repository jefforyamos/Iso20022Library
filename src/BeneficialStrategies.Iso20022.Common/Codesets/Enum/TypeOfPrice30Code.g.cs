﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfPrice30Code.  ISO2002 ID# _m88a4fNBEeCuA5Tr22BnwA_1249105833.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m88a4fNBEeCuA5Tr22BnwA_1249105833")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice30Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m88a4vNBEeCuA5Tr22BnwA_1291473582")]
    [Description(@"??")]
    Bid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Offer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m88a4_NBEeCuA5Tr22BnwA_-1066268541")]
    [Description(@"??")]
    Offer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetAssetValue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m88a5PNBEeCuA5Tr22BnwA_1877420608")]
    [Description(@"??")]
    NetAssetValue,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Creation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m88a5fNBEeCuA5Tr22BnwA_498737665")]
    [Description(@"??")]
    Creation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancellation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL4PNBEeCuA5Tr22BnwA_-1859004458")]
    [Description(@"??")]
    Cancellation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Interim".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL4fNBEeCuA5Tr22BnwA_1259502818")]
    [Description(@"??")]
    Interim,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Swing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL4vNBEeCuA5Tr22BnwA_1248404041")]
    [Description(@"??")]
    Swing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL4_NBEeCuA5Tr22BnwA_1186771133")]
    [Description(@"??")]
    Mid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reinvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL5PNBEeCuA5Tr22BnwA_-761552817")]
    [Description(@"??")]
    Reinvestment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Switch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL5fNBEeCuA5Tr22BnwA_652683805")]
    [Description(@"??")]
    Switch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DailyDividendRate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9GL5vNBEeCuA5Tr22BnwA_-1705058318")]
    [Description(@"??")]
    DailyDividendRate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Actual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9P84PNBEeCuA5Tr22BnwA_-810327413")]
    [Description(@"??")]
    Actual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonAdjustedUnpublished".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9P84fNBEeCuA5Tr22BnwA_912382864")]
    [Description(@"??")]
    NonAdjustedUnpublished,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Guaranteed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9P84vNBEeCuA5Tr22BnwA_1990403202")]
    [Description(@"??")]
    Guaranteed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EstimatedNAV".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9P84_NBEeCuA5Tr22BnwA_-473640925")]
    [Description(@"??")]
    EstimatedNAV,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RedemptionNAV".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9P85PNBEeCuA5Tr22BnwA_-122528641")]
    [Description(@"??")]
    RedemptionNAV,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SubscriptionNAV".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_m9P85fNBEeCuA5Tr22BnwA_320459851")]
    [Description(@"??")]
    SubscriptionNAV,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfPrice30CodeMetadataExtensions
{
    private static readonly TypeOfPrice30CodeDropdownSource _dropdownSource = new TypeOfPrice30CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfPrice30CodeDropdownRow GetMetadata(this TypeOfPrice30Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


