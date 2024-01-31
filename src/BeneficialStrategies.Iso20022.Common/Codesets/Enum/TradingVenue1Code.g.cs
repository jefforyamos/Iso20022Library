﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingVenue1Code.  ISO2002 ID# _miosoF0gEeWErPfQ7BYx8A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a trading venue which must use the market identification code (MIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_miosoF0gEeWErPfQ7BYx8A")]
[Description(@"Specifies the type of a trading venue which must use the market identification code (MIC).")]
[DerivedFrom(typeof(TradingVenueCode))]
public enum TradingVenue1Code
{
    /// <summary>
    /// Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system.
    /// Encoded/decoded by serializers as "SINT".
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_n5ZEMV0gEeWErPfQ7BYx8A")]
    [Description(@"Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system.")]
    SystematicInternaliser = TradingVenueCode.SystematicInternaliser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as "MLTF".
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_akwoseRUEeW25oRYRCmhTA")]
    [Description(@"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.")]
    MultilateralTradingFacility = TradingVenueCode.MultilateralTradingFacility, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract.
    /// Encoded/decoded by serializers as "OTFS".
    /// </summary>
    [EnumMember(Value = "OTFS")]
    [IsoId("_a_tfUeRUEeW25oRYRCmhTA")]
    [Description(@"Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract.")]
    OrganisedTradingFacility = TradingVenueCode.OrganisedTradingFacility, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as "RMKT".
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_bKnHweRUEeW25oRYRCmhTA")]
    [Description(@"Market on which financial instruments can be traded according to rules defined by the stock exchange.")]
    RegulatedMarket = TradingVenueCode.RegulatedMarket, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingVenue1CodeMetadataExtensions
{
    private static readonly TradingVenue1CodeDropdownSource _dropdownSource = new TradingVenue1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingVenue1CodeDropdownRow GetMetadata(this TradingVenue1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


