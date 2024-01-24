﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodTillBookingInstruction1Code.  ISO2002 ID# _auYMQdp-Ed-ak6NoX_4Aeg_438323415.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auYMQdp-Ed-ak6NoX_4Aeg_438323415")]
[Description(@"States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.")]
[DerivedFrom(typeof(GoodTillBookingInstructionCode))]
public enum GoodTillBookingInstruction1Code
{
    /// <summary>
    /// Book out all trades on day of execution.
    /// Encoded/decoded by serializers as "BOEX".
    /// </summary>
    [EnumMember(Value = "BOEX")]
    [IsoId("_auYMQtp-Ed-ak6NoX_4Aeg_659969076")]
    [Description(@"Book out all trades on day of execution.")]
    BookOnExecutionDay = GoodTillBookingInstructionCode.BookOnExecutionDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accumulate executions until order is filled or expires.
    /// Encoded/decoded by serializers as "ACTE".
    /// </summary>
    [EnumMember(Value = "ACTE")]
    [IsoId("_auYMQ9p-Ed-ak6NoX_4Aeg_659969118")]
    [Description(@"Accumulate executions until order is filled or expires.")]
    AccumulateTillEnd = GoodTillBookingInstructionCode.AccumulateTillEnd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Accumulate until verbally notified otherwise.
    /// Encoded/decoded by serializers as "ACTT".
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_auYMRNp-Ed-ak6NoX_4Aeg_659969178")]
    [Description(@"Accumulate until verbally notified otherwise.")]
    AccumulateTillTold = GoodTillBookingInstructionCode.AccumulateTillTold, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GoodTillBookingInstruction1CodeMetadataExtensions
{
    private static readonly GoodTillBookingInstruction1CodeDropdownSource _dropdownSource = new GoodTillBookingInstruction1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGoodTillBookingInstruction1CodeDropdownRow GetMetadata(this GoodTillBookingInstruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


