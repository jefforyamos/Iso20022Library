﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CashMarginOrderCode.  ISO2002 ID# _a7DWUNp-Ed-ak6NoX_4Aeg_335335634.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether an order is a non-margin, an opening margin or a closing margin order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7DWUNp-Ed-ak6NoX_4Aeg_335335634")]
[Description(@"Identifies whether an order is a non-margin, an opening margin or a closing margin order.")]
[Derivations(typeof(CashMarginOrder1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CashMarginOrderCode
{
    /// <summary>
    /// The principal owns the cash in case of a purchase, or the securities in case of a sale so the execution, if it occurs, will not generate any margin account opening or margin call.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a7DWUdp-Ed-ak6NoX_4Aeg_335335635")]
    [Description(@"The principal owns the cash in case of a purchase, or the securities in case of a sale so the execution, if it occurs, will not generate any margin account opening or margin call.")]
    Cash,
    
    /// <summary>
    /// The principal order, if executed, will generate a margin account opening or margin call because the principal does not have the cash in case of a purchase or the securities in case of a sale.
    /// Encoded/decoded by serializers as "MRGO".
    /// </summary>
    [EnumMember(Value = "MRGO")]
    [IsoId("_a7DWUtp-Ed-ak6NoX_4Aeg_335335636")]
    [Description(@"The principal order, if executed, will generate a margin account opening or margin call because the principal does not have the cash in case of a purchase or the securities in case of a sale.")]
    MarginOpen,
    
    /// <summary>
    /// The principal order, if executed, will enable the margin position to be closed and the positions to be covered (for example: purchase of securities that have previously been short-sold, or sale of securities that have been bought on margin).
    /// Encoded/decoded by serializers as "MRGC".
    /// </summary>
    [EnumMember(Value = "MRGC")]
    [IsoId("_a7DWU9p-Ed-ak6NoX_4Aeg_335335637")]
    [Description(@"The principal order, if executed, will enable the margin position to be closed and the positions to be covered (for example: purchase of securities that have previously been short-sold, or sale of securities that have been bought on margin).")]
    MarginClose,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CashMarginOrderCodeMetadataExtensions
{
    private static readonly CashMarginOrderCodeDropdownSource _dropdownSource = new CashMarginOrderCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICashMarginOrderCodeDropdownRow GetMetadata(this CashMarginOrderCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


