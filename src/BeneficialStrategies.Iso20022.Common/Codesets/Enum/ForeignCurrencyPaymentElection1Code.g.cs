﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ForeignCurrencyPaymentElection1Code.  ISO2002 ID# _1zs58jL3EeKU9IrkkToqcw_-975137310.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the foreign currency payment is offered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1zs58jL3EeKU9IrkkToqcw_-975137310")]
[Description(@"Specifies whether the foreign currency payment is offered.")]
[DerivedFrom(typeof(ForeignCurrencyPaymentElectionCode))]
public enum ForeignCurrencyPaymentElection1Code
{
    /// <summary>
    /// Foreign currency payment is offered.
    /// Encoded/decoded by serializers as "OFFD".
    /// </summary>
    [EnumMember(Value = "OFFD")]
    [IsoId("_1zs58zL3EeKU9IrkkToqcw_-629605202")]
    [Description(@"Foreign currency payment is offered.")]
    Offered = ForeignCurrencyPaymentElectionCode.Offered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign currency payment is not offered.
    /// Encoded/decoded by serializers as "NOFD".
    /// </summary>
    [EnumMember(Value = "NOFD")]
    [IsoId("_1zs59DL3EeKU9IrkkToqcw_-1264637048")]
    [Description(@"Foreign currency payment is not offered.")]
    NotOffered = ForeignCurrencyPaymentElectionCode.NotOffered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign currency payment is mandatory.
    /// Encoded/decoded by serializers as "MAND".
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_1zs59TL3EeKU9IrkkToqcw_202511715")]
    [Description(@"Foreign currency payment is mandatory.")]
    Mandatory = ForeignCurrencyPaymentElectionCode.Mandatory, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ForeignCurrencyPaymentElection1CodeMetadataExtensions
{
    private static readonly ForeignCurrencyPaymentElection1CodeDropdownSource _dropdownSource = new ForeignCurrencyPaymentElection1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IForeignCurrencyPaymentElection1CodeDropdownRow GetMetadata(this ForeignCurrencyPaymentElection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


