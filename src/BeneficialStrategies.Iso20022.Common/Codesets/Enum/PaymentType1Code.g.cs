﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentType1Code.  ISO2002 ID# _Vl9g99p-Ed-ak6NoX_4Aeg_-345535565.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vl9g99p-Ed-ak6NoX_4Aeg_-345535565")]
[Description(@"Specifies the type, or nature, of the payment.")]
[DerivedFrom(typeof(PaymentTypeCode))]
public enum PaymentType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vl9g-Np-Ed-ak6NoX_4Aeg_193012472")]
    [Description(@"??")]
    CrossBorderPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BackUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vl9g-dp-Ed-ak6NoX_4Aeg_193012515")]
    [Description(@"??")]
    BackUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CLSPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR8Np-Ed-ak6NoX_4Aeg_193012532")]
    [Description(@"??")]
    CLSPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CentralBankOperation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR8dp-Ed-ak6NoX_4Aeg_193012575")]
    [Description(@"??")]
    CentralBankOperation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderHighValuePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR8tp-Ed-ak6NoX_4Aeg_193012592")]
    [Description(@"??")]
    CrossBorderHighValuePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderPriorityPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR89p-Ed-ak6NoX_4Aeg_193012627")]
    [Description(@"??")]
    CrossBorderPriorityPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExpressPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR9Np-Ed-ak6NoX_4Aeg_193012887")]
    [Description(@"??")]
    ExpressPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdCurrencyHighValuePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR9dp-Ed-ak6NoX_4Aeg_193012922")]
    [Description(@"??")]
    ThirdCurrencyHighValuePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LiquidityTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR9tp-Ed-ak6NoX_4Aeg_193012947")]
    [Description(@"??")]
    LiquidityTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DomesticPriorityPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR99p-Ed-ak6NoX_4Aeg_193012982")]
    [Description(@"??")]
    DomesticPriorityPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DomesticHighValuePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR-Np-Ed-ak6NoX_4Aeg_193013017")]
    [Description(@"??")]
    DomesticHighValuePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DomesticPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmHR-dp-Ed-ak6NoX_4Aeg_193013325")]
    [Description(@"??")]
    DomesticPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdCurrencyPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmQb4Np-Ed-ak6NoX_4Aeg_193013367")]
    [Description(@"??")]
    ThirdCurrencyPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdCurrencyPriorityPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VmQb4dp-Ed-ak6NoX_4Aeg_193013402")]
    [Description(@"??")]
    ThirdCurrencyPriorityPayment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentType1CodeMetadataExtensions
{
    private static readonly PaymentType1CodeDropdownSource _dropdownSource = new PaymentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentType1CodeDropdownRow GetMetadata(this PaymentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


