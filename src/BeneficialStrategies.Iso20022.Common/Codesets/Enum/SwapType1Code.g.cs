﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SwapType1Code.  ISO2002 ID# _h8h1ECS1EeWsI5Sp3-B3zg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h8h1ECS1EeWsI5Sp3-B3zg")]
[Description(@"Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.")]
[DerivedFrom(typeof(SwapTypeCode))]
public enum SwapType1Code
{
    /// <summary>
    /// Overnight Index Single Currency Swap.
    /// Encoded/decoded by serializers as "OvernightIndexSingleCurrencySwap".
    /// </summary>
    [EnumMember(Value = "OSSC")]
    [IsoId("_jZap0SS1EeWsI5Sp3-B3zg")]
    [Description(@"Overnight Index Single Currency Swap.")]
    OvernightIndexSingleCurrencySwap,
    
    /// <summary>
    /// Fixed to Float Single Currency Swap.
    /// Encoded/decoded by serializers as "FixedToFloatSingleCurrencySwap".
    /// </summary>
    [EnumMember(Value = "XFSC")]
    [IsoId("_j4gZkSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Float Single Currency Swap.")]
    FixedToFloatSingleCurrencySwap,
    
    /// <summary>
    /// Fixed to Float Multi Currency Swap.
    /// Encoded/decoded by serializers as "FixedToFloatMultiCurrencySwap".
    /// </summary>
    [EnumMember(Value = "XFMC")]
    [IsoId("_j-IgcSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Float Multi Currency Swap.")]
    FixedToFloatMultiCurrencySwap,
    
    /// <summary>
    /// Fixed to Fixed Single Currency Swap.
    /// Encoded/decoded by serializers as "FixedToFixedSingleCurrencySwap".
    /// </summary>
    [EnumMember(Value = "XXSC")]
    [IsoId("_kC_yUSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Fixed Single Currency Swap.")]
    FixedToFixedSingleCurrencySwap,
    
    /// <summary>
    /// Fixed to Fixed Multi Currency Swap.
    /// Encoded/decoded by serializers as "FixedToFixedMultiCurrencySwap".
    /// </summary>
    [EnumMember(Value = "XXMC")]
    [IsoId("_kSQWUSS1EeWsI5Sp3-B3zg")]
    [Description(@"Fixed to Fixed Multi Currency Swap.")]
    FixedToFixedMultiCurrencySwap,
    
    /// <summary>
    /// Inflation Multi Currency Swap.
    /// Encoded/decoded by serializers as "InflationMultiCurrencySwap".
    /// </summary>
    [EnumMember(Value = "IFMC")]
    [IsoId("_k1EIcSS1EeWsI5Sp3-B3zg")]
    [Description(@"Inflation Multi Currency Swap.")]
    InflationMultiCurrencySwap,
    
    /// <summary>
    /// Float to Float Single Currency Swap.
    /// Encoded/decoded by serializers as "FloatToFloatSingleCurrencySwap".
    /// </summary>
    [EnumMember(Value = "FFSC")]
    [IsoId("_lOVkESS1EeWsI5Sp3-B3zg")]
    [Description(@"Float to Float Single Currency Swap.")]
    FloatToFloatSingleCurrencySwap,
    
    /// <summary>
    /// Float to Float Multi Currency Swap.
    /// Encoded/decoded by serializers as "FloatToFloatMultiCurrencySwap".
    /// </summary>
    [EnumMember(Value = "FFMC")]
    [IsoId("_lTAosSS1EeWsI5Sp3-B3zg")]
    [Description(@"Float to Float Multi Currency Swap.")]
    FloatToFloatMultiCurrencySwap,
    
    /// <summary>
    /// Inflation Single Currency Swap.
    /// Encoded/decoded by serializers as "InflationSingleCurrencySwap".
    /// </summary>
    [EnumMember(Value = "IFSC")]
    [IsoId("_l9cs0SS1EeWsI5Sp3-B3zg")]
    [Description(@"Inflation Single Currency Swap.")]
    InflationSingleCurrencySwap,
    
    /// <summary>
    /// Overnight Index Multi Currency Swap.
    /// Encoded/decoded by serializers as "OvernightIndexMultiCurrencySwap".
    /// </summary>
    [EnumMember(Value = "OSMC")]
    [IsoId("_mCT-sSS1EeWsI5Sp3-B3zg")]
    [Description(@"Overnight Index Multi Currency Swap.")]
    OvernightIndexMultiCurrencySwap,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SwapType1CodeMetadataExtensions
{
    private static readonly SwapType1CodeDropdownSource _dropdownSource = new SwapType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISwapType1CodeDropdownRow GetMetadata(this SwapType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


