﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralisationType2Code.  ISO2002 ID# _A1iQsFfjEeqqKf65rDYWYw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral agreement between two parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A1iQsFfjEeqqKf65rDYWYw")]
[Description(@"Specifies the type of collateral agreement between two parties.")]
[DerivedFrom(typeof(CollateralisationTypeCode))]
public enum CollateralisationType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullyCollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_D1TNcVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    FullyCollateralised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneWayCollateralisedCounterparty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ehe-AVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    OneWayCollateralisedCounterparty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneWayCollateralisedCounterparty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ep0aoVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    OneWayCollateralisedCounterparty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneWayPartiallyCollateralisedCounterparty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EzpFAVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    OneWayPartiallyCollateralisedCounterparty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneWayPartiallyCollateralisedCounterparty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_E-DlQVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    OneWayPartiallyCollateralisedCounterparty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyCollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FmqdYVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    PartiallyCollateralised,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyCollateralisedCounterparty1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GISjwVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    PartiallyCollateralisedCounterparty1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartiallyCollateralisedCounterparty2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GREFQVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    PartiallyCollateralisedCounterparty2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Uncollateralised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GoH6YVfjEeqqKf65rDYWYw")]
    [Description(@"??")]
    Uncollateralised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralisationType2CodeMetadataExtensions
{
    private static readonly CollateralisationType2CodeDropdownSource _dropdownSource = new CollateralisationType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralisationType2CodeDropdownRow GetMetadata(this CollateralisationType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


