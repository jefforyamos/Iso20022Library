﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType17Code.  ISO2002 ID# _Y3eIUDiGEeaH-93K5JKmzw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y3eIUDiGEeaH-93K5JKmzw")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType17Code
{
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as "Provincial".
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_rUv78TiGEeaH-93K5JKmzw")]
    [Description(@"Tax is a provincial tax.")]
    Provincial,
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as "NationalTax".
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_r1U5cTiGEeaH-93K5JKmzw")]
    [Description(@"Tax is a national tax.")]
    NationalTax,
    
    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as "StateTax".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_scwF0TiGEeaH-93K5JKmzw")]
    [Description(@"Tax is a state tax.")]
    StateTax,
    
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as "WithholdingTax".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_tGj30TiGEeaH-93K5JKmzw")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax,
    
    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as "CapitalGainTax".
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_u1_OETiGEeaH-93K5JKmzw")]
    [Description(@"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.")]
    CapitalGainTax,
    
    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as "CapitalLossCredit".
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_vCVoATiGEeaH-93K5JKmzw")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit,
    
    /// <summary>
    /// Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as "InterimProfitTax".
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_wBkQYTiGEeaH-93K5JKmzw")]
    [Description(@"Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.")]
    InterimProfitTax,
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as "StampDuty".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_wuDi8TiGEeaH-93K5JKmzw")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty,
    
    /// <summary>
    /// Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as "WealthTax".
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_xH8CkTiGEeaH-93K5JKmzw")]
    [Description(@"Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.")]
    WealthTax,
    
    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as "InheritanceTax".
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_yWVvYTiGEeaH-93K5JKmzw")]
    [Description(@"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.")]
    InheritanceTax,
    
    /// <summary>
    /// Tax that is levied by legal authorities for solidarity purposes.
    /// Encoded/decoded by serializers as "SolidaritySurcharge".
    /// </summary>
    [EnumMember(Value = "SOSU")]
    [IsoId("_yzNRkTiGEeaH-93K5JKmzw")]
    [Description(@"Tax that is levied by legal authorities for solidarity purposes.")]
    SolidaritySurcharge,
    
    /// <summary>
    /// Direct reduction of an individual's tax liability.
    /// Encoded/decoded by serializers as "TaxCredit".
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_z8GzUTiGEeaH-93K5JKmzw")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit,
    
    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as "GiftTax".
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_0cY14TiGEeaH-93K5JKmzw")]
    [Description(@"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.")]
    GiftTax,
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as "ConsumptionTax".
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_1CelgTiGEeaH-93K5JKmzw")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax,
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as "EUTaxRetention".
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_2NwF0TiGEeaH-93K5JKmzw")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "Aktiengewinn1".
    /// </summary>
    [EnumMember(Value = "AKT1")]
    [IsoId("_3mbI8TiGEeaH-93K5JKmzw")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn1,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "Aktiengewinn2".
    /// </summary>
    [EnumMember(Value = "AKT2")]
    [IsoId("_31TScTiGEeaH-93K5JKmzw")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn2,
    
    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as "Zwischengewinn".
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_4ofC4TiGEeaH-93K5JKmzw")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType17CodeMetadataExtensions
{
    private static readonly TaxType17CodeDropdownSource _dropdownSource = new TaxType17CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType17CodeDropdownRow GetMetadata(this TaxType17Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


