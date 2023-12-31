﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory7Code.  ISO2002 ID# _uif28In9EeShMpas3885ww.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of an ATM configuration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uif28In9EeShMpas3885ww")]
[Description(@"Type of an ATM configuration.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory7Code
{
    /// <summary>
    /// Configuration parameters of the ATM.
    /// Encoded/decoded by serializers as "ATMConfiguration".
    /// </summary>
    [EnumMember(Value = "ATMC")]
    [IsoId("_2KOdUYn9EeShMpas3885ww")]
    [Description(@"Configuration parameters of the ATM.")]
    ATMConfiguration,
    
    /// <summary>
    /// ATM protocol parameters, including the configuration of the hosts.
    /// Encoded/decoded by serializers as "ATMProtocol".
    /// </summary>
    [EnumMember(Value = "ATMP")]
    [IsoId("_2RPEQ4n9EeShMpas3885ww")]
    [Description(@"ATM protocol parameters, including the configuration of the hosts.")]
    ATMProtocol,
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_6zEQs4n9EeShMpas3885ww")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters,
    
    /// <summary>
    /// Configuration parameters of the card application.
    /// Encoded/decoded by serializers as "CardApplication".
    /// </summary>
    [EnumMember(Value = "CRAP")]
    [IsoId("__QYwk4n9EeShMpas3885ww")]
    [Description(@"Configuration parameters of the card application.")]
    CardApplication,
    
    /// <summary>
    /// Configuration of the cards accepted by the terminal.
    /// Encoded/decoded by serializers as "CardConfiguration".
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("__XsSc4n9EeShMpas3885ww")]
    [Description(@"Configuration of the cards accepted by the terminal.")]
    CardConfiguration,
    
    /// <summary>
    /// Local rates for currency exchanges.
    /// Encoded/decoded by serializers as "OfflineExchangeRate".
    /// </summary>
    [EnumMember(Value = "OEXR")]
    [IsoId("_As9cQ4n-EeShMpas3885ww")]
    [Description(@"Local rates for currency exchanges.")]
    OfflineExchangeRate,
    
    /// <summary>
    /// Predefined amounts to be presented to the customer.
    /// Encoded/decoded by serializers as "PreDefinedAmount".
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_A1wL44n-EeShMpas3885ww")]
    [Description(@"Predefined amounts to be presented to the customer.")]
    PreDefinedAmount,
    
    /// <summary>
    /// Configuration of the location.
    /// Encoded/decoded by serializers as "LocationConfiguration".
    /// </summary>
    [EnumMember(Value = "LOCC")]
    [IsoId("_CL-X84n-EeShMpas3885ww")]
    [Description(@"Configuration of the location.")]
    LocationConfiguration,
    
    /// <summary>
    /// Configuration of the mobile operator cards accepted by the terminal.
    /// Encoded/decoded by serializers as "MobileOperator".
    /// </summary>
    [EnumMember(Value = "MNOC")]
    [IsoId("_E8OSA4n-EeShMpas3885ww")]
    [Description(@"Configuration of the mobile operator cards accepted by the terminal.")]
    MobileOperator,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory7CodeMetadataExtensions
{
    private static readonly DataSetCategory7CodeDropdownSource _dropdownSource = new DataSetCategory7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory7CodeDropdownRow GetMetadata(this DataSetCategory7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


