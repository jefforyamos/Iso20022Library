﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeBearerTypeCode.  ISO2002 ID# _a8PpJ9p-Ed-ak6NoX_4Aeg_-779465922.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8PpJ9p-Ed-ak6NoX_4Aeg_-779465922")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the instruction.")]
public enum ChargeBearerTypeCode
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as "DEBT".
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_a8YzENp-Ed-ak6NoX_4Aeg_-779465905")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor,
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as "CRED".
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_a8YzEdp-Ed-ak6NoX_4Aeg_-779465887")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor,
    
    /// <summary>
    /// In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.
    /// Encoded/decoded by serializers as "SHAR".
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_a8YzEtp-Ed-ak6NoX_4Aeg_-779465862")]
    [Description(@"In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.")]
    Shared,
    
    /// <summary>
    /// Charges are to be applied following the rules agreed in the service level and/or scheme.
    /// Encoded/decoded by serializers as "SLEV".
    /// </summary>
    [EnumMember(Value = "SLEV")]
    [IsoId("_a8YzE9p-Ed-ak6NoX_4Aeg_-725902015")]
    [Description(@"Charges are to be applied following the rules agreed in the service level and/or scheme.")]
    FollowingServiceLevel,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeBearerTypeCodeMetadataExtensions
{
    private static readonly ChargeBearerTypeCodeDropdownSource _dropdownSource = new ChargeBearerTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeBearerTypeCodeDropdownRow GetMetadata(this ChargeBearerTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


