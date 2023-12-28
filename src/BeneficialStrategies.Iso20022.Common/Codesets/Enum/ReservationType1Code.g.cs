﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReservationType1Code.  ISO2002 ID# _ZUiEdNp-Ed-ak6NoX_4Aeg_865240256.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the precise type of reservation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUiEdNp-Ed-ak6NoX_4Aeg_865240256")]
[Description(@"Specifies the precise type of reservation.")]
[DerivedFrom(typeof(ReservationTypeCode))]
public enum ReservationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashReservation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZUiEddp-Ed-ak6NoX_4Aeg_937272384")]
    [Description(@"??")]
    CashReservation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UrgentPaymentReservation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZUiEdtp-Ed-ak6NoX_4Aeg_952974761")]
    [Description(@"??")]
    UrgentPaymentReservation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NetSSSReservation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZUiEd9p-Ed-ak6NoX_4Aeg_998225402")]
    [Description(@"??")]
    NetSSSReservation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HighlyUrgentPaymentReservation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZUiEeNp-Ed-ak6NoX_4Aeg_1227258206")]
    [Description(@"??")]
    HighlyUrgentPaymentReservation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThresholdForInvestment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZUiEedp-Ed-ak6NoX_4Aeg_1253119695")]
    [Description(@"??")]
    ThresholdForInvestment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReservationType1CodeMetadataExtensions
{
    private static readonly ReservationType1CodeDropdownSource _dropdownSource = new ReservationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReservationType1CodeDropdownRow GetMetadata(this ReservationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

