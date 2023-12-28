﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssuredTypeCode.  ISO2002 ID# _bjRz9Np-Ed-ak6NoX_4Aeg_1647471497.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which type of party should be the assured on the insurance certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjRz9Np-Ed-ak6NoX_4Aeg_1647471497")]
[Description(@"Specifies which type of party should be the assured on the insurance certificate.")]
[Derivations(typeof(AssuredType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum AssuredTypeCode
{
    /// <summary>
    /// The buyer should be the assured.
    /// Encoded/decoded by serializers as "BUYE".
    /// </summary>
    [EnumMember(Value = "BUYE")]
    [IsoId("_bjbk8Np-Ed-ak6NoX_4Aeg_1647471499")]
    [Description(@"The buyer should be the assured.")]
    Buyer,
    
    /// <summary>
    /// The seller should be the assured.
    /// Encoded/decoded by serializers as "SELL".
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_bjbk8dp-Ed-ak6NoX_4Aeg_1647471558")]
    [Description(@"The seller should be the assured.")]
    Seller,
    
    /// <summary>
    /// The buyer's bank should be the assured.
    /// Encoded/decoded by serializers as "BUBA".
    /// </summary>
    [EnumMember(Value = "BUBA")]
    [IsoId("_bjbk8tp-Ed-ak6NoX_4Aeg_1971625958")]
    [Description(@"The buyer's bank should be the assured.")]
    BuyerBank,
    
    /// <summary>
    /// The seller's bank should be the assured.
    /// Encoded/decoded by serializers as "SEBA".
    /// </summary>
    [EnumMember(Value = "SEBA")]
    [IsoId("_bjbk89p-Ed-ak6NoX_4Aeg_2001181880")]
    [Description(@"The seller's bank should be the assured.")]
    SellerBank,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssuredTypeCodeMetadataExtensions
{
    private static readonly AssuredTypeCodeDropdownSource _dropdownSource = new AssuredTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssuredTypeCodeDropdownRow GetMetadata(this AssuredTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


