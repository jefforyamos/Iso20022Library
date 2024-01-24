﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType9Code.  ISO2002 ID# _Yksi8tp-Ed-ak6NoX_4Aeg_-2094415821.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yksi8tp-Ed-ak6NoX_4Aeg_-2094415821")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType9Code
{
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as "PROV".
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_Yksi89p-Ed-ak6NoX_4Aeg_-1809973337")]
    [Description(@"Tax is a provincial tax.")]
    Provincial = TaxTypeCode.Provincial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as "NATI".
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_Yksi9Np-Ed-ak6NoX_4Aeg_-1809973277")]
    [Description(@"Tax is a national tax.")]
    NationalTax = TaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as "STAT".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_Yksi9dp-Ed-ak6NoX_4Aeg_-1809973260")]
    [Description(@"Tax is a state tax.")]
    StateTax = TaxTypeCode.StateTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_Yksi9tp-Ed-ak6NoX_4Aeg_-1809973242")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax = TaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as "STAM".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_Yksi99p-Ed-ak6NoX_4Aeg_-1809972969")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty = TaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as "COAX".
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_Yk2T8Np-Ed-ak6NoX_4Aeg_-1809972968")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax = TaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as "VATA".
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_Yk2T8dp-Ed-ak6NoX_4Aeg_-1791501938")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax = TaxTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is customs and excise.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Yk2T8tp-Ed-ak6NoX_4Aeg_-1830323614")]
    [Description(@"Tax is customs and excise.")]
    CustomsTax = TaxTypeCode.CustomsTax, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType9CodeMetadataExtensions
{
    private static readonly TaxType9CodeDropdownSource _dropdownSource = new TaxType9CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType9CodeDropdownRow GetMetadata(this TaxType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


