﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CounterpartyResponseStatusReason1Code.  ISO2002 ID# _0mWuhAlIEeGATtfOBToyew_-723419449.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of counterparty's action the response is related to.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mWuhAlIEeGATtfOBToyew_-723419449")]
[Description(@"Specifies the type of counterparty's action the response is related to.")]
[DerivedFrom(typeof(CounterpartyResponseStatusReasonCode))]
public enum CounterpartyResponseStatusReason1Code
{
    /// <summary>
    /// Specifies that the response is related to an allegement from the counterparty.
    /// Encoded/decoded by serializers as "CounterpartyTransaction".
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_0mWuhQlIEeGATtfOBToyew_1912527419")]
    [Description(@"Specifies that the response is related to an allegement from the counterparty.")]
    CounterpartyTransaction,
    
    /// <summary>
    /// Specifies that the response is related to the cancellation request of the counterparty.
    /// Encoded/decoded by serializers as "CounterpartyCancellation".
    /// </summary>
    [EnumMember(Value = "CPCX")]
    [IsoId("_0mgfgAlIEeGATtfOBToyew_1029294132")]
    [Description(@"Specifies that the response is related to the cancellation request of the counterparty.")]
    CounterpartyCancellation,
    
    /// <summary>
    /// Specifies that the response is related to the modification request of the counterparty.
    /// Encoded/decoded by serializers as "CounterpartyModification".
    /// </summary>
    [EnumMember(Value = "CPMD")]
    [IsoId("_0mgfgQlIEeGATtfOBToyew_2030398404")]
    [Description(@"Specifies that the response is related to the modification request of the counterparty.")]
    CounterpartyModification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CounterpartyResponseStatusReason1CodeMetadataExtensions
{
    private static readonly CounterpartyResponseStatusReason1CodeDropdownSource _dropdownSource = new CounterpartyResponseStatusReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICounterpartyResponseStatusReason1CodeDropdownRow GetMetadata(this CounterpartyResponseStatusReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


