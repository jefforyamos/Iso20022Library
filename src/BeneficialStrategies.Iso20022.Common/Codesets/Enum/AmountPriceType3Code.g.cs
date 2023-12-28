﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AmountPriceType3Code.  ISO2002 ID# _eiyKAJbREee8S7xwGG7Veg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the amount price type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eiyKAJbREee8S7xwGG7Veg")]
[Description(@"Specifies the amount price type.")]
[DerivedFrom(typeof(AmountPriceTypeCode))]
public enum AmountPriceType3Code
{
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as "ActualAmount".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_i3gHgZbREee8S7xwGG7Veg")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount,
    
    /// <summary>
    /// Price expressed as an amount of money per lot.
    /// Encoded/decoded by serializers as "Lot".
    /// </summary>
    [EnumMember(Value = "PLOT")]
    [IsoId("_i9wggZbREee8S7xwGG7Veg")]
    [Description(@"Price expressed as an amount of money per lot.")]
    Lot,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AmountPriceType3CodeMetadataExtensions
{
    private static readonly AmountPriceType3CodeDropdownSource _dropdownSource = new AmountPriceType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAmountPriceType3CodeDropdownRow GetMetadata(this AmountPriceType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


