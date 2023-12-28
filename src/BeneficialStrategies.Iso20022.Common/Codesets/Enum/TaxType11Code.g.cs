﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType11Code.  ISO2002 ID# _Yj88FNp-Ed-ak6NoX_4Aeg_7019536.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yj88FNp-Ed-ak6NoX_4Aeg_7019536")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType11Code
{
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as "Provincial".
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_Yj88Fdp-Ed-ak6NoX_4Aeg_7019555")]
    [Description(@"Tax is a provincial tax.")]
    Provincial,
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as "NationalTax".
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_Yj88Ftp-Ed-ak6NoX_4Aeg_7019556")]
    [Description(@"Tax is a national tax.")]
    NationalTax,
    
    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as "StateTax".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_Yj88F9p-Ed-ak6NoX_4Aeg_7019571")]
    [Description(@"Tax is a state tax.")]
    StateTax,
    
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as "WithholdingTax".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_Yj88GNp-Ed-ak6NoX_4Aeg_7019572")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax,
    
    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as "CapitalGainTax".
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_Yj88Gdp-Ed-ak6NoX_4Aeg_7019589")]
    [Description(@"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.")]
    CapitalGainTax,
    
    /// <summary>
    /// Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as "InterimProfitTax".
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_YkGGANp-Ed-ak6NoX_4Aeg_7019590")]
    [Description(@"Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.")]
    InterimProfitTax,
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as "StampDuty".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_YkGGAdp-Ed-ak6NoX_4Aeg_7019614")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty,
    
    /// <summary>
    /// Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as "WealthTax".
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_YkGGAtp-Ed-ak6NoX_4Aeg_7019615")]
    [Description(@"Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.")]
    WealthTax,
    
    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as "InheritanceTax".
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_YkGGA9p-Ed-ak6NoX_4Aeg_7019631")]
    [Description(@"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.")]
    InheritanceTax,
    
    /// <summary>
    /// Tax that is levied by legal authorities for solidarity purposes.
    /// Encoded/decoded by serializers as "SolidaritySurcharge".
    /// </summary>
    [EnumMember(Value = "SOSU")]
    [IsoId("_YkGGBNp-Ed-ak6NoX_4Aeg_7019649")]
    [Description(@"Tax that is levied by legal authorities for solidarity purposes.")]
    SolidaritySurcharge,
    
    /// <summary>
    /// Direct reduction of an individual's tax liability.
    /// Encoded/decoded by serializers as "TaxCredit".
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_YkGGBdp-Ed-ak6NoX_4Aeg_7019650")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit,
    
    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as "GiftTax".
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_YkGGBtp-Ed-ak6NoX_4Aeg_7019674")]
    [Description(@"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.")]
    GiftTax,
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as "ConsumptionTax".
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_YkGGB9p-Ed-ak6NoX_4Aeg_7019675")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax,
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as "EUTaxRetention".
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_YkGGCNp-Ed-ak6NoX_4Aeg_7019691")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "Aktiengewinn1".
    /// </summary>
    [EnumMember(Value = "AKT1")]
    [IsoId("_YkGGCdp-Ed-ak6NoX_4Aeg_7019692")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn1,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "Aktiengewinn2".
    /// </summary>
    [EnumMember(Value = "AKT2")]
    [IsoId("_YkP3ANp-Ed-ak6NoX_4Aeg_7019709")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn2,
    
    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as "Zwischengewinn".
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_YkP3Adp-Ed-ak6NoX_4Aeg_7019710")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType11CodeMetadataExtensions
{
    private static readonly TaxType11CodeDropdownSource _dropdownSource = new TaxType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType11CodeDropdownRow GetMetadata(this TaxType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


