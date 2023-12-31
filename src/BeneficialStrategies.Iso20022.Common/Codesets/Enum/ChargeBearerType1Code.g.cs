﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeBearerType1Code.  ISO2002 ID# _a8PpINp-Ed-ak6NoX_4Aeg_940131843.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8PpINp-Ed-ak6NoX_4Aeg_940131843")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the instruction.")]
[DerivedFrom(typeof(ChargeBearerTypeCode))]
public enum ChargeBearerType1Code
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as "BorneByDebtor".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_a8PpIdp-Ed-ak6NoX_4Aeg_1019554986")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor,
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as "BorneByCreditor".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_a8PpItp-Ed-ak6NoX_4Aeg_1019555004")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor,
    
    /// <summary>
    /// In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.
    /// Encoded/decoded by serializers as "Shared".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_a8PpI9p-Ed-ak6NoX_4Aeg_1019555021")]
    [Description(@"In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.")]
    Shared,
    
    /// <summary>
    /// Charges are to be applied following the rules agreed in the service level and/or scheme.
    /// Encoded/decoded by serializers as "FollowingServiceLevel".
    /// </summary>
    [EnumMember(Value = "SLEV")]
    [IsoId("_a8PpJNp-Ed-ak6NoX_4Aeg_1139613709")]
    [Description(@"Charges are to be applied following the rules agreed in the service level and/or scheme.")]
    FollowingServiceLevel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeBearerType1CodeMetadataExtensions
{
    private static readonly ChargeBearerType1CodeDropdownSource _dropdownSource = new ChargeBearerType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeBearerType1CodeDropdownRow GetMetadata(this ChargeBearerType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


