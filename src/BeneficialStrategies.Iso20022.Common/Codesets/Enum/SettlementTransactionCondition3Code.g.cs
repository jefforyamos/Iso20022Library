﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementTransactionCondition3Code.  ISO2002 ID# _ZNYTk9p-Ed-ak6NoX_4Aeg_-969430836.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZNYTk9p-Ed-ak6NoX_4Aeg_-969430836")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
public enum SettlementTransactionCondition3Code
{
    /// <summary>
    /// Transfer of ownership of the asset to another party during the closing of an option.
    /// Encoded/decoded by serializers as "Assignement".
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_ZNYTlNp-Ed-ak6NoX_4Aeg_-905151230")]
    [Description(@"Transfer of ownership of the asset to another party during the closing of an option.")]
    Assignement,
    
    /// <summary>
    /// Tax-exempt financial instruments are to be settled.
    /// Encoded/decoded by serializers as "Clean".
    /// </summary>
    [EnumMember(Value = "CLEN")]
    [IsoId("_ZNYTldp-Ed-ak6NoX_4Aeg_-1788384517")]
    [Description(@"Tax-exempt financial instruments are to be settled.")]
    Clean,
    
    /// <summary>
    /// Taxable financial instruments are to be settled.
    /// Encoded/decoded by serializers as "Dirty".
    /// </summary>
    [EnumMember(Value = "DIRT")]
    [IsoId("_ZNYTltp-Ed-ak6NoX_4Aeg_-2080342255")]
    [Description(@"Taxable financial instruments are to be settled.")]
    Dirty,
    
    /// <summary>
    /// Matching receipt instruction not required (only for concerned international or national central securities depositories).
    /// Encoded/decoded by serializers as "DeliveryWithoutMatching".
    /// </summary>
    [EnumMember(Value = "DLWM")]
    [IsoId("_ZNYTl9p-Ed-ak6NoX_4Aeg_-1902223583")]
    [Description(@"Matching receipt instruction not required (only for concerned international or national central securities depositories).")]
    DeliveryWithoutMatching,
    
    /// <summary>
    /// Settlement transactions relates to drawn securities.
    /// Encoded/decoded by serializers as "Drawn".
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZNYTmNp-Ed-ak6NoX_4Aeg_1331391754")]
    [Description(@"Settlement transactions relates to drawn securities.")]
    Drawn,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are exercised.
    /// Encoded/decoded by serializers as "Exercised".
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_ZNYTmdp-Ed-ak6NoX_4Aeg_1509510426")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are exercised.")]
    Exercised,
    
    /// <summary>
    /// Delivery will be made free of payment but a clean payment order will be sent.
    /// Encoded/decoded by serializers as "FreeCleanSettlement".
    /// </summary>
    [EnumMember(Value = "FRCL")]
    [IsoId("_ZNhdgNp-Ed-ak6NoX_4Aeg_1217552688")]
    [Description(@"Delivery will be made free of payment but a clean payment order will be sent.")]
    FreeCleanSettlement,
    
    /// <summary>
    /// Settlement transaction relates to options, futures or derivatives that are expired worthless.
    /// Encoded/decoded by serializers as "KnockedOut".
    /// </summary>
    [EnumMember(Value = "KNOC")]
    [IsoId("_ZNhdgdp-Ed-ak6NoX_4Aeg_1395671360")]
    [Description(@"Settlement transaction relates to options, futures or derivatives that are expired worthless.")]
    KnockedOut,
    
    /// <summary>
    /// Securities are to be physically settled.
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_ZNhdgtp-Ed-ak6NoX_4Aeg_334319401")]
    [Description(@"Securities are to be physically settled.")]
    Physical,
    
    /// <summary>
    /// Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.
    /// Encoded/decoded by serializers as "Residual".
    /// </summary>
    [EnumMember(Value = "RESI")]
    [IsoId("_ZNhdg9p-Ed-ak6NoX_4Aeg_512438073")]
    [Description(@"Relates to transaction on a security that is not eligible at the Central Security Depository (CSD) but for which the payment will be enacted by the central securities depository.")]
    Residual,
    
    /// <summary>
    /// Settlement transactions to be settled with special delivery.
    /// Encoded/decoded by serializers as "SpecialDelivery".
    /// </summary>
    [EnumMember(Value = "SPDL")]
    [IsoId("_ZNhdhNp-Ed-ak6NoX_4Aeg_-662752952")]
    [Description(@"Settlement transactions to be settled with special delivery.")]
    SpecialDelivery,
    
    /// <summary>
    /// Money and financial instruments settle in different locations.
    /// Encoded/decoded by serializers as "SplitSettlement".
    /// </summary>
    [EnumMember(Value = "SPST")]
    [IsoId("_ZNhdhdp-Ed-ak6NoX_4Aeg_-484634280")]
    [Description(@"Money and financial instruments settle in different locations.")]
    SplitSettlement,
    
    /// <summary>
    /// Delivery cannot be performed until money is received.
    /// Encoded/decoded by serializers as "Unexposed".
    /// </summary>
    [EnumMember(Value = "UNEX")]
    [IsoId("_ZNhdhtp-Ed-ak6NoX_4Aeg_-2125897437")]
    [Description(@"Delivery cannot be performed until money is received.")]
    Unexposed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementTransactionCondition3CodeMetadataExtensions
{
    private static readonly SettlementTransactionCondition3CodeDropdownSource _dropdownSource = new SettlementTransactionCondition3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementTransactionCondition3CodeDropdownRow GetMetadata(this SettlementTransactionCondition3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


