﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExposureType6Code.  ISO2002 ID# _UIVnYHaaEeavseMKyTsJEA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UIVnYHaaEeavseMKyTsJEA")]
[Description(@"Identification of the type of the transaction.")]
[DerivedFrom(typeof(ExposureTypeCode))]
public enum ExposureType6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesBuySellSellBuyBack".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cpr9YXaaEeavseMKyTsJEA")]
    [Description(@"??")]
    SecuritiesBuySellSellBuyBack,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarginLending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_eIA8kXaaEeavseMKyTsJEA")]
    [Description(@"??")]
    MarginLending,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RepurchaseAgreement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_fyWXcXaaEeavseMKyTsJEA")]
    [Description(@"??")]
    RepurchaseAgreement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuritiesLendingAndBorrowing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kB3r4XaaEeavseMKyTsJEA")]
    [Description(@"??")]
    SecuritiesLendingAndBorrowing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExposureType6CodeMetadataExtensions
{
    private static readonly ExposureType6CodeDropdownSource _dropdownSource = new ExposureType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExposureType6CodeDropdownRow GetMetadata(this ExposureType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

