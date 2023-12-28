﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundingSourceType2Code.  ISO2002 ID# _yKJtINwoEeeiWo5KG3eipw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of funding source used for a financial service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yKJtINwoEeeiWo5KG3eipw")]
[Description(@"Type of funding source used for a financial service.")]
[DerivedFrom(typeof(FundingSourceTypeCode))]
public enum FundingSourceType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Loyaly".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_4MzzIdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    Loyaly,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_46oicdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_5EAg4dwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Savings".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_6QVKEdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    Savings,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Universal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7OOVsdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    Universal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_9LyOkdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    Cash,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_-ayYUdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    CreditCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DebitCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__Y0t4dwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    DebitCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EpurseCard".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__r3lsdwoEeeiWo5KG3eipw")]
    [Description(@"??")]
    EpurseCard,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DebitAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Av_8MdwpEeeiWo5KG3eipw")]
    [Description(@"??")]
    DebitAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Current".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BI_rAdwpEeeiWo5KG3eipw")]
    [Description(@"??")]
    Current,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cheque".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BviGkdwpEeeiWo5KG3eipw")]
    [Description(@"??")]
    Cheque,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrePaid".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DMhB8dwpEeeiWo5KG3eipw")]
    [Description(@"??")]
    PrePaid,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LineOfCredit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_7u4G4eFmEeeA0cKTZTRL5g")]
    [Description(@"??")]
    LineOfCredit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundingSourceType2CodeMetadataExtensions
{
    private static readonly FundingSourceType2CodeDropdownSource _dropdownSource = new FundingSourceType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundingSourceType2CodeDropdownRow GetMetadata(this FundingSourceType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


