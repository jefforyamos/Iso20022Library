﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateType2Code.  ISO2002 ID# _ZZJeuNp-Ed-ak6NoX_4Aeg_-1692318334.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZJeuNp-Ed-ak6NoX_4Aeg_-1692318334")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType2Code
{
    /// <summary>
    /// Rate used for additional tax that cannot be categorised.
    /// Encoded/decoded by serializers as "ATAX".
    /// </summary>
    [EnumMember(Value = "ATAX")]
    [IsoId("_ZZTPsNp-Ed-ak6NoX_4Aeg_-1692318332")]
    [Description(@"Rate used for additional tax that cannot be categorised.")]
    AdditionalTax = RateTypeCode.AdditionalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// Encoded/decoded by serializers as "CHAR".
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_ZZTPsdp-Ed-ak6NoX_4Aeg_-1692318331")]
    [Description(@"Rate used to calculate the amount of the charges/fees that cannot be categorised.")]
    Charges = RateTypeCode.Charges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate used to calculate the cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// Encoded/decoded by serializers as "CINL".
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_ZZTPstp-Ed-ak6NoX_4Aeg_-1692318303")]
    [Description(@"Rate used to calculate the cash disbursement in lieu of a fractional quantity of, for example, equity.")]
    CashInLieuOfSecurities = RateTypeCode.CashInLieuOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash dividend per equity before deductions or allowances have been made.
    /// Encoded/decoded by serializers as "GRSS".
    /// </summary>
    [EnumMember(Value = "GRSS")]
    [IsoId("_ZZTPs9p-Ed-ak6NoX_4Aeg_-1692318302")]
    [Description(@"Cash dividend per equity before deductions or allowances have been made.")]
    Gross = RateTypeCode.Gross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.
    /// Encoded/decoded by serializers as "INCE".
    /// </summary>
    [EnumMember(Value = "INCE")]
    [IsoId("_ZZTPtNp-Ed-ak6NoX_4Aeg_-1692318301")]
    [Description(@"Rate of the cash premium made available if the securities holder consents or participates to an event, for example, consent fees.")]
    CashIncentive = RateTypeCode.CashIncentive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the netting of settlement instructions.
    /// Encoded/decoded by serializers as "NETT".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZZTPtdp-Ed-ak6NoX_4Aeg_-1692318025")]
    [Description(@"Relates to the netting of settlement instructions.")]
    Net = RateTypeCode.Net, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash rate made available in an offer in order to encourage participation in the offer.
    /// Encoded/decoded by serializers as "SOFE".
    /// </summary>
    [EnumMember(Value = "SOFE")]
    [IsoId("_ZZTPttp-Ed-ak6NoX_4Aeg_-1692318024")]
    [Description(@"Cash rate made available in an offer in order to encourage participation in the offer.")]
    Sollication = RateTypeCode.Sollication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument has not been stamped and/or duly signed.
    /// Encoded/decoded by serializers as "STAM".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_ZZTPt9p-Ed-ak6NoX_4Aeg_-1692318023")]
    [Description(@"Financial instrument has not been stamped and/or duly signed.")]
    StampDuty = RateTypeCode.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate of stock exchange tax.
    /// Encoded/decoded by serializers as "STEX".
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_ZZcZoNp-Ed-ak6NoX_4Aeg_-1692317994")]
    [Description(@"Rate of stock exchange tax.")]
    StockExchangeTax = RateTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been generated due to transformation following a corporate action.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZZcZodp-Ed-ak6NoX_4Aeg_-1692317993")]
    [Description(@"Transaction has been generated due to transformation following a corporate action.")]
    TransferTax = RateTypeCode.TransferTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate used to calculate the amount of transaction tax.
    /// Encoded/decoded by serializers as "TRAX".
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_ZZcZotp-Ed-ak6NoX_4Aeg_-1692317964")]
    [Description(@"Rate used to calculate the amount of transaction tax.")]
    TransactionTax = RateTypeCode.TransactionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security for which tax is deferred.
    /// Encoded/decoded by serializers as "TXDF".
    /// </summary>
    [EnumMember(Value = "TXDF")]
    [IsoId("_ZZcZo9p-Ed-ak6NoX_4Aeg_-1692317963")]
    [Description(@"Rate relating to the underlying security for which tax is deferred.")]
    TaxDeferred = RateTypeCode.TaxDeferred, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate relating to the underlying security which is not taxable.
    /// Encoded/decoded by serializers as "TXFR".
    /// </summary>
    [EnumMember(Value = "TXFR")]
    [IsoId("_ZZcZpNp-Ed-ak6NoX_4Aeg_-1692317962")]
    [Description(@"Rate relating to the underlying security which is not taxable.")]
    TaxFeeAmount = RateTypeCode.TaxFeeAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as "WITF".
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_ZZcZpdp-Ed-ak6NoX_4Aeg_-1692317933")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax = RateTypeCode.WithholdingOfForeignTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as "WITL".
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_ZZcZptp-Ed-ak6NoX_4Aeg_-1692317932")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax = RateTypeCode.WithholdingOfLocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as "TAXR".
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_ZZcZp9p-Ed-ak6NoX_4Aeg_-1692317902")]
    [Description(@"Relates to a tax refund from the authorities on the associated corporate action event.")]
    WithholdingTax = RateTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateType2CodeMetadataExtensions
{
    private static readonly RateType2CodeDropdownSource _dropdownSource = new RateType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateType2CodeDropdownRow GetMetadata(this RateType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


