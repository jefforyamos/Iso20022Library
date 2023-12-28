﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingProductIdentifier1Code.  ISO2002 ID# _-ZqKICjmEeK1Sbo8NpBROA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-ZqKICjmEeK1Sbo8NpBROA")]
[Description(@"Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.")]
[DerivedFrom(typeof(UnderlyingProductIdentifierCode))]
public enum UnderlyingProductIdentifier1Code
{
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange Forward.
    /// Encoded/decoded by serializers as "ForeignExchangeForward".
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_iRz_kSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange Forward.")]
    ForeignExchangeForward,
    
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange Non Deliverable Forward.
    /// Encoded/decoded by serializers as "ForeignExchangeNonDeliverableForward".
    /// </summary>
    [EnumMember(Value = "NDFO")]
    [IsoId("_iWttsSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange Non Deliverable Forward.")]
    ForeignExchangeNonDeliverableForward,
    
    /// <summary>
    /// Underlying product type of the transaction is Foreign Exchange Spot.
    /// Encoded/decoded by serializers as "ForeignExchangeSpot".
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_ibYyUSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is Foreign Exchange Spot.")]
    ForeignExchangeSpot,
    
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange SWAP.
    /// Encoded/decoded by serializers as "ForeignExchangeSWAP".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_ij84cSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange SWAP.")]
    ForeignExchangeSWAP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingProductIdentifier1CodeMetadataExtensions
{
    private static readonly UnderlyingProductIdentifier1CodeDropdownSource _dropdownSource = new UnderlyingProductIdentifier1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingProductIdentifier1CodeDropdownRow GetMetadata(this UnderlyingProductIdentifier1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


