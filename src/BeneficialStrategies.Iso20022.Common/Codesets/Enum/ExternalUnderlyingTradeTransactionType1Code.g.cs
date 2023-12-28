﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUnderlyingTradeTransactionType1Code.  ISO2002 ID# _-MhZAG7iEeKo25nLKvGr8w_-1500208754.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MhZAG7iEeKo25nLKvGr8w_-1500208754")]
[Description(@"Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUnderlyingTradeTransactionTypeCode))]
public enum ExternalUnderlyingTradeTransactionType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Contract".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQn48vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Contract,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DeliveryOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQn49fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    DeliveryOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProformaInvoice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQn4-PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    ProformaInvoice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Project".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQn4-_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Project,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PurchaseOrder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQxp8vRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    PurchaseOrder,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Quotation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQxp9fRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Quotation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tender".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uQxp-PRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Tender,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUnderlyingTradeTransactionType1CodeMetadataExtensions
{
    private static readonly ExternalUnderlyingTradeTransactionType1CodeDropdownSource _dropdownSource = new ExternalUnderlyingTradeTransactionType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUnderlyingTradeTransactionType1CodeDropdownRow GetMetadata(this ExternalUnderlyingTradeTransactionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


