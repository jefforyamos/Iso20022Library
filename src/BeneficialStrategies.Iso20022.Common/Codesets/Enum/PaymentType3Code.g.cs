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
    /// Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as "CrossBorderPayment".
    /// </summary>
    [EnumMember(Value = "CBS")]
    [IsoId("_Z8A7NNp-Ed-ak6NoX_4Aeg_-2009106552")]
    [Description(@"Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.")]
    CrossBorderPayment,
    
    /// <summary>
    /// Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.
    /// Encoded/decoded by serializers as "BackUp".
    /// </summary>
    [EnumMember(Value = "BCK")]
    [IsoId("_Z8A7Ndp-Ed-ak6NoX_4Aeg_-2009106527")]
    [Description(@"Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.")]
    BackUp,
    
    /// <summary>
    /// Transaction is a payment offsetting the net cash balance owed/due in a retail payment system.
    /// Encoded/decoded by serializers as "BalanceRetail".
    /// </summary>
    [EnumMember(Value = "BAL")]
    [IsoId("_Z8A7Ntp-Ed-ak6NoX_4Aeg_-2009106526")]
    [Description(@"Transaction is a payment offsetting the net cash balance owed/due in a retail payment system.")]
    BalanceRetail,
    
    /// <summary>
    /// Payment is linked to CLS activities.
    /// Encoded/decoded by serializers as "CLSPayment".
    /// </summary>
    [EnumMember(Value = "CLS")]
    [IsoId("_Z8A7N9p-Ed-ak6NoX_4Aeg_-2009106510")]
    [Description(@"Payment is linked to CLS activities.")]
    CLSPayment,
    
    /// <summary>
    /// Payment is made to settle an operation made with the central bank.
    /// Encoded/decoded by serializers as "CentralBankOperation".
    /// </summary>
    [EnumMember(Value = "CTR")]
    [IsoId("_Z8A7ONp-Ed-ak6NoX_4Aeg_-2009106492")]
    [Description(@"Payment is made to settle an operation made with the central bank.")]
    CentralBankOperation,
    
    /// <summary>
    /// Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as "CrossBorderHighValuePayment".
    /// </summary>
    [EnumMember(Value = "CBH")]
    [IsoId("_Z8A7Odp-Ed-ak6NoX_4Aeg_-2009106467")]
    [Description(@"Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.")]
    CrossBorderHighValuePayment,
    
    /// <summary>
    /// Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as "CrossBorderPriorityPayment".
    /// </summary>
    [EnumMember(Value = "CBP")]
    [IsoId("_Z8KsMNp-Ed-ak6NoX_4Aeg_-2009106450")]
    [Description(@"Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    CrossBorderPriorityPayment,
    
    /// <summary>
    /// Gross cash payment offsetting the amount owed/due for a securities transaction settlement.
    /// Encoded/decoded by serializers as "DVPGross".
    /// </summary>
    [EnumMember(Value = "DPG")]
    [IsoId("_Z8KsMdp-Ed-ak6NoX_4Aeg_-2009106432")]
    [Description(@"Gross cash payment offsetting the amount owed/due for a securities transaction settlement.")]
    DVPGross,
    
    /// <summary>
    /// Net payment offsetting the cash balance due/owed for a series of securities transactions settlement.
    /// Encoded/decoded by serializers as "DVPNet".
    /// </summary>
    [EnumMember(Value = "DPN")]
    [IsoId("_Z8KsMtp-Ed-ak6NoX_4Aeg_-2009106415")]
    [Description(@"Net payment offsetting the cash balance due/owed for a series of securities transactions settlement.")]
    DVPNet,
    
    /// <summary>
    /// Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.
    /// Encoded/decoded by serializers as "ExpressPayment".
    /// </summary>
    [EnumMember(Value = "EXP")]
    [IsoId("_Z8KsM9p-Ed-ak6NoX_4Aeg_-2009106414")]
    [Description(@"Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.")]
    ExpressPayment,
    
    /// <summary>
    /// Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as "ThirdCurrencyHighValuePayment".
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_Z8KsNNp-Ed-ak6NoX_4Aeg_-2009106397")]
    [Description(@"Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.")]
    ThirdCurrencyHighValuePayment,
    
    /// <summary>
    /// Transaction is a payment that is processed when the pool of liquidity exceeds the minimum value reserved for an express payment in the RTGSPlus system.
    /// Encoded/decoded by serializers as "LimitPayment".
    /// </summary>
    [EnumMember(Value = "LMT")]
    [IsoId("_Z8KsNdp-Ed-ak6NoX_4Aeg_-2009106124")]
    [Description(@"Transaction is a payment that is processed when the pool of liquidity exceeds the minimum value reserved for an express payment in the RTGSPlus system.")]
    LimitPayment,
    
    /// <summary>
    /// Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.
    /// Encoded/decoded by serializers as "LiquidityTransfer".
    /// </summary>
    [EnumMember(Value = "LIQ")]
    [IsoId("_Z8KsNtp-Ed-ak6NoX_4Aeg_-2009106107")]
    [Description(@"Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.")]
    LiquidityTransfer,
    
    /// <summary>
    /// Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as "DomesticPriorityPayment".
    /// </summary>
    [EnumMember(Value = "DPP")]
    [IsoId("_Z8KsN9p-Ed-ak6NoX_4Aeg_-2009106106")]
    [Description(@"Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.")]
    DomesticPriorityPayment,
    
    /// <summary>
    /// Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as "DomesticHighValuePayment".
    /// </summary>
    [EnumMember(Value = "DPH")]
    [IsoId("_Z8KsONp-Ed-ak6NoX_4Aeg_-2009106089")]
    [Description(@"Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.")]
    DomesticHighValuePayment,
    
    /// <summary>
    /// Payment has an origin and a destination in the same country, and is made in the currency of that country.
    /// Encoded/decoded by serializers as "DomesticPayment".
    /// </summary>
    [EnumMember(Value = "DPS")]
    [IsoId("_Z8KsOdp-Ed-ak6NoX_4Aeg_-2009106012")]
    [Description(@"Payment has an origin and a destination in the same country, and is made in the currency of that country.")]
    DomesticPayment,
    
    /// <summary>
    /// Payment is linked to overnight deposits and the marginal lending facility.
    /// Encoded/decoded by serializers as "StandingFacilities".
    /// </summary>
    [EnumMember(Value = "STF")]
    [IsoId("_Z8T2INp-Ed-ak6NoX_4Aeg_-2009105969")]
    [Description(@"Payment is linked to overnight deposits and the marginal lending facility.")]
    StandingFacilities,
    
    /// <summary>
    /// Payment is linked to the Treasury State.
    /// Encoded/decoded by serializers as "TreasuryStatePayment".
    /// </summary>
    [EnumMember(Value = "TRP")]
    [IsoId("_Z8T2Idp-Ed-ak6NoX_4Aeg_-2009105952")]
    [Description(@"Payment is linked to the Treasury State.")]
    TreasuryStatePayment,
    
    /// <summary>
    /// Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as "ThirdCurrencyPayment".
    /// </summary>
    [EnumMember(Value = "TCS")]
    [IsoId("_Z8T2Itp-Ed-ak6NoX_4Aeg_-2009105934")]
    [Description(@"Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.")]
    ThirdCurrencyPayment,
    
    /// <summary>
    /// Transaction is the payment of a specific amount of money lent by a creditor/lender.
    /// Encoded/decoded by serializers as "Loan".
    /// </summary>
    [EnumMember(Value = "LOA")]
    [IsoId("_Z8T2I9p-Ed-ak6NoX_4Aeg_-2009105933")]
    [Description(@"Transaction is the payment of a specific amount of money lent by a creditor/lender.")]
    Loan,
    
    /// <summary>
    /// Transaction is an amount of money transferred in repayment of loan.
    /// Encoded/decoded by serializers as "LoanRepayment".
    /// </summary>
    [EnumMember(Value = "LOR")]
    [IsoId("_Z8T2JNp-Ed-ak6NoX_4Aeg_-2009105909")]
    [Description(@"Transaction is an amount of money transferred in repayment of loan.")]
    LoanRepayment,
    
    /// <summary>
    /// Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.
    /// Encoded/decoded by serializers as "ThirdCurrencyPriorityPayment".
    /// </summary>
    [EnumMember(Value = "TCP")]
    [IsoId("_Z8T2Jdp-Ed-ak6NoX_4Aeg_-2009105892")]
    [Description(@"Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.")]
    ThirdCurrencyPriorityPayment,
    
    /// <summary>
    /// Transaction is linked to an overnight deposit.
    /// Encoded/decoded by serializers as "OvernightDeposit".
    /// </summary>
    [EnumMember(Value = "OND")]
    [IsoId("_Z8T2Jtp-Ed-ak6NoX_4Aeg_-1235461266")]
    [Description(@"Transaction is linked to an overnight deposit.")]
    OvernightDeposit,
    
    /// <summary>
    /// Transaction is linked to the marginal lending facility.
    /// Encoded/decoded by serializers as "MarginalLending".
    /// </summary>
    [EnumMember(Value = "MGL")]
    [IsoId("_Z8T2J9p-Ed-ak6NoX_4Aeg_-1231765290")]
    [Description(@"Transaction is linked to the marginal lending facility.")]
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


