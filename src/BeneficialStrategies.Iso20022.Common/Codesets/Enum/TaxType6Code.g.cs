﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxType6Code.  ISO2002 ID# _VfGrA9p-Ed-ak6NoX_4Aeg_-1047538483.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VfGrA9p-Ed-ak6NoX_4Aeg_-1047538483")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType6Code
{
    /// <summary>
    /// Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as "InterimProfitTax".
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_VfGrBNp-Ed-ak6NoX_4Aeg_1202035473")]
    [Description(@"Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.")]
    InterimProfitTax,
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as "EUTaxRetention".
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_VfGrBdp-Ed-ak6NoX_4Aeg_1214962922")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "Aktiengewinn1".
    /// </summary>
    [EnumMember(Value = "AKT1")]
    [IsoId("_VfGrBtp-Ed-ak6NoX_4Aeg_-629185374")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn1,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as "Aktiengewinn2".
    /// </summary>
    [EnumMember(Value = "AKT2")]
    [IsoId("_VfGrB9p-Ed-ak6NoX_4Aeg_-629185365")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn2,
    
    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as "Zwischengewinn".
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_VfGrCNp-Ed-ak6NoX_4Aeg_-629183703")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn,
    
    /// <summary>
    /// Another type of tax.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VfGrCdp-Ed-ak6NoX_4Aeg_-1567419793")]
    [Description(@"Another type of tax.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxType6CodeMetadataExtensions
{
    private static readonly TaxType6CodeDropdownSource _dropdownSource = new TaxType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxType6CodeDropdownRow GetMetadata(this TaxType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


