﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExtendedOptionFeature1Code.  ISO2002 ID# _146xITL3EeKU9IrkkToqcw_1729100634.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_146xITL3EeKU9IrkkToqcw_1729100634")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.")]
[DerivedFrom(typeof(ExtendedOptionFeatureCode))]
public enum ExtendedOptionFeature1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignTaxUnfavorable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_146xIjL3EeKU9IrkkToqcw_-255037301")]
    [Description(@"??")]
    ForeignTaxUnfavorable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignTaxFavorable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_146xIzL3EeKU9IrkkToqcw_-1138270588")]
    [Description(@"??")]
    ForeignTaxFavorable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignTaxExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_146xJDL3EeKU9IrkkToqcw_199049968")]
    [Description(@"??")]
    ForeignTaxExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DRIPUnfavorable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_146xJTL3EeKU9IrkkToqcw_-684183319")]
    [Description(@"??")]
    DRIPUnfavorable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DRIPFavorable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_15EiIDL3EeKU9IrkkToqcw_784996994")]
    [Description(@"??")]
    DRIPFavorable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DRIPExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_15EiITL3EeKU9IrkkToqcw_-2036135404")]
    [Description(@"??")]
    DRIPExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignCurrencyPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_15EiIjL3EeKU9IrkkToqcw_1375598605")]
    [Description(@"??")]
    ForeignCurrencyPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignCurrencyPaymentUnfavorable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_15EiIzL3EeKU9IrkkToqcw_-604784726")]
    [Description(@"??")]
    ForeignCurrencyPaymentUnfavorable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignCurrencyPaymentFavorable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_15EiJDL3EeKU9IrkkToqcw_-1488018013")]
    [Description(@"??")]
    ForeignCurrencyPaymentFavorable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForeignCurrencyPaymentExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_15EiJTL3EeKU9IrkkToqcw_809451896")]
    [Description(@"??")]
    ForeignCurrencyPaymentExempt,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExtendedOptionFeature1CodeMetadataExtensions
{
    private static readonly ExtendedOptionFeature1CodeDropdownSource _dropdownSource = new ExtendedOptionFeature1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExtendedOptionFeature1CodeDropdownRow GetMetadata(this ExtendedOptionFeature1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

