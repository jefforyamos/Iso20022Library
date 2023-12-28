﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NonEquityAssetClassCode.  ISO2002 ID# _9f_awHBYEeqTZuDtO9NgaQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the asset class of a non-equity financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9f_awHBYEeqTZuDtO9NgaQ")]
[Description(@"Specifies the asset class of a non-equity financial instrument.")]
public enum NonEquityAssetClassCode
{
    /// <summary>
    /// Interest rate derivative.
    /// Encoded/decoded by serializers as "IRDV".
    /// </summary>
    [EnumMember(Value = "IRDV")]
    [IsoId("_rG2DwHBZEeqTZuDtO9NgaQ")]
    [Description(@"Interest rate derivative.")]
    InterestRateDerivative,
    
    /// <summary>
    /// Equity derivative.
    /// Encoded/decoded by serializers as "EQDV".
    /// </summary>
    [EnumMember(Value = "EQDV")]
    [IsoId("_vfkXgHBZEeqTZuDtO9NgaQ")]
    [Description(@"Equity derivative.")]
    EquityDerivative,
    
    /// <summary>
    /// Commodity derivative.
    /// Encoded/decoded by serializers as "COMD".
    /// </summary>
    [EnumMember(Value = "COMD")]
    [IsoId("_17-aQHBZEeqTZuDtO9NgaQ")]
    [Description(@"Commodity derivative.")]
    CommodityDerivative,
    
    /// <summary>
    /// Foreign exchange derivative.
    /// Encoded/decoded by serializers as "FEXD".
    /// </summary>
    [EnumMember(Value = "FEXD")]
    [IsoId("_4iFg4HBZEeqTZuDtO9NgaQ")]
    [Description(@"Foreign exchange derivative.")]
    ForeignExchangeDerivative,
    
    /// <summary>
    /// Credit derivative.
    /// Encoded/decoded by serializers as "CRDV".
    /// </summary>
    [EnumMember(Value = "CRDV")]
    [IsoId("__v6ZgHBZEeqTZuDtO9NgaQ")]
    [Description(@"Credit derivative.")]
    CreditDerivative,
    
    /// <summary>
    /// C10 derivative.
    /// Encoded/decoded by serializers as "C10D".
    /// </summary>
    [EnumMember(Value = "C10D")]
    [IsoId("_CVFE8HBaEeqTZuDtO9NgaQ")]
    [Description(@"C10 derivative.")]
    C10Derivative,
    
    /// <summary>
    /// Contract for difference.
    /// Encoded/decoded by serializers as "CFDS".
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_Ev3FUHBaEeqTZuDtO9NgaQ")]
    [Description(@"Contract for difference.")]
    ContractForDifference,
    
    /// <summary>
    /// Emission allowance.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_G3tioHBaEeqTZuDtO9NgaQ")]
    [Description(@"Emission allowance.")]
    EmissionAllowance,
    
    /// <summary>
    /// Emission allowance derivative.
    /// Encoded/decoded by serializers as "EADV".
    /// </summary>
    [EnumMember(Value = "EADV")]
    [IsoId("_KNbhQHBaEeqTZuDtO9NgaQ")]
    [Description(@"Emission allowance derivative.")]
    EmissionAllowanceDerivative,
    
    /// <summary>
    /// Securitised derivative.
    /// Encoded/decoded by serializers as "SDRV".
    /// </summary>
    [EnumMember(Value = "SDRV")]
    [IsoId("_Ng75YHBaEeqTZuDtO9NgaQ")]
    [Description(@"Securitised derivative.")]
    SecuritisedDerivative,
    
    /// <summary>
    /// Bond.
    /// Encoded/decoded by serializers as "BOND".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_vN9uEIR5EeqOnqlbcclX_g")]
    [Description(@"Bond.")]
    Bond,
    
    /// <summary>
    /// Exchange traded commodities.
    /// Encoded/decoded by serializers as "ETCS".
    /// </summary>
    [EnumMember(Value = "ETCS")]
    [IsoId("_C1r7kIR6EeqOnqlbcclX_g")]
    [Description(@"Exchange traded commodities.")]
    ExchangeTradedCommodities,
    
    /// <summary>
    /// Exchange traded note.
    /// Encoded/decoded by serializers as "ETNS".
    /// </summary>
    [EnumMember(Value = "ETNS")]
    [IsoId("_FHQVkIR6EeqOnqlbcclX_g")]
    [Description(@"Exchange traded note.")]
    ExchangeTradedNote,
    
    /// <summary>
    /// Structured finance product.
    /// Encoded/decoded by serializers as "SFPS".
    /// </summary>
    [EnumMember(Value = "SFPS")]
    [IsoId("_etfI4IR6EeqOnqlbcclX_g")]
    [Description(@"Structured finance product.")]
    StructuredFinanceProduct,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NonEquityAssetClassCodeMetadataExtensions
{
    private static readonly NonEquityAssetClassCodeDropdownSource _dropdownSource = new NonEquityAssetClassCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INonEquityAssetClassCodeDropdownRow GetMetadata(this NonEquityAssetClassCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

