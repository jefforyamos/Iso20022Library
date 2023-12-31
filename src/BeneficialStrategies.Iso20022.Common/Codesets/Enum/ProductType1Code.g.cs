﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProductType1Code.  ISO2002 ID# _ZWKcIdp-Ed-ak6NoX_4Aeg_-1402597074.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWKcIdp-Ed-ak6NoX_4Aeg_-1402597074")]
[Description(@"Specifies the type of product or financial instrument.")]
[DerivedFrom(typeof(ProductTypeCode))]
public enum ProductType1Code
{
    /// <summary>
    /// Identifies categories of instruments issued by federal agencies.
    /// Encoded/decoded by serializers as "Agency".
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_ZWKcItp-Ed-ak6NoX_4Aeg_-1124617360")]
    [Description(@"Identifies categories of instruments issued by federal agencies.")]
    Agency,
    
    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// Encoded/decoded by serializers as "Commodity".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_ZWKcI9p-Ed-ak6NoX_4Aeg_-1124617335")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    Commodity,
    
    /// <summary>
    /// Identifies categories of instruments issued by corporates.
    /// Encoded/decoded by serializers as "Corporate".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_ZWKcJNp-Ed-ak6NoX_4Aeg_-1124617334")]
    [Description(@"Identifies categories of instruments issued by corporates.")]
    Corporate,
    
    /// <summary>
    /// Identifies categories of currency instruments.
    /// Encoded/decoded by serializers as "Currency".
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_ZWKcJdp-Ed-ak6NoX_4Aeg_-1124617318")]
    [Description(@"Identifies categories of currency instruments.")]
    Currency,
    
    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as "Equity".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_ZWKcJtp-Ed-ak6NoX_4Aeg_-1124617317")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity,
    
    /// <summary>
    /// Identifies categories of obligations issued by a government.
    /// Encoded/decoded by serializers as "Government".
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_ZWKcJ9p-Ed-ak6NoX_4Aeg_-1124617300")]
    [Description(@"Identifies categories of obligations issued by a government.")]
    Government,
    
    /// <summary>
    /// Identifies categories of loans.
    /// Encoded/decoded by serializers as "Loan".
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZWKcKNp-Ed-ak6NoX_4Aeg_-1124617282")]
    [Description(@"Identifies categories of loans.")]
    Loan,
    
    /// <summary>
    /// Identifies categories of short-term debt securities maturing in less than one year.
    /// Encoded/decoded by serializers as "MoneyMarket".
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_ZWKcKdp-Ed-ak6NoX_4Aeg_-1124617265")]
    [Description(@"Identifies categories of short-term debt securities maturing in less than one year.")]
    MoneyMarket,
    
    /// <summary>
    /// Identifies categories of mortgage securities.
    /// Encoded/decoded by serializers as "Mortgage".
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_ZWUNINp-Ed-ak6NoX_4Aeg_-1124617264")]
    [Description(@"Identifies categories of mortgage securities.")]
    Mortgage,
    
    /// <summary>
    /// Identifies categories of securities issued by states and local governments.
    /// Encoded/decoded by serializers as "Municipal".
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_ZWUNIdp-Ed-ak6NoX_4Aeg_-1124617240")]
    [Description(@"Identifies categories of securities issued by states and local governments.")]
    Municipal,
    
    /// <summary>
    /// Identifies categories of financing instruments.
    /// Encoded/decoded by serializers as "Financing".
    /// </summary>
    [EnumMember(Value = "FINA")]
    [IsoId("_ZWUNItp-Ed-ak6NoX_4Aeg_-1124617223")]
    [Description(@"Identifies categories of financing instruments.")]
    Financing,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProductType1CodeMetadataExtensions
{
    private static readonly ProductType1CodeDropdownSource _dropdownSource = new ProductType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProductType1CodeDropdownRow GetMetadata(this ProductType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


