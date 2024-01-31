﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClearingChannel2Code.  ISO2002 ID# _a_OEo9p-Ed-ak6NoX_4Aeg_1501459302.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing channel for the routing of the transaction, as part of the payment type identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_OEo9p-Ed-ak6NoX_4Aeg_1501459302")]
[Description(@"Specifies the clearing channel for the routing of the transaction, as part of the payment type identification.")]
[DerivedFrom(typeof(ClearingChannelCode))]
public enum ClearingChannel2Code
{
    /// <summary>
    /// Clearing channel is a real-time gross settlement system.
    /// Encoded/decoded by serializers as "RTGS".
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_a_OEpNp-Ed-ak6NoX_4Aeg_1501459782")]
    [Description(@"Clearing channel is a real-time gross settlement system.")]
    RealTimeGrossSettlementSystem = ClearingChannelCode.RealTimeGrossSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing channel is a real-time net settlement system.
    /// Encoded/decoded by serializers as "RTNS".
    /// </summary>
    [EnumMember(Value = "RTNS")]
    [IsoId("_a_OEpdp-Ed-ak6NoX_4Aeg_1501460232")]
    [Description(@"Clearing channel is a real-time net settlement system.")]
    RealTimeNetSettlementSystem = ClearingChannelCode.RealTimeNetSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing channel is a mass payment net settlement system.
    /// Encoded/decoded by serializers as "MPNS".
    /// </summary>
    [EnumMember(Value = "MPNS")]
    [IsoId("_a_OEptp-Ed-ak6NoX_4Aeg_1501460309")]
    [Description(@"Clearing channel is a mass payment net settlement system.")]
    MassPaymentNetSystem = ClearingChannelCode.MassPaymentNetSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment through internal book transfer.
    /// Encoded/decoded by serializers as "BOOK".
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_a_OEp9p-Ed-ak6NoX_4Aeg_1524547392")]
    [Description(@"Payment through internal book transfer.")]
    BookTransfer = ClearingChannelCode.BookTransfer, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClearingChannel2CodeMetadataExtensions
{
    private static readonly ClearingChannel2CodeDropdownSource _dropdownSource = new ClearingChannel2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClearingChannel2CodeDropdownRow GetMetadata(this ClearingChannel2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


