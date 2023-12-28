﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentType3Code.  ISO2002 ID# _Z8A7M9p-Ed-ak6NoX_4Aeg_-2009106787.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z8A7M9p-Ed-ak6NoX_4Aeg_-2009106787")]
[Description(@"Specifies the type, or nature, of the payment.")]
[DerivedFrom(typeof(PaymentTypeCode))]
public enum PaymentType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8A7NNp-Ed-ak6NoX_4Aeg_-2009106552")]
    [Description(@"??")]
    CrossBorderPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BackUp".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8A7Ndp-Ed-ak6NoX_4Aeg_-2009106527")]
    [Description(@"??")]
    BackUp,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BalanceRetail".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8A7Ntp-Ed-ak6NoX_4Aeg_-2009106526")]
    [Description(@"??")]
    BalanceRetail,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CLSPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8A7N9p-Ed-ak6NoX_4Aeg_-2009106510")]
    [Description(@"??")]
    CLSPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CentralBankOperation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8A7ONp-Ed-ak6NoX_4Aeg_-2009106492")]
    [Description(@"??")]
    CentralBankOperation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderHighValuePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8A7Odp-Ed-ak6NoX_4Aeg_-2009106467")]
    [Description(@"??")]
    CrossBorderHighValuePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossBorderPriorityPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsMNp-Ed-ak6NoX_4Aeg_-2009106450")]
    [Description(@"??")]
    CrossBorderPriorityPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DVPGross".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsMdp-Ed-ak6NoX_4Aeg_-2009106432")]
    [Description(@"??")]
    DVPGross,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DVPNet".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsMtp-Ed-ak6NoX_4Aeg_-2009106415")]
    [Description(@"??")]
    DVPNet,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExpressPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsM9p-Ed-ak6NoX_4Aeg_-2009106414")]
    [Description(@"??")]
    ExpressPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdCurrencyHighValuePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsNNp-Ed-ak6NoX_4Aeg_-2009106397")]
    [Description(@"??")]
    ThirdCurrencyHighValuePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LimitPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsNdp-Ed-ak6NoX_4Aeg_-2009106124")]
    [Description(@"??")]
    LimitPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LiquidityTransfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsNtp-Ed-ak6NoX_4Aeg_-2009106107")]
    [Description(@"??")]
    LiquidityTransfer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DomesticPriorityPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsN9p-Ed-ak6NoX_4Aeg_-2009106106")]
    [Description(@"??")]
    DomesticPriorityPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DomesticHighValuePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsONp-Ed-ak6NoX_4Aeg_-2009106089")]
    [Description(@"??")]
    DomesticHighValuePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DomesticPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8KsOdp-Ed-ak6NoX_4Aeg_-2009106012")]
    [Description(@"??")]
    DomesticPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StandingFacilities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2INp-Ed-ak6NoX_4Aeg_-2009105969")]
    [Description(@"??")]
    StandingFacilities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TreasuryStatePayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2Idp-Ed-ak6NoX_4Aeg_-2009105952")]
    [Description(@"??")]
    TreasuryStatePayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdCurrencyPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2Itp-Ed-ak6NoX_4Aeg_-2009105934")]
    [Description(@"??")]
    ThirdCurrencyPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Loan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2I9p-Ed-ak6NoX_4Aeg_-2009105933")]
    [Description(@"??")]
    Loan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LoanRepayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2JNp-Ed-ak6NoX_4Aeg_-2009105909")]
    [Description(@"??")]
    LoanRepayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdCurrencyPriorityPayment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2Jdp-Ed-ak6NoX_4Aeg_-2009105892")]
    [Description(@"??")]
    ThirdCurrencyPriorityPayment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OvernightDeposit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2Jtp-Ed-ak6NoX_4Aeg_-1235461266")]
    [Description(@"??")]
    OvernightDeposit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarginalLending".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Z8T2J9p-Ed-ak6NoX_4Aeg_-1231765290")]
    [Description(@"??")]
    MarginalLending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentType3CodeMetadataExtensions
{
    private static readonly PaymentType3CodeDropdownSource _dropdownSource = new PaymentType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentType3CodeDropdownRow GetMetadata(this PaymentType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

