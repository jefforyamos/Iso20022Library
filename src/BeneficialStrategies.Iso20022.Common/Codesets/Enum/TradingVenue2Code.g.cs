﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingVenue2Code.  ISO2002 ID# _p3TiYF0gEeWErPfQ7BYx8A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of a trading venue which can submit the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p3TiYF0gEeWErPfQ7BYx8A")]
[Description(@"Specifies the type of a trading venue which can submit the report.")]
[DerivedFrom(typeof(TradingVenueCode))]
public enum TradingVenue2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApprovedPublicationArrangement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dy31QV0iEeWErPfQ7BYx8A")]
    [Description(@"??")]
    ApprovedPublicationArrangement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ConsolidatedTapeProvider".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_F8rOgb4BEeWvRsMSLyTf-A")]
    [Description(@"??")]
    ConsolidatedTapeProvider,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingVenue2CodeMetadataExtensions
{
    private static readonly TradingVenue2CodeDropdownSource _dropdownSource = new TradingVenue2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingVenue2CodeDropdownRow GetMetadata(this TradingVenue2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


