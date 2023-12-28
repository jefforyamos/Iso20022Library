﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalRatesAndTenors1Code.  ISO2002 ID# _ukpS8JkYEeu3i5QmrY5b7Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external rates and tenors code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ukpS8JkYEeu3i5QmrY5b7Q")]
[Description(@"Specifies the external rates and tenors code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalRatesAndTenorsCode))]
public enum ExternalRatesAndTenors1Code
{
    /// <summary>
    /// Euro interbank offered rate (3 months, 6 months and other tenors).
    /// Encoded/decoded by serializers as "Euribor".
    /// </summary>
    [EnumMember(Value = "EURI")]
    [IsoId("_9lCmAQTyEey95qpfbNuEwg")]
    [Description(@"Euro interbank offered rate (3 months, 6 months and other tenors).")]
    Euribor,
    
    /// <summary>
    /// Euro Overnight Index Swap (ESTROIS) 1 day, 1 week, other tenors.
    /// Encoded/decoded by serializers as "EuroOvernightIndexSwap".
    /// </summary>
    [EnumMember(Value = "ESOI")]
    [IsoId("_9rTmEQTyEey95qpfbNuEwg")]
    [Description(@"Euro Overnight Index Swap (ESTROIS) 1 day, 1 week, other tenors.")]
    EuroOvernightIndexSwap,
    
    /// <summary>
    /// Euro short-term rate.
    /// Encoded/decoded by serializers as "EuroShortTermRate".
    /// </summary>
    [EnumMember(Value = "ESTR")]
    [IsoId("_9w0YMQTyEey95qpfbNuEwg")]
    [Description(@"Euro short-term rate.")]
    EuroShortTermRate,
    
    /// <summary>
    /// Pound sterling London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.
    /// Encoded/decoded by serializers as "GBPLibor".
    /// </summary>
    [EnumMember(Value = "GBPO")]
    [IsoId("_97sLcQTyEey95qpfbNuEwg")]
    [Description(@"Pound sterling London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.")]
    GBPLibor,
    
    /// <summary>
    /// Other floating rates and tenors.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-FiD8QTyEey95qpfbNuEwg")]
    [Description(@"Other floating rates and tenors.")]
    Other,
    
    /// <summary>
    /// Secured overnight financing rate (1 months, 3 months, other tenors).
    /// Encoded/decoded by serializers as "SecuredOvernightFinancingRate".
    /// </summary>
    [EnumMember(Value = "SOFR")]
    [IsoId("_-KcZIQTyEey95qpfbNuEwg")]
    [Description(@"Secured overnight financing rate (1 months, 3 months, other tenors).")]
    SecuredOvernightFinancingRate,
    
    /// <summary>
    /// US dollar overnight index swap (1 day, 1 week, other tenors), USDOIS.
    /// Encoded/decoded by serializers as "USDOvernightIndexSwap".
    /// </summary>
    [EnumMember(Value = "USOI")]
    [IsoId("_-P9LQQTyEey95qpfbNuEwg")]
    [Description(@"US dollar overnight index swap (1 day, 1 week, other tenors), USDOIS.")]
    USDOvernightIndexSwap,
    
    /// <summary>
    /// US dollar London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.
    /// Encoded/decoded by serializers as "USDLibor".
    /// </summary>
    [EnumMember(Value = "USPO")]
    [IsoId("_-U4HgQTyEey95qpfbNuEwg")]
    [Description(@"US dollar London inter-bank offered rate (3 months, 6 months, other tenors) and the respective successor rate.")]
    USDLibor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalRatesAndTenors1CodeMetadataExtensions
{
    private static readonly ExternalRatesAndTenors1CodeDropdownSource _dropdownSource = new ExternalRatesAndTenors1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalRatesAndTenors1CodeDropdownRow GetMetadata(this ExternalRatesAndTenors1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


