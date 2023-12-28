﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodTillBookingInstructionCode.  ISO2002 ID# _auYMRdp-Ed-ak6NoX_4Aeg_336256115.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_auYMRdp-Ed-ak6NoX_4Aeg_336256115")]
[Description(@"States whether executions are booked out or accumulated on a partially filled good till order on the day of execution or to accumulate.")]
public enum GoodTillBookingInstructionCode
{
    /// <summary>
    /// Book out all trades on day of execution.
    /// Encoded/decoded by serializers as "BOEX".
    /// </summary>
    [EnumMember(Value = "BOEX")]
    [IsoId("_auYMRtp-Ed-ak6NoX_4Aeg_336256132")]
    [Description(@"Book out all trades on day of execution.")]
    BookOnExecutionDay,
    
    /// <summary>
    /// Accumulate executions until order is filled or expires.
    /// Encoded/decoded by serializers as "ACTE".
    /// </summary>
    [EnumMember(Value = "ACTE")]
    [IsoId("_auYMR9p-Ed-ak6NoX_4Aeg_336256133")]
    [Description(@"Accumulate executions until order is filled or expires.")]
    AccumulateTillEnd,
    
    /// <summary>
    /// Accumulate until verbally notified otherwise.
    /// Encoded/decoded by serializers as "ACTT".
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_auYMSNp-Ed-ak6NoX_4Aeg_336256134")]
    [Description(@"Accumulate until verbally notified otherwise.")]
    AccumulateTillTold,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GoodTillBookingInstructionCodeMetadataExtensions
{
    private static readonly GoodTillBookingInstructionCodeDropdownSource _dropdownSource = new GoodTillBookingInstructionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGoodTillBookingInstructionCodeDropdownRow GetMetadata(this GoodTillBookingInstructionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

