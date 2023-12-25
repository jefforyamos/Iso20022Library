﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalBalanceTypeCode.  ISO2002 ID# _Nl6j4IakEeeUws0ZryHQ2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance type, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Nl6j4IakEeeUws0ZryHQ2w")]
[Description(@"Specifies the balance type, as published in an external balance type code set. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalBalanceTypeCode
{
    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified. 
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_ua6dY_RYEeuLhpyIdtJzwg")]
    [Description(@"Closing balance of amount of money that is at the disposal of the account owner on the date specified. ")]
    CLAV,
    
    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period. 
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_ua6dZvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period. ")]
    CLBD,
    
    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified. 
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_ua6dafRYEeuLhpyIdtJzwg")]
    [Description(@"Forward available balance of money that is at the disposal of the account owner on the date specified. ")]
    FWAV,
    
    /// <summary>
    /// Balance for informational purposes. 
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_ua6dbPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance for informational purposes. ")]
    INFO,
    
    /// <summary>
    /// Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. 
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_ubDnUPRYEeuLhpyIdtJzwg")]
    [Description(@"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. ")]
    ITAV,
    
    /// <summary>
    /// Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. 
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_ubDnU_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. ")]
    ITBD,
    
    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified. 
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_ubDnVvRYEeuLhpyIdtJzwg")]
    [Description(@"Opening balance of amount of money that is at the disposal of the account owner on the date specified. ")]
    OPAV,
    
    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. 
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_ubDnWfRYEeuLhpyIdtJzwg")]
    [Description(@"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. ")]
    OPBD,
    
    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.|Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_ubNYUPRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.|Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.")]
    PRCD,
    
    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted. 
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_ubNYU_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted. ")]
    XPCD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalBalanceTypeCodeMetadataExtensions
{
    private static readonly ExternalBalanceTypeCodeDropdownSource _dropdownSource = new ExternalBalanceTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalBalanceTypeCodeDropdownRow GetMetadata(this ExternalBalanceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


