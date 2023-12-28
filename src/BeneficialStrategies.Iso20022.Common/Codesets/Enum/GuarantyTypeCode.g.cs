﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GuarantyTypeCode.  ISO2002 ID# _au04N9p-Ed-ak6NoX_4Aeg_1142175847.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of credit enhancement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_au04N9p-Ed-ak6NoX_4Aeg_1142175847")]
[Description(@"Specifies the type of credit enhancement.")]
public enum GuarantyTypeCode
{
    /// <summary>
    /// Simple guaranty.
    /// Encoded/decoded by serializers as "SIMP".
    /// </summary>
    [EnumMember(Value = "SIMP")]
    [IsoId("_au04ONp-Ed-ak6NoX_4Aeg_1429387658")]
    [Description(@"Simple guaranty.")]
    Simple,
    
    /// <summary>
    /// Joint guaranty.
    /// Encoded/decoded by serializers as "JOIN".
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_au-pMNp-Ed-ak6NoX_4Aeg_1430311118")]
    [Description(@"Joint guaranty.")]
    Joint,
    
    /// <summary>
    /// Security is guaranteed by collateral, ie, assets pledged to a lender until a loan is repaid.
    /// Encoded/decoded by serializers as "COLA".
    /// </summary>
    [EnumMember(Value = "COLA")]
    [IsoId("_au-pMdp-Ed-ak6NoX_4Aeg_1430314369")]
    [Description(@"Security is guaranteed by collateral, ie, assets pledged to a lender until a loan is repaid.")]
    Collateral,
    
    /// <summary>
    /// Security is guaranteed by the government.
    /// Encoded/decoded by serializers as "GOVE".
    /// </summary>
    [EnumMember(Value = "GOVE")]
    [IsoId("_au-pMtp-Ed-ak6NoX_4Aeg_1438626058")]
    [Description(@"Security is guaranteed by the government.")]
    Government,
    
    /// <summary>
    /// Security is guaranteed by a lien, ie, a creditor's claim against property, for example, a mortgage is a lien against a house.
    /// Encoded/decoded by serializers as "LIEN".
    /// </summary>
    [EnumMember(Value = "LIEN")]
    [IsoId("_au-pM9p-Ed-ak6NoX_4Aeg_1440471690")]
    [Description(@"Security is guaranteed by a lien, ie, a creditor's claim against property, for example, a mortgage is a lien against a house.")]
    Lien,
    
    /// <summary>
    /// Security is guaranteed by a letter of credit, ie, a document issued by a bank guaranteeing the payment up to a stated amount for a specified period.
    /// Encoded/decoded by serializers as "LCRE".
    /// </summary>
    [EnumMember(Value = "LCRE")]
    [IsoId("_au-pNNp-Ed-ak6NoX_4Aeg_1444167184")]
    [Description(@"Security is guaranteed by a letter of credit, ie, a document issued by a bank guaranteeing the payment up to a stated amount for a specified period.")]
    LetterOfCredit,
    
    /// <summary>
    /// Security has a negative pledge, ie, the issuer will not pledge any assets if doing so would result in less security for the investors.
    /// Encoded/decoded by serializers as "NPLG".
    /// </summary>
    [EnumMember(Value = "NPLG")]
    [IsoId("_au-pNdp-Ed-ak6NoX_4Aeg_1445090705")]
    [Description(@"Security has a negative pledge, ie, the issuer will not pledge any assets if doing so would result in less security for the investors.")]
    NegativePledge,
    
    /// <summary>
    /// Security is guaranteed by an insurance policy.
    /// Encoded/decoded by serializers as "INSU".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_au-pNtp-Ed-ak6NoX_4Aeg_1446014287")]
    [Description(@"Security is guaranteed by an insurance policy.")]
    Insurance,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GuarantyTypeCodeMetadataExtensions
{
    private static readonly GuarantyTypeCodeDropdownSource _dropdownSource = new GuarantyTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGuarantyTypeCodeDropdownRow GetMetadata(this GuarantyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

